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
    public partial class HesapMakinesi : Form
    {
        double sayi1;
        string islem;
        public HesapMakinesi()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            islem = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            islem = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            islem = "*";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            islem = "/";

        }

        private void button23_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            islem = "%";

        }

        private void button22_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            islem = "√";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString((1 / sayi1));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            if (sayi1 > 0)
            {
                textBox1.Text = Convert.ToString((-sayi1));
            }
            else if (sayi1 < 0)
            {
                textBox1.Text = Convert.ToString((+sayi1));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int uzunluk = textBox1.Text.Length;
            if (uzunluk > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double sayi2;
            double sonuc;
            sayi2 = Convert.ToDouble(textBox1.Text);

            if (islem == "+")
            {
                sonuc = (sayi1 + sayi2);
                textBox1.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "-")
            {
                sonuc = (sayi1 - sayi2);
                textBox1.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "*")
            {
                sonuc = (sayi1 * sayi2);
                textBox1.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "/")
            {
                sonuc = (sayi1 / sayi2);
                textBox1.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "√")
            {
                sonuc = (Math.Sqrt(sayi1));
                textBox1.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "%")
            {
                sonuc = (sayi1 * sayi2) / 100;
                textBox1.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "x^x")
            {
                sonuc = Math.Pow(sayi1, sayi2);
                textBox1.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
            if (islem == "Mod")
            {
                sonuc = (sayi1 % sayi2);
                textBox1.Text = Convert.ToString(sonuc);
                sayi1 = sonuc;
            }
        }
        bool durum = true;
        private void button24_Click(object sender, EventArgs e)
        {
            if (durum == true)
            {
                panel2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

                durum = false;
            }
            else
            {
                label4.Visible = false;
                panel2.Visible = false;
                label3.Visible = false;
                durum = true;
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sin((sayi1 * Math.PI) / 180));
        }

        private void button26_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Cos((sayi1 * Math.PI) / 180));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Log(sayi1));
        }

        private void button29_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Pow(sayi1, 2));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;

            islem = "x^x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;

            islem = "Mod";
        }
    }
}
