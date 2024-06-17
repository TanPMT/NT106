
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace thuchanhlab3
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StarunsafeThread));
            serverThread.Start();
            btn_listen.Enabled = false;
        }
        
        void StarunsafeThread()
        {
            int ByteReceived = 0;
            byte[] recv = new byte[1];
            Socket ClientSocket;
            Socket ListenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            ListenerSocket.Bind(ipepServer);
            ListenerSocket.Listen(-1);
            ClientSocket = ListenerSocket.Accept();

            ListViewCommand.Items.Add(new ListViewItem("127.0.0.1:8080"));

            while (ClientSocket.Connected)
            {
                if (!ClientSocket.Connected)
                {
                    ListenerSocket.Close();

                }
                string text = "";
                do
                {
                    ByteReceived = ClientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);

                } while (text.Length > 0 && text[text.Length - 1] != '\n');

                // Xử lý dữ liệu nhận được ở đây (ví dụ: loại bỏ ký tự '\n' cuối cùng nếu có)

                if (!string.IsNullOrEmpty(text))
                {
                    // Thêm một mục mới vào ListView
                    ListViewCommand.Items.Add(new ListViewItem(text));
                }
                
            }
            ListenerSocket.Close();
        }

        private void ListViewCommand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
