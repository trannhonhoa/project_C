using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr;
        int n;
        private void TaoMang(int n)
        {
            arr = new int[n];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(-10, 100);
            }
        }
        private string InMang()
        {
            string s = "";
            foreach (int x in arr)
            {
                s += x + " ";
            }
            return s;
        }
        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập phần tử mảng", "Thông báo"); txtNhap.Focus();
                return;
            }
            n = int.Parse(txtNhap.Text);
            if(n < 0){
                string thongbao = "Bạn vừa nhập " + n  + ". Số phần tử trong mảng phải > 0";
                txtNhap.Focus();
                MessageBox.Show(thongbao, "Thông báo"); return;
            }
            TaoMang(n);
            btnInMang.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnInMang.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInMang_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = InMang().ToString();
        }
    }
}
