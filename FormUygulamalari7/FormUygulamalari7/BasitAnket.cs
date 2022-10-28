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
    public partial class BasitAnket : Form
    {
        public BasitAnket()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //radioButton2.Checked = true;
            //radioButton4.Checked = true;
            //radioButton8.Checked = true;
            //checkBox1.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string data = "Ad Soyad: " + textBox1.Text.ToUpper() + " " + textBox2.Text.ToUpper()+"\n";
            foreach (var item in groupBox1.Controls.OfType<RadioButton>())
            {
                if (item.Checked) data += groupBox1.Text + ": " + item.Text + "\n";
            }
            foreach (var item in groupBox2.Controls.OfType<RadioButton>())
            {
                if (item.Checked) data += groupBox2.Text + ": " + item.Text + "\n";
            }
            foreach (var item in groupBox3.Controls.OfType<RadioButton>())
            {
                if (item.Checked) data += groupBox3.Text + ": " + item.Text + "\n";
            }
            foreach (var item in groupBox4.Controls.OfType<CheckBox>())
            {
                if (item.Checked) data += groupBox4.Text + ": " + item.Text + "\n";
            }
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show(data, "Kullanıcı Bilgileri Kaydedilsin mi?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Kullanıcı bilgileri kaydedildi.","Kayıt Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Kullanıcı bilgileri kaydedilmedi.", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
            }
        }
    }
}
