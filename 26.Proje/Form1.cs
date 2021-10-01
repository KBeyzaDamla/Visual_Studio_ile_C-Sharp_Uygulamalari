using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26.Proje
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

            for (int i = baslangic; i <= bitis; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    lSayilar.Text += i.ToString();
                }

                lSayilar.Text += "\n";
            }
        }
    }
}
