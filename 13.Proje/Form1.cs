using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] satirlar = richTextBox1.Text.Split('\n');
            int[] sayilar = new int[satirlar.Length];

            for (int i = 0; i < satirlar.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(satirlar[i]);
            }

            Array.Sort(sayilar);
            richTextBox1.Text = "";

            foreach (int sayi in sayilar)
            {
                richTextBox1.Text += sayi.ToString() + "\r\n";
            }
        }
    }
}
