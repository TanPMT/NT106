
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhMang_Lab2
{
    public partial class lab2_bai4 : Form
    {
        public lab2_bai4()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            string outputFilePath = "..\\Debug\\New folder\\output.txt";
            string inputFilePath = "..\\Debug\\New folder\\input.txt";
            try
                {
                    using (FileStream fs = File.OpenRead(inputFilePath))
                    {

                    using (StreamWriter sw = new StreamWriter(outputFilePath)) 
                        {
                            BinaryFormatter bf = new BinaryFormatter();
                            string output = (string)bf.Deserialize(fs);
                            string[] part = output.Split('\n');
                            
                            double sum = 0;
                            double i = 0;
                        string result = "";
                        foreach (string line in part)
                        {
                            double num;
                            if (double.TryParse(line, out num))
                            {
                                if (num >= 0 && num <= 10)
                                {
                                    sum += num;
                                    i++;

                                }
                                if (i == 2)
                                {
                                    double average = sum / i;
                                    result = output + '\n' + '\n' + average.ToString() + '\n';
                                    i = 0;
                                    sum = 0;
                                    sw.WriteLine(result);

                                }


                            }
                            /*
                          foreach (string line in part)
                          {
                              double num;
                              if (double.TryParse(line, out num))
                              {
                                  if (num >= 0 && num <= 10)
                                  {
                                      sum += num;
                                      i++;

                                  }
                                  else if (i == 5)
                                  {
                                      break;
                                  }

                              }
                          }

                          double average = sum / i;
                          string result = output + '\n' + '\n' + average.ToString() + '\n';
                          sw.WriteLine(result);

                      }
                     */
                        }

                    }

                }


            }
                
                catch (Exception)
                {

                    throw;
                }
            

        }

        private void btn_write_Click(object sender, EventArgs e)
        {
           
            
                try
                {
                    // Mở tệp tin đã chọn để ghi dữ liệu
                    using (FileStream fileStream = File.Create("..\\Debug\\New folder\\input.txt"))
                    {
                        // Tạo một BinaryFormatter để serialize dữ liệu
                        BinaryFormatter binaryFormatter = new BinaryFormatter();

                        // Lấy dữ liệu từ textBox1.Text
                        string st = textBox1.Text;

                        // Serialize dữ liệu và ghi vào tệp tin
                        binaryFormatter.Serialize(fileStream, st);
                    }

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
                }
                
            
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string contents = sr.ReadToEnd();
            textBox1.Text = contents;
            fs.Close();
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
