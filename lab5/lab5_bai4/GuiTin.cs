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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab5_bai4
{
    public partial class GuiTin : Form
    {
        string User, Pass;
        public GuiTin(string user, string pass)
        {
            User = user;
            Pass = pass;
            InitializeComponent();
        }
        private void AddLinkToRichTextBox(string link)
        {
            tbLink.AppendText(link);
            tbLink.AppendText(Environment.NewLine);
        }
        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "All Files|*.*|Video Files|*.mp4;*.avi;*.mkv|Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            openFileDialog3.Title = "Select a File to Attach";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                //tbLink.Text = openFileDialog3.FileName;
                string link = openFileDialog3.FileName;
                AddLinkToRichTextBox(link);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = User;
                string mailto = tbTo.Text.ToString().Trim();
                string password = Pass;
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = tbSubject.Text.ToString().Trim();
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = tbBody.Text.ToString();
                    message.To.Add(mailto);

                    // Add attachments
                    string[] fileLinks = tbLink.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    foreach (string fileLink in fileLinks)
                    {
                        if (!string.IsNullOrWhiteSpace(fileLink))
                        {
                            Attachment attachment = new Attachment(fileLink);
                            message.Attachments.Add(attachment);
                        }
                    }

                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                tbBody.Clear();
                tbSubject.Clear();
                tbLink.Clear(); // Clear the attachments textbox as well
            }
        }
    }
}
