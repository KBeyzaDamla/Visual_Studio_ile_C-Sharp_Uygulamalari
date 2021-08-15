using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(sayi);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double ortalama = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam += Convert.ToInt32(listBox1.Items[i]);
            }

            ortalama = toplam / listBox1.Items.Count;
            lToplam.Text = toplam.ToString();
            lOrtalama.Text = ortalama.ToString();
        }
    }
}
