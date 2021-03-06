using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai2._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = a * b;
            MessageBox.Show("Dien tich: " + c.ToString());
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            double c = Math.Sqrt(a * a + b * b); 
            MessageBox.Show("Duong cheo " + c.ToString());
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = (a + b) * 2;
            MessageBox.Show("Chu vi: " + c.ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
