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
    public partial class DijitalSaat : Form
    {
        public int salise, saniye, dakika, saat;
        bool durum = true;
        public DijitalSaat()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;

            if (saniye == 60 && dakika == 59 && saat == 23)
            {
                saniye = 0;
                dakika = 0;
                dakika++;
            }
            if (salise == 60)
            {
                saniye++;
                salise = 0;
            }
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            if (dakika == 60)
            {
                saat++;
                dakika = 0;
            }
            label1.Text = saat.ToString();
            label9.Text = dakika.ToString();
            label3.Text = saniye.ToString();
            label2.Text = salise.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (durum == true)
            {
                timer1.Start();
                durum = false;
            }
            else
            {
                timer1.Stop();
                durum = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Saat= " + label1.Text + " Dakika= " + label9.Text + " Saniye= " + label3.Text + " Salise= " + label2.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = 0.ToString();
            label9.Text = 0.ToString();
            label3.Text = 0.ToString();
            label2.Text = 0.ToString();
            saat = 0;
            dakika = 0;
            saniye = 0;
            salise = 0;
        }

    }
}
