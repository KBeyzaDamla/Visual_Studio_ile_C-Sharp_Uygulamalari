using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = tbMetin.Text;
            char harf = Char.Parse(tbAranan.Text);
            int sayac = 0;

            foreach (char i in cumle)
            {
                if (checkBox1.Checked == true)
                {
                    if (i == harf)
                        sayac++;
                } else
                {
                    if (Char.ToUpper(i) == Char.ToUpper(harf))
                        sayac++;
                }
            }
            lHarfSayisi.Text = sayac.ToString();
        }
    }
}
