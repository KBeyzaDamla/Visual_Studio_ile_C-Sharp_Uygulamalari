using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(tbBaslangic.Text);
            int bitis = Convert.ToInt32(tbBitis.Text);
            int artisMiktari = Convert.ToInt32(tbArtisMiktari.Text);

            if (bitis > baslangic)
            {
                for (int i = baslangic; i <= bitis; i = i + artisMiktari)
                    tbDegerler.Text += i.ToString() + ", ";
            } else
            {
                for (int i = baslangic; i >= bitis; i = i + artisMiktari)
                    tbDegerler.Text += i.ToString() + ", ";
            }
        }
    }
}
