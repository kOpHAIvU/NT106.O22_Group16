using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Security;

namespace Client_
{
    public partial class Client_ : Form
    {
        IPEndPoint IP;
        SslStream clientStream = null;
        public Client_()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }

        bool check_ip_port(string a, string b)
        {
            string pattern_ID = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            if (!Regex.IsMatch(a, pattern_ID))
            {
                return false;
            }
            string pattern_port = @"^(6553[0-5]|655[0-2]\d|65[0-4]\d{2}|6[0-4]\d{3}|[1-5]?\d{1,4})$";
            if (!Regex.IsMatch(b, pattern_port))
            {
                return false;
            }
            return true;
        }

        void Connect()
        {
            if (check_ip_port(inputIP.Text, inputPort.Text))
            {
                try
                {
                    IPAddress serverIp = IPAddress.Parse(inputIP.Text);
                    int serverPort = int.Parse(inputPort.Text);
                    IP = new IPEndPoint(serverIp, serverPort);

                    // Load server certificate from PFX file (replace with your path)
                    X509Certificate2 certificate = new X509Certificate2("server.pfx", "29032004");
                    var clientCertificateCollection = new
                    X509CertificateCollection(new X509Certificate[]
                        { certificate });

                    // Create secure connection (SSL Stream)
                    TcpClient tcpClient = new TcpClient(IP.Address.ToString(), IP.Port);
                    clientStream = new SslStream(tcpClient.GetStream(), false, ValidateCert);
                    clientStream.AuthenticateAsClient("clientName", clientCertificateCollection, SslProtocols.Tls12, false); // Use TLS 1.2 for security

                    Thread listen1 = new Thread(Receive);
                    listen1.IsBackground = true;
                    listen1.Start();
                    MessageBox.Show("Đã kết nối với Server (SSL)", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
                MessageBox.Show("Đã kết nối với Server", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Vui lòng nhập lại IP hoặc port", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateCert(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return sslPolicyErrors == SslPolicyErrors.None;
        }

        void Disconnect()
        {
            if (clientStream != null)
                clientStream.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (clientStream != null && txtMessage.Text != "")
            {
                byte[] data = Serialize(guestName.Text + ": " + txtMessage.Text);
                clientStream.Write(data, 0, data.Length);
                Message_Add(guestName.Text + ": " + txtMessage.Text);
            }
        }

        void Receive()
        {
            try
            {
                while (clientStream != null && clientStream.CanRead)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytesRead = clientStream.Read(data, 0, data.Length);

                    if (bytesRead == 0)
                    {
                        break; // Client disconnected
                    }

                    Message_Add(Deserialize(data.Take(bytesRead).ToArray()).ToString());
                }
            }
            catch
            {
                Disconnect();
            }
        }

        void Message_Add(string message)
        {
            if (messageLv.InvokeRequired)
            {
                messageLv.Invoke(new Action<string>(Message_Add), new object[] { message });
            }
            else
            {
                messageLv.Items.Add(new ListViewItem() { Text = DateTime.Now.ToString("HH:mm:ss") + " -  " + message });
            }
            txtMessage.Clear();
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

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}