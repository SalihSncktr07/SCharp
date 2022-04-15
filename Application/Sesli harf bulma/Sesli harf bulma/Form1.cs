using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesli_harf_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                string a = textBox1.Text.Substring(i, 1).ToString();
                string b = a.ToLower();
                if (a == "a" || a == "e" || a == "ı" || a == "i" || a == "u" || a== "ü" || a == "o" || a == "ö")
                {
                    lblSonuc.Text = lblSonuc.Text + a.ToString();
                }
                else
                {
                    lblSonuc.Text = "LÜTFEN SESSİZ HARF GİRİNİZ!!";
                }
            }
        }
    }
}
