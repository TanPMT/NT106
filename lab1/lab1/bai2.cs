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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            try
            {
                if (float.TryParse(textBox1.Text, out num1) && float.TryParse(textBox2.Text, out num2) && float.TryParse(textBox3.Text, out num3))
                {
                    float max = num1, min = num1;

                    if (num2 > max)
                        max = num2;
                    else if (num2 < min)
                        min = num2;

                    if (num3 > max)
                        max = num3;
                    else if (num3 < min)
                        min = num3;

                    textBox4.Text = max.ToString();
                    textBox5.Text = min.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại 3 số thực.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
