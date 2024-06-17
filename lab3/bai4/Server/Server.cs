using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

/*        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach(Socket item in clientList)
            {
                Send(item);     
            }
            txbMessage.Clear();
        }*/
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        //Server lang nghe 
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread recieve = new Thread(Recieve);
                        recieve.IsBackground = true;
                        recieve.Start(client);
                    }
                }
                catch (Exception ex)
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
               
  
            });
            listen.IsBackground = true;
            listen.Start();

        }
        // Đóng kết nối hiện thời 
/*        void Close()
        {
            server.Close();
        }*/
        // gửi tin tới các client khác

/*        void Send(object obj)
        {
            Socket client = obj as Socket;
            if (txbMessage.Text != String.Empty)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(txbMessage.Text);
                client.Send(bytes);
            }
        }*/
        //Nhận tin từ các client khác 
        void Recieve(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    
                    //new chuyen byte sang string
                    String message = Encoding.UTF8.GetString(data);
                    AddMessage(message);
                    foreach (Socket item in clientList)
                    {
                        if (client != null && item != client)
                        {
                            item.Send(data);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
               clientList.Remove(client);
                client.Close();
            }


        }
        void AddMessage(String s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
        }

        private void lsvMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
