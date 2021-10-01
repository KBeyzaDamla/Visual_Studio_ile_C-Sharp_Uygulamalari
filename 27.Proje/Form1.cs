using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uretilecekSayiAdedi = Convert.ToInt32(tbUretilecekSayiAdedi.Text);
            int baslangic = Convert.ToInt32(tbBaslangic.Text);
            int bitis = Convert.ToInt32(tbBitis.Text);
            ArrayList list = new ArrayList();
            Random r = new Random();

            while (true)
            {
                uretilecekSayiAdedi--;
                int sayi = r.Next(baslangic, bitis);

                if (list.IndexOf(sayi) != -1)
                {
                    continue;
                }
                else
                {
                    list.Add(sayi);
                    listBox1.Items.Add(sayi.ToString());
                }

                if (uretilecekSayiAdedi == 0) break;
            }
        }
    }
}
