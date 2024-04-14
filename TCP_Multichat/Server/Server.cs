using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Security;

namespace Server
{
    public partial class Server : Form
    {
        IPEndPoint IP;
        X509Certificate2 certificate;
        List<SslStream> clientList;

        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private static X509Certificate getServerCert()
        {
            X509Store allCert = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            allCert.Open(OpenFlags.ReadOnly);

            X509Certificate2 certFounded = null;
            foreach (X509Certificate2 currentCert in allCert.Certificates)
            {
                if (currentCert.IssuerName.Name != null && currentCert.IssuerName.Name.Equals("CN=server_certificate_name")) 
                {
                    certFounded = currentCert;
                    break;
                }
            }
            return certFounded;
        }

        bool Check_IP_Port(string a, string b)
        {
            string pattern_ID = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            if (!Regex.IsMatch(a, pattern_ID))
                return false;
            string pattern_port = @"^(6553[0-5]|655[0-2]\d|65[0-4]\d{2}|6[0-4]\d{3}|[1-5]?\d{1,4})$";
            if (!Regex.IsMatch(b, pattern_port))
                return false;
            return true;
        }
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (SslStream client in clientList)
                client.Close();
            certificate?.Dispose();
        }

        void Connect()
        {
            if (Check_IP_Port(inputIP.Text, inputPort.Text))
            {
                clientList = new List<SslStream>();
                IP = new IPEndPoint(IPAddress.Parse(inputIP.Text), int.Parse(inputPort.Text));
                certificate = new X509Certificate2("server.pfx", "password");
                Thread listen = new Thread(() => {
                    try
                    {
                        TcpListener listener = new TcpListener(IP);
                        listener.Start();
                        while (true)
                        {
                            Socket clientSocket = listener.AcceptSocket();
                            SslStream clientStream = new SslStream(
                                new NetworkStream(clientSocket),
                                false,
                                (sender, certificate, chain, errors) => true // Hàm callback (tùy chọn) để xác thực chứng chỉ server 
                            );

                            clientStream.AuthenticateAsServer(certificate, false, SslProtocols.Tls12, false);
                            clientList.Add(clientStream);

                            Thread receive = new Thread(Receive);
                            receive.IsBackground = true;
                            receive.Start(clientStream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
                listen.IsBackground = true;
                listen.Start();
                MessageBox.Show("Server đã mở kết nối SSL", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Vui lòng nhập lại IP hoặc port", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void Disconnect()
        {
            foreach (SslStream client in clientList)
            {
                client.Close();
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            foreach (SslStream client in clientList)
            {
                Send(client);
            }
            Message_Add(serverName.Text + ": " + txtMessage.Text);
            txtMessage.Clear();
        }

        void Send(SslStream client)
        {
            if (client != null && txtMessage.Text != "")
            {
                byte[] data = Serialize(serverName.Text + ": " + txtMessage.Text);
                client.Write(data, 0, data.Length);
            }
        }

        void Receive(Object obj)
        {
            SslStream client = obj as SslStream;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytesRead = client.Read(data, 0, data.Length);

                    if (bytesRead == 0)
                    {
                        break; // Client disconnected
                    }

                    string displayedMessage = (string)Deserialize(data.Take(bytesRead).ToArray());
                    Message_Add(displayedMessage);

                    foreach (SslStream item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            data = Serialize(displayedMessage);
                            item.Write(data, 0, data.Length);
                        }
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }

        }

        void Message_Add(string message)
        {
         
            if (messageLv.InvokeRequired)
                messageLv.Invoke(new Action<string>(Message_Add), new object[] { message });
            else
                messageLv.Items.Add(new ListViewItem() { Text = DateTime.Now.ToString("HH:mm:ss") + " -  " + message });
        }

        byte[] Serialize(object send)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, send);

            return stream.ToArray();
        }

        object Deserialize(byte[] receive)
        {
            MemoryStream stream = new MemoryStream(receive);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void listen_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}