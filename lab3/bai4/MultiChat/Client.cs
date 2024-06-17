using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiChat
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send();
        }

        IPEndPoint IP;
        Socket client;

        //Kết nối tới server 
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khong the ket noi toi server", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //kết nối thành công thì tạo liền một cái luồng để luôn lắng nghe thông tin nhận được
            Thread listen = new Thread(Recieve);
            listen.IsBackground = true;
            listen.Start();

        }
        // Đóng kết nối hiện thời 
        void Close()
        {
            client.Close();
        }
        // gửi tin tới các client khác

        void Send()
        {
            if (txbMessage.Text != String.Empty)
            {
                // Define a dictionary to map emoticons to emojis
                Dictionary<string, string> emoticonToEmoji = new Dictionary<string, string>
                {
                    // Your emoticon to emoji mappings here...
                     { ":)", "😊" },
    { ":D", "😃" },
    { ":(", "😢" },
    { ";)", "😉" },
    { ":P", "😛" },
    { ":O", "😮" },
    { "XD", "😂" },
    { ":'(", "😭" },
    { ":|", "😐" },
    { ":*", "😘" },
    { "<3", "❤️" },
    { ":@", "😡" },
    { "B)", "😎" },
    { "O:)", "😇" },
    { ":S", "😖" },
    { "8)", "😬" },
    { "D:", "😦" },
    { ":$", "😳" },
    { ":/", "😕" },
    { ">:(", "😠" },
    { "3:)", "😈" },
    { "o.O", "😲" },
    { ":-X", "😷" },
    { ":-#", "🤐" },
    { ">:O", "😱" },
    { ":-)", "😊" },
    { ":-D", "😃" },
    { ":-(", "😢" },
    { ";-)", "😉" },
    { ":-P", "😛" },
    { ":-o", "😮" },
    { "X-D", "😂" },
    { ":'-(", "😭" },
    { ":-|", "😐" },
    { ":-*", "😘" },
    { ":-@", "😡" },
    { "B-)", "😎" },
    { "O:-)", "😇" },
    { ":-S", "😖" },
    { "8-)", "😬" },
    { ":-$", "😳" },
    { ":-/", "😕" },
    { "3:-)", "😈" },
    { "O.o", "😲" }
                };

                // Get the message text
                string message = txbMessage.Text;

                // Check if the message is "deletechat"
                if (message.Trim().ToLower() == "deletechat")
                {
                    // Send the "deletechat" message
                    byte[] deleteChatMessage = Encoding.UTF8.GetBytes("deletechat");
                    client.Send(deleteChatMessage);

                    // Clear the chat box
                    lsvMessage.Clear();
                }
                else
                {
                    // Replace emoticons with emojis
                    foreach (var pair in emoticonToEmoji)
                    {
                        message = message.Replace(pair.Key, pair.Value);
                    }

                    // Convert the modified message to bytes using UTF8 encoding
                    //byte[] bytes = Encoding.UTF8.GetBytes(textBox1.Text + ": " + message);
                    byte[] bytes = Encoding.UTF8.GetBytes(message);

                    // Send the bytes to the client
                    client.Send(bytes);

                    // Add the message to the display
                    AddMessage(Encoding.UTF8.GetString(bytes));
                }
            }
        }





        //Nhận tin từ các client khác 
        void Recieve()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    // Convert byte array to string
                    string message = Encoding.UTF8.GetString(data);

                    // Check if the message is 'deletechat'
                    if (message == "deletechat")
                    {
                        // Clear all messages in the chat box
                        lsvMessage.Clear();
                    }
                    else
                    {
                        // Add the received message to the chat box
                        AddMessage(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Close();
            }
        }



        void AddMessage(String s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txbMessage.Clear();
        }

  
        private void Client_FormClosed(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
