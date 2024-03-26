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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        public Server()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Close();
        }

        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 1111);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                } catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 1111);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true ;
            listen.Start();
        }

        void Disconnect()
        {
            server.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList) 
            {
                Send(item);
            }
            Message_Add(serverName.Text + ": " + txtMessage.Text);
            txtMessage.Clear();
        }

        void Send(Socket client)
        {
            if (client != null && txtMessage.Text != "")
                client.Send(Serialize(serverName.Text + ": " + txtMessage.Text));
        }

        void Receive(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    Message_Add((string)Deserialize(data));
                    
                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                            item.Send(Serialize((string)Deserialize(data)));
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
            messageLv.Items.Add(new ListViewItem() { Text = message });
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
    }
}
