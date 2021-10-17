using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtKetqua.Text = (a + b) + "";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtKetqua.Text = (a - b) + "";
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtKetqua.Text = (a * b) + "";
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (b == 0)
            {
                MessageBox.Show("B phai khac 0");
                return;
            }
            float c = (float)(a * 1.0 / b);
            txtKetqua.Text = c + "";
        }

        
    }
}
