using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr;
        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            arr = new int[10];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(100);
            }
            HienThiLenTextBox(arr, txtMangGoc);
        }

        private void HienThiLenTextBox(int[] arr, TextBox txt)
        {
            txt.Text = "";
            foreach (int x in arr)
            {
                txt.Text += x + " ";    
            }
        }

        private void btnTongGiaTri_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            txtKetQua.Text = "Tổng mảng = " + sum;
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in arr)
            {
                if (x % 2 != 0) dem++;
            }
            txtKetQua.Text = "Số phần tử lẻ = " + dem;
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int x in arr)
            {
                if (x % 2 != 0) sum+=x;
            }
            txtKetQua.Text = "Số phần tử lẻ = " + sum;
        }

        private void btnNhoNhat_Click(object sender, EventArgs e)
        {
            int min = arr[0];
            foreach (int x in arr)
            {
                if (min > x) min = x;
            }
            txtKetQua.Text = "Số phần nhỏ nhất = " + min;
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 2;
            }
                HienThiLenTextBox(arr, txtKetQua);
        }

        private void btnTangDan_Click(object sender, EventArgs e)
        {
            Array.Sort(arr, 0 ,arr.Length);
            HienThiLenTextBox(arr, txtKetQua);
        }

        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            Array.Sort(arr, 0, arr.Length);
            Array.Reverse(arr, 0, arr.Length);
            HienThiLenTextBox(arr, txtKetQua);
        }
        
    }
}
