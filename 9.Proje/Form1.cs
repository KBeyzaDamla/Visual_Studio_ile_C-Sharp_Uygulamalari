using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rastgeleTamSayi = r.Next(1, 10);
            double rastgeleOndalikliSayi = r.NextDouble();
            double uretilenSayi = rastgeleTamSayi + rastgeleOndalikliSayi;
            textBox1.Text += uretilenSayi.ToString() + "\r\n";
        }
    }
}
