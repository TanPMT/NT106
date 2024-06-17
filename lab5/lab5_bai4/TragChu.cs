using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_bai4
{
    public partial class TragChu : Form
    {
        string User;
        string Pass;
        
        public TragChu(string user, string pass)
        {
            this.User = user;
            this.Pass = pass;
            
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            GuiTin guiTin = new GuiTin(User, Pass);
            guiTin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DuyetMail duyetMail = new DuyetMail(User, Pass);
            duyetMail.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangNhap_gmail dangNhap_Gmail = new DangNhap_gmail(User, Pass);
            dangNhap_Gmail.Show();
        }
    }
}
