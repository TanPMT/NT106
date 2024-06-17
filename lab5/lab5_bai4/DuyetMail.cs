using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using MailKit.Search;
namespace lab5_bai4
{
    public partial class DuyetMail : Form
    {
        string User, Pass;
        public DuyetMail(string user, string pass)
        {
            User = user;
            Pass = pass;
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            LoadEmails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadEmails()
        {
            try
            {
                using (var client = new ImapClient())
                {
                    string email = User;
                    string password = Pass;
                    
                    // Disable SSL certificate validation (not recommended for production)
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    // Connect to the IMAP server
                    client.Connect("127.0.0.1", 993, true);

                    // Authenticate with the server
                    client.Authenticate(email, password);

                    // Open the INBOX folder
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    // Clear previous items
                    listView1.Items.Clear();
                    label3.Text = label3.Text + inbox.Count.ToString();
                    var recentTimeSpan = TimeSpan.FromDays(1);
                    var recentDate = DateTime.Now - recentTimeSpan;

                    // Search for emails sent in the last 'recentTimeSpan' days
                    var query = SearchQuery.DeliveredAfter(recentDate);
                    var recentMessages = inbox.Search(query);
                    label5.Text = label5.Text + recentMessages.Count.ToString();
                    // Add columns if not added already
                    if (listView1.Columns.Count == 0)
                    {
                        listView1.Columns.Add("Email", 200);
                        listView1.Columns.Add("From", 200);
                        listView1.Columns.Add("Thời gian", 200);
                        listView1.View = View.Details;
                    }

                    // Fetch and display emails
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem item = new ListViewItem(message.Subject);

                        ListViewItem.ListViewSubItem fromSubItem = new ListViewItem.ListViewSubItem(item, message.From.ToString());
                        item.SubItems.Add(fromSubItem);

                        ListViewItem.ListViewSubItem dateSubItem = new ListViewItem.ListViewSubItem(item, message.Date.ToString("dd/MM/yyyy HH:mm:ss"));
                        item.SubItems.Add(dateSubItem);

                        listView1.Items.Add(item);
                    }

                    // Disconnect from the server
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading emails: " + ex.Message);
            }
        }
    }
}
