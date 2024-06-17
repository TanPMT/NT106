using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 bt1 = new bai1();
            bt1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 bt2 = new bai2();
            bt2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bai3 bt3 = new bai3();
            bt3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            bai4 bt4 = new bai4();
            bt4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bai5 bt5 = new bai5();
            bt5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
