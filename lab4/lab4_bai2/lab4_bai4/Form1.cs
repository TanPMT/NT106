using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Security.Policy;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.IO;
using System.Net;

namespace lab4_bai4
{
    public partial class Form1 : Form
    {
        private const string V = "test.html";
        private String url = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        


        

        private async void btnDowHTML_Click(object sender, EventArgs e)
        {

            string url = textBox1.Text;
            string postData = tbPath.Text;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;

            try
            {
                // Ghi dữ liệu lên request stream
                using (Stream dataStream = await request.GetRequestStreamAsync())
                {
                    await dataStream.WriteAsync(byteArray, 0, byteArray.Length);
                }

                // Lấy response và hiển thị trong RichTextBox
                using (WebResponse response = await request.GetResponseAsync())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            string responseFromServer = await reader.ReadToEndAsync();

                            // Hiển thị kết quả trên giao diện WinForms
                            richTextBox1.Invoke((MethodInvoker)delegate
                            {
                                richTextBox1.Text = responseFromServer;
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
