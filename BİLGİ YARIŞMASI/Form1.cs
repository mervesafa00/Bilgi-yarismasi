namespace BİLGİ_YARIŞMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void button5_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            label3.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Hangi saldırı türü , kullanıcıyı sahte bir web sitesine yönlendirerek bilgilerini çalmayı hedefler?";
                button1.Text = "Phising";
                button2.Text = "Ransomware";
                button3.Text = "Brute Force";
                button4.Text = "SQL Injection";
                label7.Text = "Phising";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Siber güvenlikte güçlü bir parolanın önemli bir özelliği nedir?";
                button1.Text = "Kısa ve basit olması";
                button2.Text = "Özel karakterler içermesi";
                button3.Text = "Sadece rakamlardan oluşması";
                button4.Text = "Aynı karakterlerin tekrarlanması";
                label7.Text = "Özel karakterler içermesi";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Zararlı yazılımları tespit etmek için hangi yazılım kullanılır?";
                button1.Text = "Word Processor";
                button2.Text = "Antivirüs";
                button3.Text = "Web Tarayıcı";
                button4.Text = "Grafik Tasarım Programları ";
                label7.Text = "Antivirüs";
                label5.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: "+ yanlis);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button1.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button2.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button3.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label8.Text = button4.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
