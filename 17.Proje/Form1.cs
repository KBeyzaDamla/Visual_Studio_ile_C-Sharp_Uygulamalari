using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            int uzunluk = textBox1.Text.Length;
            string yeniIfade = "";

            for (int i = 0; i < uzunluk; i++)
            {
                if (Char.IsLower(textBox1.Text[i]) == true)
                    yeniIfade += textBox1.Text[i].ToString().ToUpper();
                else
                    yeniIfade += textBox1.Text[i].ToString().ToLower();
            }

            lYeniIfade.Text = yeniIfade;
        }
    }
}
