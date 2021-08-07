using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc = 0;

                if (comboBox1.Text == "Topla")
                    sonuc = sayi1 + sayi2;
                else if (comboBox1.Text == "Çıkar")
                    sonuc = sayi1 - sayi2;
                else if (comboBox1.Text == "Çarp")
                    sonuc = sayi1 * sayi2;
                else if (comboBox1.Text == "Böl")
                    sonuc = sayi1 / sayi2;

                lSonuc.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                lSonuc.Text = ex.Message;
            }            
        }
    }
}
