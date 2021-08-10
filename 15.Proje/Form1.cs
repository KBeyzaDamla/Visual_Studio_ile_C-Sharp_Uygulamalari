using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilkBoslukKarakteri = textBox1.Text.IndexOf(' ');
            int sonBoslukKarakteri = textBox1.Text.LastIndexOf(' ');
            string ilkKelime = textBox1.Text.Substring(0, ilkBoslukKarakteri);
            string sonKelime = textBox1.Text.Substring(sonBoslukKarakteri, textBox1.Text.Length - sonBoslukKarakteri);

            label2.Text = "İlk Boşluk Karakteri = " + ilkBoslukKarakteri.ToString() +
                "\r\nSon Boşluk Karakteri = " + sonBoslukKarakteri.ToString() +
                "\r\nİlk Kelime = " + ilkKelime +
                "\r\nSon Kelime = " + sonKelime;
        }
    }
}
