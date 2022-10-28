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
    public partial class BlogAnasayfa : Form
    {
        public BlogAnasayfa()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msj;
            msj = MessageBox.Show("Program kapatılsın mı ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msj == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser form2 = new WebBrowser();
            form2.ShowDialog();
        }

        private void processBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressBar form3 = new ProgressBar();
            form3.ShowDialog();
        }

        private void dijitalSaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DijitalSaat form4 = new DijitalSaat();
            form4.ShowDialog();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapMakinesi form5 = new HesapMakinesi();
            form5.ShowDialog();
        }

        private void dersSeçimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersSecim form6 = new DersSecim();
            form6.ShowDialog();
        }

        private void basitAnketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasitAnket form7 = new BasitAnket();
            form7.ShowDialog();
        }

        private void ekranKlavyesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkranKlavyesi form8 = new EkranKlavyesi();
            form8.ShowDialog();
        }

        private void dinamikAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DinamikAraclar form9 = new DinamikAraclar();
            form9.ShowDialog();
        }

        private void caphtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Captcha form10 = new Captcha();
            form10.ShowDialog();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void crudÖrneğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewCRUD form10 = new ListViewCRUD();
            form10.ShowDialog();
        }

        private void örnek1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView form11 = new DataGridView();
            form11.ShowDialog();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profil form12 = new Profil();
            form12.ShowDialog();
        }
    }
}
