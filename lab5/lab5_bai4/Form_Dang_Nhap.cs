using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using MailKit.Search;
using System.Text.RegularExpressions;
namespace lab5_bai4
{
    public partial class Form_Dang_Nhap : Form
    {
        public Form_Dang_Nhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBox1.Text;
            string matKhau = textBox2.Text;
            if (IsGmailAccount(taiKhoan))
            {
                load_gmail(taiKhoan, matKhau);  
            }
            else
            {
                load_form(taiKhoan, matKhau);
            }
            
            //

        }
        static bool IsGmailAccount(string taiKhoan)
        {
            // Regular expression to match a Gmail address
            string gmailRegex = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(taiKhoan, gmailRegex);
        }
        
        void load_gmail(string taiKhoan, string matKhau)
        {
            DangNhap_gmail dangNhap_Gmail = new DangNhap_gmail(taiKhoan, matKhau);
            dangNhap_Gmail.Show();
        }

        void load_form(string taiKhoan, string matKhau)
        {
            try
            {
                using (var client = new ImapClient())
                {
                    string email = taiKhoan;
                    string password = matKhau;

                    // Disable SSL certificate validation (not recommended for production)
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    // Connect to the IMAP server
                    client.Connect("127.0.0.1", 993, true);

                    // Authenticate with the server
                    client.Authenticate(email, password);
                    TragChu tragChu = new TragChu(taiKhoan, matKhau);
                    tragChu.Show();
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác: " + ex.Message);
            }
        }
    }
}
