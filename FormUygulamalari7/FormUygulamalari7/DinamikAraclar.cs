using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamalari7
{
    public partial class DinamikAraclar : Form
    {
        public DinamikAraclar()
        {
            InitializeComponent();
        }
        Label label = new Label();
        Label label1 = new Label();
        Button button = new Button();
        TextBox textbox = new TextBox();
        GroupBox groupBox = new GroupBox();
        Button button1 = new Button();
        Panel panel = new Panel();
        ListBox listBox = new ListBox();
        public void Form9_Load(object sender, EventArgs e)
        {
            
            button.Name = "btn1";
            button.Text = "Ekle";
            button.Size = new Size(60, 40);
            button.Location = new Point(160,170);
            button.BackColor = Color.LightYellow;
            button.ForeColor = Color.Black;
            button.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            button.TabIndex = 1;
            button.FlatStyle = FlatStyle.Popup;
            button.Click += new EventHandler(btn1);
            this.Controls.Add(button); 
            label.Name = "lbl1";
            label.Text = "Girilen Yazıyı ListBox'a Ekleme (Dinamik Araç)"; 
            label.Size = new Size(350, 30);
            label.Location = new Point(20, 20);
            label.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            label.ForeColor = Color.Black;
            label.BackColor = Color.DarkOrange;
            label.AutoSize = false;
            this.Controls.Add(label);
            label1.Name = "lbl2";
            label1.Text = "↓ Girilecek Kelimeyi Giriniz ↓";
            label1.Size = new Size(175, 20);
            label1.Location = new Point(105, 75);
            label1.Font = new Font("Times New Roman", 10);
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.DarkOrange;
            label1.AutoSize = false;
            this.Controls.Add(label1);
            textbox.Name = "txt1";
            textbox.Text = "";
            textbox.Location = new Point(140, 100);
            textbox.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            textbox.ForeColor = Color.Black;
            textbox.BackColor = Color.DarkOrange;
            this.Controls.Add(textbox);    
            groupBox.Name = "grp1";
            groupBox.Text = "Araçlar";
            groupBox.Size = new Size(250,180);
            groupBox.Location = new Point(70, 225);
            groupBox.BackColor = Color.DarkOrange;
            this.Controls.Add(groupBox);
            listBox.Name = "lst1";
            listBox.Text = "Kelimeler";
            listBox.Size = new Size(150, 100);
            listBox.Location = new Point(40, 40);
            groupBox.Controls.Add(listBox);  
            panel.Name = "pnl1";
            panel.Size = new Size(400, 450);
            panel.BackColor = Color.Bisque;
            panel.SendToBack();
            this.Controls.Add(panel);
        }
        public void btn1(object sender, EventArgs e)
        {
            listBox.Items.Add(textbox.Text);
            textbox.ResetText();
        }
    }
}
