using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = 0;
                if (Int32.TryParse(textBox1.Text, out num1))
                {
                    string[] Ones = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
                    string strWords = "";

                    if (num1 >= -9999 && num1 <= 9999)
                    {
                        if (num1 < 0)
                        {
                            strWords += "Âm ";
                            num1 = Math.Abs(num1);
                        }

                        if ((num1 > 999) && (num1 % 1000 < 100) && (num1 % 1000 > 10))
                        {
                            {
                                int i = num1 / 1000;
                                strWords += Ones[i] + " Ngàn ";
                                strWords += Ones[0] + " Trăm ";
                                num1 %= 1000;
                            }
                        }
                        else if ((num1 > 999) && (num1 % 1000 < 100))
                        {
                            int i = num1 / 1000;
                            strWords += Ones[i] + " Ngàn ";
                            strWords += "Lẻ ";
                            num1 %= 1000;
                        }
                        else if (num1 > 999)
                        {
                            int i = num1 / 1000;
                            strWords += Ones[i] + " Ngàn ";
                            num1 %= 1000;
                        }



                        if ((num1 > 99) && (num1 % 100 < 10))
                        {
                            int i = num1 / 100;
                            strWords += Ones[i] + " Trăm ";
                            strWords += "Lẻ ";
                            num1 %= 100;
                        }
                        else if (num1 > 99)
                        {
                            int i = num1 / 100;
                            strWords += Ones[i] + " Trăm ";
                            num1 %= 100;
                        }


                        if (num1 > 19)
                        {
                            int i = num1 / 10;
                            strWords += Ones[i] + " Mươi ";
                            num1 %= 10;
                        }

                        if (num1 > 0)
                        {
                            strWords += Ones[num1];
                        }
                        else
                        {
                            strWords = Ones[0];
                        }




                        textBox2.Text = strWords;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập lại số nguyên trong khoảng từ -9999 đến 9999.");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số nguyên.");
                    textBox1.Clear();
                    textBox2.Clear();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bai3_Load(object sender, EventArgs e)
        {
      
        }
    }
}
