using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class client : Form
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        public client()
        {
            InitializeComponent();
        }

        

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient != null && tcpClient.Connected)
                {
                    string message = MessageTextBox.Text;
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    AddMessageToDisplay("Sent: " + message);
                }
                else
                {
                    AddMessageToDisplay("Chưa kết nối đến máy chủ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageTextBox.Clear();

        }

        private void btnconect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect("127.0.0.1", int.Parse("8080"));
                stream = tcpClient.GetStream();

                AddMessageToDisplay("Connect .");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddMessageToDisplay(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddMessageToDisplay), message);
                return;
            }

            ReceivedMessagesListBox.Items.Add(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
