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

namespace UDP
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();
                //Lấy địa chỉ IP từ textbox và chuyển thành kiểu IPAddress
                IPAddress ipadd = IPAddress.Parse(IPaddress.Text);
                int port = Convert.ToInt32(Port.Text);
                IPEndPoint ipend = new IPEndPoint(ipadd, port);
                button1.Enabled = true;
                //Chuyển chuỗi dữ liệu nhập sang kiểu byte
                byte[] sendBytes = Encoding.UTF8.GetBytes(IPaddress.Text + ' ' + richTextBox1.Text);
                //Gởi dữ liệu đến IPEndPoint đã định nghĩa địa chỉ IP và Port
                udpClient.Send(sendBytes, sendBytes.Length,ipend);
                //Xóa dữ liệu vừa gửi ở ô nhập
                richTextBox1.Text = "";
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Please type the server IP and port", "Warning");
                IPaddress.Clear();
                Port.Clear();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
