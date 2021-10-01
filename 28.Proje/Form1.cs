using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox1.Text);
            int bolen = 2;

            while (sayi != 1)
            {
                if (sayi % bolen == 0)
                {
                    sayi = sayi/bolen;
                    listBox1.Items.Add(bolen);
                    bolen = bolen - 1;
                }

                bolen = bolen + 1;
            }
        }
    }
}
