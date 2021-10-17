using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKetqua.Enabled = false;
        }
        private void TaiMenu()
        {
            menuTinhToan.DropDownItems.Add("Tổng");
            menuTinhToan.DropDownItems.Add("Hiệu");
            menuTinhToan.DropDownItems.Add("Tích");
            menuTinhToan.DropDownItems.Add("Thương");
        }

        private void menuTong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtKetqua.Text = a + b + "";
        }

        private void menuHieu_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtKetqua.Text = a - b + "";
        }

        private void menuTich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtKetqua.Text = a * b + "";
        }

        private void menuThuong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
           
            txtKetqua.Text = (float)(a *1.0 / b) + "";
        }

        
        
        
    }
}
