using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormUygulamalari7
{
    public partial class ListViewCRUD : Form
    {
        public ListViewCRUD()
        {
            InitializeComponent();
            comboBox2.Items.Add("İlkokul");
            comboBox2.Items.Add("Ortaokul");
            comboBox2.Items.Add("Lise");
            comboBox2.Items.Add("Üniversite");
        }

        private void ListViewCRUD_Load(object sender, EventArgs e)
        {
            Toplam();
            listView1.Columns.Add("TC Kimlik No", 160);
            listView1.Columns.Add("Ad Soyad", 100);
            listView1.Columns.Add("Yaş", 100);
            listView1.Columns.Add("Telefon", 100);
            listView1.Columns.Add("Şehir", 100);
            listView1.Columns.Add("Eğitim", 100);
            listView1.Columns.Add("Cinsiyet", 100);
        }
        private void button6_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            groupBox1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox2.ResetText();
            textBox3.ResetText();
            comboBox1.Text = null;
            comboBox2.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tc = "", adsoyad = "", yas = "", telefon = "", sehir = "", egitim = "", cinsiyet = "";
            tc = maskedTextBox2.Text;
            adsoyad = textBox2.Text;
            yas = textBox3.Text;
            telefon = maskedTextBox1.Text;
            sehir = comboBox1.Text;
            egitim = comboBox2.Text;
            cinsiyet = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;
            bool kayitdurum = true;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (tc == listView1.Items[i].SubItems[0].Text)
                {
                    kayitdurum = false;
                    MessageBox.Show("Kullanıcı zaten kayıtlıdır.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string[] veriler = { tc, adsoyad, yas, telefon, sehir, egitim, cinsiyet };
            if (kayitdurum == true)
            {
                if (tc != "" && adsoyad != "" && yas != "" && telefon != "")
                {
                    DialogResult secenek = MessageBox.Show("Kullanıcı eklensin mi", "Kayıt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (secenek == DialogResult.OK)
                    {
                        ListViewItem kullanicibilgileri = new ListViewItem(veriler);
                        listView1.Items.Add(kullanicibilgileri);
                        Toplam();
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Gerekli Tüm Alanları Doldurunuz.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void Toplam()
        {
            int toplam = listView1.Items.Count;
            label8.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Tüm ögeler silinsin mi", "Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (secenek == DialogResult.OK)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items.Clear();
                    Toplam();
                }
            }
            else { }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Seçilen ögeler silinsin mi", "Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (secenek == DialogResult.OK)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Remove();
                    Toplam();
                }
            }
            else { }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Check edilen ögeler silinsin mi", "Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (secenek == DialogResult.OK)
            {
                foreach (ListViewItem item in listView1.CheckedItems)
                {

                    item.Remove();
                    Toplam();
                }
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool aranankayit = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == maskedTextBox2.Text)
                {
                    aranankayit = true;
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    textBox3.Text = listView1.Items[i].SubItems[2].Text;
                    maskedTextBox1.Text = listView1.Items[i].SubItems[3].Text;
                    comboBox1.Text = listView1.Items[i].SubItems[4].Text;
                    comboBox2.Text = listView1.Items[i].SubItems[5].Text;
                    if (listView1.Items[i].SubItems[6].Text == "Kadın")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    maskedTextBox1.Enabled = false;
                    maskedTextBox2.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    groupBox1.Enabled = false;
                }
            }
            if (aranankayit == false)
            {
                MessageBox.Show("Aranan Tc numarasına göre kayıtlı kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}