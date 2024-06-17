using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Html;
using Aspose.Html.Rendering;

namespace lab4_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBox1.Text; // Đặt URL của trang web bạn muốn hiển thị ở đây
                string htmlContent = getHTML(url);
                ShowHTML(htmlContent);
            }
            catch(Exception ex)
            {
               
            }

        }
        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }
        private void ShowHTML(string htmlContent)
        {
            try
            {
                richTextBox1.Text = htmlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
