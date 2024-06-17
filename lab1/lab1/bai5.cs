
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            double tongDiem = 0;
            int tongSoMonDau = 0;
            int tongSoMonRot = 0;
            double diemLonNhat = 0;
            double diemNhoNhat = 10;
            int foulNumber = 0;
            int soMonDuoiSauRuoi = 0;
            int soMonDuoiBaRuoi = 0;
            int soMonDuoiHai = 0;
            int count = 1;
            string Input = dsDiem.ToString();
            string[] words = Input.Split(' ');

            foreach (var word in words)
            {
                double valueWord;
                bool check = double.TryParse(word, out valueWord);
                if (check && valueWord > 0 && valueWord <= 10)
                {
                    //MessageBox.Show(valueWord.ToString());
                    tongDiem += valueWord;
                    if (valueWord > diemLonNhat)
                    {
                        diemLonNhat = valueWord;
                    }
                    if (valueWord < diemNhoNhat)
                    {
                        diemNhoNhat = valueWord;
                    }
                    if (valueWord < 5)
                    {
                        tongSoMonRot++;
                    }
                    if (valueWord >= 5)
                    {
                        tongSoMonDau++;
                    }
                    if (valueWord < 6.5)
                    {
                        soMonDuoiSauRuoi++;
                    }
                    if (valueWord < 3.5)
                    {
                        soMonDuoiBaRuoi++;
                    }
                    if (valueWord < 2)
                    {
                        soMonDuoiHai++;
                    }
                }
                else
                {
                    foulNumber++;
                }
            }


            //in ket qua
            if (foulNumber > 2)
            {
                MessageBox.Show("Wrong. Please InPut");
                dsDiem.Text = "";
                diemCaoNhat.Text = "";
                diemThapNhat.Text = "";
                hocLucSinhVien.Text = "";
                bangDiem.Text = "";
                soMonRot.Text = "";
                soMonDau.Text = "";
                diemTB.Text = "";
            }
            else
            {
                int flag = 2;
                foreach (var word in words)
                {
                    if (flag == 0)
                    {
                        string temp = "Mon " + count + ": " + word + "đ";
                        count++;
                        outToLog(temp);
                    }
                    else { flag--; }

                }

                double diemTrungBinh;
                diemTrungBinh = tongDiem / (tongSoMonDau + tongSoMonRot);
                diemTB.Text = diemTrungBinh.ToString();
                diemCaoNhat.Text = diemLonNhat.ToString() + "đ";
                diemThapNhat.Text = diemNhoNhat.ToString() + "đ";
                soMonDau.Text = tongSoMonDau.ToString();
                soMonRot.Text = tongSoMonRot.ToString();
                if (diemTrungBinh >= 8 && soMonDuoiSauRuoi == 0)
                {
                    hocLucSinhVien.Text = "Giỏi";
                }
                else if (diemTrungBinh >= 6.5 && tongSoMonRot == 0)
                {
                    hocLucSinhVien.Text = "Khá";
                }
                else if (diemTrungBinh >= 5 && soMonDuoiBaRuoi == 0)
                {
                    hocLucSinhVien.Text = "Trung Bình";
                }
                else if (diemTrungBinh >= 3.5 && soMonDuoiHai == 0)
                {
                    hocLucSinhVien.Text = "Yếu";
                }
                else
                {
                    hocLucSinhVien.Text = "Kém";
                }

            }
        }
        void outToLog(string output)
        {
            if (!string.IsNullOrWhiteSpace(bangDiem.Text))
            {
                bangDiem.AppendText("\r\n" + output);
            }
            else
            {
                bangDiem.AppendText(output);
            }
            bangDiem.ScrollToCaret();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsDiem.Clear();
            bangDiem.Clear();
            diemCaoNhat.Clear();
            diemThapNhat.Clear();
            hocLucSinhVien.Clear();
            soMonRot.Clear();
            soMonDau.Clear();
            diemTB.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
