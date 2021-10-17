using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTongMang.Enabled = false;
            btnSoLonNhat.Enabled = false;
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
        public string InMang()
        {
            string s = "";
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i] + " ";
            }
            return s;
        }
        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo"); return;
            }
            n = int.Parse(txtNhap.Text);
            if (n < 0)
            {
                MessageBox.Show("Bạn vừa nhập " + n + ". Số phần tử phải lớn hơn 0");
                txtNhap.Focus();
                return;
            }
            TaoMang(n);
            string s = "Mảng có " + n + " phần tử: " + InMang(); 
            MessageBox.Show(s, "Thông báo");
            btnSoLonNhat.Enabled = true;
            btnTongMang.Enabled = true;
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            string s = "Các phần tử trong mảng: " + InMang() +", bạn có muốn tính tổng mảng không";
            DialogResult ret = MessageBox.Show(s, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Form2 frm2 = new Form2(arr);
                frm2.Show();
            }
        }

        private void btnSoLonNhat_Click(object sender, EventArgs e)
        {
            string s = "Các phần tử trong mảng: " + InMang() + ", bạn có muốn tìm giá trị lớn nhất";
            DialogResult ret = MessageBox.Show(s, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Form3 frm2 = new Form3(arr);
                
                frm2.Show();
            }
        }
    }
}
