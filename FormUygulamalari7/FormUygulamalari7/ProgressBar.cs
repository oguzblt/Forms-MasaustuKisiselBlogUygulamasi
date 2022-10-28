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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            pictureBox3.Location = new Point(pictureBox3.Location.X + 20, 107);
            if (progressBar1.Value == 10)
            {
                textBox1.Text = "Beykoz";
                textBox2.Text = "Üsküdar'a hareket ediliyor. ->";
            }
            if (progressBar1.Value == 30)
            {
                textBox1.Text = "Üsküdar";
                textBox2.Text = "Kadıköy'e hareket ediliyor. ->";
            }
            if (progressBar1.Value == 40)
            {
                textBox1.Text = "Kadıköy";
                textBox2.Text = "Ümraniye'ye hareket ediliyor. ->";
            }
            if (progressBar1.Value == 60)
            {
                textBox1.Text = "Ümraniye";
                textBox2.Text = "Ataşehir'e hareket ediliyor. ->";
            }
            if (progressBar1.Value == 70)
            {
                textBox1.Text = "Ataşehir";
                textBox2.Text = "Kartal'a hareket ediliyor. ->";

            }
            if (progressBar1.Value == 90)
            {
                textBox1.Text = "Kartal";
                textBox2.Text = "Pendik'e hareket ediliyor. ->";

            }
            if (progressBar1.Value == 100)
            {
                textBox1.Text = "Pendik";
                textBox2.Text = "Son Durak.. :)";
                timer1.Stop();
            }
            
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1500;
        }
    }
}
