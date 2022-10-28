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
    public partial class EkranKlavyesi : Form
    {
        public EkranKlavyesi()
        {
            InitializeComponent();
        }
        bool cldurum = true;
        bool altdurum = true;
        bool shiftdurum = true;

        private void HarflerOrtak(object sender, EventArgs e)
        {
            Button harfler = (Button)sender;
            if (harfler.Text == "<-- Backspace")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
            else if (harfler.Text == "Clear")
            {
                label1.Text = String.Empty;
            }
            else if (harfler.Text == "Space")
            {
                label1.Text += " ";
            }
            else if (harfler.Text == "Enter")
            {
                label1.Text += "\n";
            }
            else if (harfler.Text == "Tab")
            {
                label1.Text += "\t";
            }
            else if (harfler.Text == "Alt Gr")
            {
                if (altdurum)
                {
                    altdurum = false;
                    button39.BackColor = Color.DarkGray;
                    button40.Text = "/";
                    btn0.Text = "}";
                    btn1.Text = "<";
                    btn2.Text = "£";
                    btn3.Text = "#";
                    btn4.Text = "$";
                    btn5.Text = "½";
                    btn6.Text = ">";
                    btn7.Text = "{";
                    btn8.Text = "[";
                    btn9.Text = "]";
                }
                else
                {
                    altdurum = true;
                    button39.BackColor = Color.Black;
                    button40.Text = "?";
                    btn0.Text = "0";
                    btn1.Text = "1";
                    btn2.Text = "2";
                    btn3.Text = "3";
                    btn4.Text = "4";
                    btn5.Text = "5";
                    btn6.Text = "6";
                    btn7.Text = "7";
                    btn8.Text = "8";
                    btn9.Text = "9";
                }
            }
            else if (harfler.Text == "Shift")
            {
                if (shiftdurum)
                {
                    shiftdurum = false;
                    button38.BackColor = Color.DarkGray;
                    button44.BackColor = Color.DarkGray;
                    button40.Text = "*";
                    btn0.Text = "=";
                    btn1.Text = "!";
                    btn2.Text = "'";
                    btn3.Text = "^^";
                    btn4.Text = "-";
                    btn5.Text = "%";
                    btn6.Text = "&";
                    btn7.Text = "/";
                    btn8.Text = "(";
                    btn9.Text = ")";
                    button42.Text = "é";
                    button43.Text = ":";
                }
                else
                {
                    shiftdurum = true;
                    button38.BackColor = Color.Black; 
                    button44.BackColor = Color.Black;
                    button40.Text = "?";
                    btn0.Text = "0";
                    btn1.Text = "1";
                    btn2.Text = "2";
                    btn3.Text = "3";
                    btn4.Text = "4";
                    btn5.Text = "5";
                    btn6.Text = "6";
                    btn7.Text = "7";
                    btn8.Text = "8";
                    btn9.Text = "9";
                    button42.Text = Convert.ToString('"');
                    button43.Text = ".";
                }
            }
            else if (harfler.Text == "Home")
            {
                this.Close();
            }
            else if (harfler.Text == "Caps Lock")
            {
                if (cldurum) cldurum = false;
                else cldurum = true;
            }
            else
            {
                if (cldurum) label1.Text += harfler.Text.ToLower();
                else label1.Text += harfler.Text.ToUpper();
            }
        }

        private void Form8_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text += Convert.ToString(e.KeyChar);
        }
    }
}
