using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbVize_TextChanged(object sender, EventArgs e)
        {
            if (tbVize.Text == "" || tbFinal.Text == "") return;

            double vize = Convert.ToDouble(tbVize.Text);
            double final = Convert.ToDouble(tbFinal.Text);

            double gecmeNotu = (vize * 40 / 100) + (final * 60 / 100);

            lGecmeNotu.Text = gecmeNotu.ToString();
        }
    }
}
