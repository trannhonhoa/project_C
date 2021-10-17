using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(textC.Text);

            float delta = (float)(b * b - 4 * a * c);

            if (delta > 0)
            {
                
                float x1 = (float) ((-b - Math.Sqrt(delta)) / 2 * a);
                float x2 = (float)((-b + Math.Sqrt(delta)) / 2 * a);
                txtKetqua.Text = "PT co 2 nghiem x1 = " + x1 + "x2 = " + x2;

            }
            else if (delta == 0)
            {
               int x1 = -b / 2 * a;
               txtKetqua.Text = "PT co nghiem kep x = " + x1;
            }
            else if (delta < 0)
            {
                txtKetqua.Text = "Phuong trinh vo nghiem";
            }
            
        }

        
    }
}
