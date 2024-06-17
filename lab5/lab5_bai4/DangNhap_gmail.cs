using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab5_bai4
{
    public partial class DangNhap_gmail : Form
    {
        string mail, pass;

        public DangNhap_gmail(string User, string Pass)
        {
            mail = User;
            pass = Pass; // Pass should be the App Password
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string mailfrom = "fof.nt208@gmail.com";
            string mailto = tbTo.Text.ToString().Trim();
            string password = "ljzjokxdoluzzwyg"; // Use the App Password here
            string subject = tbSubject.Text.ToString().Trim();
            string body = tbBody.Text.ToString().Trim();

            if (string.IsNullOrEmpty(mailto) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(body))
            {
                MessageBox.Show("Please fill in all fields before sending the email.");
                return;
            }

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mailfrom, password),
                Timeout = 20000,
            };

            using (var message = new MailMessage(mailfrom, mailto))
            {
                message.Subject = subject;
                message.Body = body;

                string[] fileLinks = tbLink.Lines; // Get file paths from tbLink
                foreach (string file in fileLinks)
                {
                    string trimmedFile = file.Trim();
                    if (!string.IsNullOrEmpty(trimmedFile) && File.Exists(trimmedFile))
                    {
                        Attachment attachment = new Attachment(trimmedFile);
                        message.Attachments.Add(attachment);
                    }
                }

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Mail sent successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddLinkToRichTextBox(string link)
        {
            tbLink.AppendText(link);
            tbLink.AppendText(Environment.NewLine);
        }

        private void tbLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "All Files|*.*|Video Files|*.mp4;*.avi;*.mkv|Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            openFileDialog3.Title = "Select a File to Attach";

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                string link = openFileDialog3.FileName;
                AddLinkToRichTextBox(link);
            }
        }
    }
}
