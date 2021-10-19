using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr = new int[10];
        int sopt = 0;
        private string InMang()
        {
            string chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                chuoi += arr[i] + " ";
            }
            return chuoi;
        }
        private int TimMax()
        {
            int max = arr[0];
            for (int i = 1; i < sopt; i++)
            {
                if (max < arr[i]) { max = arr[i]; }
            }
            return max;
        }
        private int TimMin()
        {
            int min = arr[0];
            for (int i = 1; i < sopt; i++)
            {
                if (min > arr[i]) { min = arr[i]; }
            }
            return min;
        }
        private float TrungBinhMang()
        {
            float sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                sum += arr[i];
            }
            return sum / sopt;
        }
        private void SapXepTang()
        {
            Array.Sort(arr, 0, sopt);
        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while(a!=b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        private bool SoNguyenTo(int so)
        {
            if (so <= 0) return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0) return false;
                }
            }
            return true;
        }
        private int DemSNT()
        {
            int dem = 0;
            foreach (int x in arr)
            {
                if (SoNguyenTo(x))
                {
                    dem++;
                }
            }
            return dem;
        }
        private string InSNT()
        {
            string chuoi = "";
            foreach (int x in arr)
            {
                if (SoNguyenTo(x))
                {
                    chuoi += x + " ";
                }
            }
            return chuoi;
        }
        bool flag = true;
        private void btnNhap_Click(object sender, EventArgs e)
        {

            if (sopt == arr.Length)
            {
                MessageBox.Show("Mảng đầy", "Thông báo");
            }
            else
            {
                if (txtNhap.Text == "")
                    MessageBox.Show("Hãy nhập một phần tử", "Thông báo");
                else
                {
                    arr[sopt] = int.Parse(txtNhap.Text);
                    sopt++;
                    txtKetQua.Text += txtNhap.Text + " ";
                    txtNhap.Clear();
                    txtNhap.Focus();
                    if (sopt > 0 && flag == true)
                    {
                        btnInMang.Enabled = true;
                        btnXoa.Enabled = true;
                        btnTang.Enabled = true;
                        btnGiam.Enabled = true;
                        btnTongMang.Enabled = true;
                        btnSoLonNhat.Enabled = true;
                        btnSoHoanHao.Enabled = true;
                        btnSoNguyenTo.Enabled = true;
                        btnSoNhoNhat.Enabled = true;
                        btnDemSoChan.Enabled = true;
                        btnDemSoLe.Enabled = true;
                        btnTrungBinhMang.Enabled = true;
                        btnUCLN.Enabled = true;

                        flag = false;
                    }
                }
            }
        }

        private void btnInMang_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Các phần tử trong mảng là: " + InMang();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            SapXepTang();
            txtKetQua.Text = InMang().ToString();
            txtKetQua.Text += "\r\nĐã sắp xếp tăng";
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Mảng có " + DemSNT().ToString() + " số nguyên tố: " + InSNT().ToString();
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Ước chung lớn nhất 2 phần tử " + arr[0] + " và " +arr[1] +" là: " + UCLN(arr[0], arr[1]).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnInMang.Enabled = false;
            btnXoa.Enabled = false;
            btnTang.Enabled = false;
            btnGiam.Enabled = false;
            btnTongMang.Enabled = false;
            btnSoLonNhat.Enabled = false;
            btnSoHoanHao.Enabled = false;
            btnSoNguyenTo.Enabled = false;
            btnSoNhoNhat.Enabled = false;
            btnDemSoChan.Enabled = false;
            btnDemSoLe.Enabled = false;
            btnTrungBinhMang.Enabled = false;
            btnUCLN.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sopt = sopt - 1;
            txtKetQua.Text = InMang().ToString();
            if (flag == false && sopt == 0)
            {
                btnInMang.Enabled = false;
                btnXoa.Enabled = false;
                btnTang.Enabled = false;
                btnGiam.Enabled = false;
                btnTongMang.Enabled = false;
                btnSoLonNhat.Enabled = false;
                btnSoHoanHao.Enabled = false;
                btnSoNguyenTo.Enabled = false;
                btnSoNhoNhat.Enabled = false;
                btnDemSoChan.Enabled = false;
                btnDemSoLe.Enabled = false;
                btnTrungBinhMang.Enabled = false;
                btnUCLN.Enabled = false;

                flag = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            Array.Sort(arr, 0, sopt);
            Array.Reverse(arr, 0, sopt);
            txtKetQua.Text = InMang().ToString();
            txtKetQua.Text += "\r\nĐã sắp xếp giảm dần";
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                sum += arr[i];
            }
            txtKetQua.Text = "Tổng mảng: " + sum;
        }
        
        private void btnSoLonNhat_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Số lớn nhất: " + TimMax().ToString();
        }

        private void btnSoNhoNhat_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Số nhỏ nhất: " + TimMin().ToString();
        }
        private bool SoHoanHao(int so)
        {
            int sum = 0;
            for (int i = 1; i < so; i++)
            {
                if (so % i == 0) sum += i;
            }
            if (sum == so) return true;
            return false;

        }
        private void btnSoHoanHao_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (SoHoanHao(arr[i]))
                {
                    txtKetQua.Text = arr[i] + " "; dem++;
                }
            }
            if (dem == 0) txtKetQua.Text = "Không có số hoàn hảo bạn êiiiii !!";
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in arr)
            {
                if (x % 2 != 0)
                {
                    dem++;
                }
            }
            if (dem == 0) { txtKetQua.Text = "Không có số lẻ bạn êiiiii"; }
            else
            {
                txtKetQua.Text = "Có " + dem + "số lẻ";
            }
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    dem++;
                }
            }
            if (dem == 0) { txtKetQua.Text = "Không có số chẵn bạn êiiiii"; }
            else
            {
                txtKetQua.Text = "Có " + dem + "số chẵn";
            }
        }

        private void btnTrungBinhMang_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = TrungBinhMang().ToString();
        }

    }
}
