using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = Convert.ToInt32(textBox3.Text);

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                MessageBox.Show("En büyük sayı: " + sayi1);
            } 
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                MessageBox.Show("En büyük sayı: " + sayi2);
            }
            else
            {
                MessageBox.Show("En büyük sayı: " + sayi3);
            }
        }
    }
}
