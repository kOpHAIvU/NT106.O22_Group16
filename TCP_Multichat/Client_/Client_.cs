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

namespace Client_
{
    public partial class Client_ : Form
    {
        IPEndPoint IP;
        Socket client;
        public Client_()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1111);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối với Server!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Disconnect()
        {
            client.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Send();
            Message_Add(guestName.Text + ": " + txtMessage.Text);
        }

        void Send()
        {
            if (txtMessage.Text != "")
                client.Send(Serialize(guestName.Text + ": " + txtMessage.Text));
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    Message_Add((string)Deserialize(data));
                }
            }
            catch
            {
                Disconnect();
            }
        }

        void Message_Add(string message)
        {
            messageLv.Items.Add(new ListViewItem() { Text = message });
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
    }
}
