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
    public partial class DersSecim : Form
    {
        public DersSecim()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = textBox4.Text + ", " + "Öğrenci numarası: " + textBox1.Text + ", " + "Bölüm: " + textBox2.Text + ", " + "Sınıf: " + textBox3.Text;
            label5.Text = textBox4.Text;
            panel1.Visible = true;
            panel4.Visible = true;
            label10.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items.Remove(listBox1.Items[i]);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox2.Items.Add(checkedListBox1.CheckedItems[i]);
            }
            label16.Text = listBox2.Items.Count.ToString();
            label17.Text = "Bekleniyor...";
        }
    }
}
