using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tekÇiftDeğerleriBelirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int aktifSayi = Convert.ToInt32(listBox1.Items[i]);

                if (aktifSayi % 2 == 0)
                    listBox1.Items[i] = listBox1.Items[i].ToString() + " (Çift Sayı)";
                else
                    listBox1.Items[i] = listBox1.Items[i].ToString() + " (Tek Sayı)";
            }
        }

        private void listBoxİçerisineEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
