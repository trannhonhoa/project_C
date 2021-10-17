using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double f = 0;
            if (x >= 2)
            {
               f = (double)((-8) * Math.Pow(x, 3) -12*x - 1);
            }
            else if(x > 1 && x < 2){
                f = (double)(Math.Pow(x, 2) - 6 * x - 19);
            }
            else if (x <= 1)
            {
                f = 7 * x;
            }
            txtF.Text = f.ToString();
        }

        

        
    }
}
