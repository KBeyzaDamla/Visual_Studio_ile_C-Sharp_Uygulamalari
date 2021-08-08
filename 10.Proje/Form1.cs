using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void btnRastgeleSec_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rastgeleTamSayi = r.Next(1, listBox1.Items.Count);
            string kisi = listBox1.Items[rastgeleTamSayi - 1].ToString();
            MessageBox.Show(kisi);
        }
    }
}
