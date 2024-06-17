namespace lab1
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum;
            if (Int32.TryParse(textBox1.Text, out num1) && Int32.TryParse(textBox2.Text, out num2))
            {
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào ô văn bản.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
