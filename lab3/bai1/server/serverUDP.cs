using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace server
{
    public partial class serverUDP : Form
    {
        public serverUDP()
        {
            InitializeComponent();
        }
        private UdpClient udpClient;
        private int port;

        private void button1_Click(object sender, EventArgs e)
        {
            port = Convert.ToInt32(textBox1.Text);
            udpClient = new UdpClient(port);

            // Bắt đầu một luồng riêng biệt để lắng nghe và xử lý gói tin UDP
            Thread receiveThread = new Thread(new ThreadStart(ReceiveData));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }
        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    IPEndPoint client = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receiveBytes = udpClient.Receive(ref client);
                    string data = Encoding.UTF8.GetString(receiveBytes);

                    // Thêm dữ liệu nhận được vào RichTextBox
                    AppendText(data + Environment.NewLine);
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => AppendText(text)));
                return;
            }

            richTextBox1.AppendText(text);
        }

        private void serverUDP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
