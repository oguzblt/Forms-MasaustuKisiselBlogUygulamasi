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
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "AD";
            dataGridView2.Columns[2].Name = "SOYAD";
            dataGridView2.Columns[3].Name = "TELEFON";
            dataGridView2.Columns[4].Name = "SEHİR";

            dataGridView2.Rows.Add("1", "Oğuzhan", "Bulut", "05465305385", "İstanbul");
            dataGridView2.ClearSelection();
            dataGridView2.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(Convert.ToInt32(numericUpDown1.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dataGridView2.DefaultCellStyle.Font = new Font("Calibri", 10);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
    }
}
