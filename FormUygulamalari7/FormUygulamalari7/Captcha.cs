using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamalari7
{
    public partial class Captcha : Form
    {
        public Captcha()
        {
            InitializeComponent();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            string[] karakter1 = { "A", "B", "C", "D", "E", "F", "G" };
            string[] karakter2 = { "z", "x", "v", "n", "m", "t", "l" };
            string[] karakter3 = { ".", ",", "!", "*", "/", "+", "-" };
            int x = 0;
            Random rnd = new Random();
            textBox2.ResetText();
            for (int i = 0; i < 8; i++)
            {
                int secim = rnd.Next(3);
                switch (secim)
                {
                    case 0:
                        x = rnd.Next(karakter1.Length);
                        textBox2.Text += karakter1[x];
                        break;
                    case 1:
                        x = rnd.Next(karakter2.Length);
                        textBox2.Text += karakter2[x];
                        break;
                    case 2:
                        x = rnd.Next(karakter3.Length);
                        textBox2.Text += karakter3[x];
                        break;
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] karakter1 = { "A", "B", "C", "D", "E", "F", "G" };
            string[] karakter2 = { "z", "x", "v", "n", "m", "t", "l" };
            string[] karakter3 = { ".", ",", "!", "*", "/", "+", "-" };
            int x = 0;
            Random rnd = new Random();
            textBox2.ResetText();
            for (int i = 0; i < 8; i++)
            {
                int secim = rnd.Next(3);
                switch (secim)
                {
                    case 0:
                        x = rnd.Next(karakter1.Length);
                        textBox2.Text += karakter1[x];
                        break;
                    case 1:
                        x = rnd.Next(karakter2.Length);
                        textBox2.Text += karakter2[x];
                        break;
                    case 2:
                        x = rnd.Next(karakter3.Length);
                        textBox2.Text += karakter3[x];
                        break;
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox1.Text)
            {
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama Başarısız. Tekrar Kod Alıp Deneyin. ", "Başarısız İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "oğuzhan" && textBox4.Text == "bulut" && textBox3.Text == "1234")
            {
                MessageBox.Show("Giriş Başarılı.", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}