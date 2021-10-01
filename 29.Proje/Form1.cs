using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cumle = textBox1.Text.Split(' ');
            int uzunluk = cumle[0].Length;
            int uzunKelimeIndisi = 0;
            
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i].Length > uzunluk)
                {
                    uzunluk = cumle[i].Length;
                    uzunKelimeIndisi = i;
                }
            }

            lKelime.Text = cumle[uzunKelimeIndisi];
        }
    }
}
