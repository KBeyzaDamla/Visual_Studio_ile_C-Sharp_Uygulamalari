using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30.Proje
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
                double not = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                if (not >= 84)
                    lHarfNotu.Text = "AA";
                else if (not < 84 && not >= 77)
                    lHarfNotu.Text = "AB";
                else if (not < 77 && not >= 72)
                    lHarfNotu.Text = "BA";
                else if (not < 72 && not >= 66)
                    lHarfNotu.Text = "BB";
                else if (not < 66 && not >= 61)
                    lHarfNotu.Text = "BC";
                else if (not < 61 && not >= 56)
                    lHarfNotu.Text = "CB";
                else if (not < 56 && not >= 50)
                    lHarfNotu.Text = "CC";
                else if (not < 50 && not >= 46)
                    lHarfNotu.Text = "CD";
                else if (not < 46 && not >= 40)
                    lHarfNotu.Text = "DC";
                else if (not < 40 && not >= 33)
                    lHarfNotu.Text = "DD";
                else if (not < 33 && not >= 0)
                    lHarfNotu.Text = "FF";
            }
            catch (Exception ex)
            {
                lHarfNotu.Text = ex.Message;
            }
        }
    }
}
