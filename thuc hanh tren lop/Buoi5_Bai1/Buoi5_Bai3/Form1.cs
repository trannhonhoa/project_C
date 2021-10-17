using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTuSo1.Clear();
            txtTuSo2.Clear();
            txtMauSo1.Clear();
            txtMauSo2.Clear();
            txtTuSoKQ.Clear();
            txtMauSoKQ.Clear();

        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTuSo1.Text);
            int ts2 = int.Parse(txtTuSo2.Text);
            int ms1 = int.Parse(txtMauSo1.Text);
            int ms2 = int.Parse(txtMauSo2.Text);

            if (txtTuSo1.Text == "" || txtTuSo2.Text == "" || txtMauSo1.Text == "" || txtMauSo2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ phân số", "Thông báo"); return;
            }
            if (ms1 == 0 || ms2 == 0)
            {
                MessageBox.Show("Mẫu phải khác 0", "Thông báo"); return;
            }

            int kqT = ts1 * ms2 + ts2 * ms1;
            int kqM = ms1 * ms2;
            int ucln = UCLN(kqT, kqM);
            if (kqT == 0)
            {
                txtTuSoKQ.Text = 0 + "";
                txtMauSoKQ.Text = 0 + "";
                return;
            }
            txtTuSoKQ.Text = (kqT/ucln)+"";
            txtMauSoKQ.Text = (kqM/ucln)+"";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTuSo1.Text);
            int ts2 = int.Parse(txtTuSo2.Text);
            int ms1 = int.Parse(txtMauSo1.Text);
            int ms2 = int.Parse(txtMauSo2.Text);

            if (txtTuSo1.Text == "" || txtTuSo2.Text == "" || txtMauSo1.Text == "" || txtMauSo2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ phân số", "Thông báo"); return;
            }
            if (ms1 == 0 || ms2 == 0)
            {
                MessageBox.Show("Mẫu phải khác 0", "Thông báo"); return;
            }

            int kqT = ts1 * ms2 - ts2 * ms1;
            int kqM = ms1 * ms2;
            if (kqT == 0)
            {
                txtTuSoKQ.Text = 0+"";
                txtMauSoKQ.Text = 0+"";
            }
            else
            {
                int ucln = UCLN(kqT, kqM);
                txtTuSoKQ.Text = (kqT / ucln) + "";
                txtMauSoKQ.Text = (kqM / ucln) + "";
            }
            
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTuSo1.Text);
            int ts2 = int.Parse(txtTuSo2.Text);
            int ms1 = int.Parse(txtMauSo1.Text);
            int ms2 = int.Parse(txtMauSo2.Text);

            if (txtTuSo1.Text == "" || txtTuSo2.Text == "" || txtMauSo1.Text == "" || txtMauSo2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ phân số", "Thông báo"); return;
            }
            if (ms1 == 0 || ms2 == 0)
            {
                MessageBox.Show("Mẫu phải khác 0", "Thông báo"); return;
            }

            int kqT = ts1 * ts2  ;
            int kqM = ms1 * ms2;
            int ucln = UCLN(kqT, kqM);
            if (kqT == 0)
            {
                txtTuSoKQ.Text = 0 + "";
                txtMauSoKQ.Text = 0 + "";
                return;
            }
            txtTuSoKQ.Text = (kqT / ucln) + "";
            txtMauSoKQ.Text = (kqM / ucln) + "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int ts1 = int.Parse(txtTuSo1.Text);
            int ts2 = int.Parse(txtTuSo2.Text);
            int ms1 = int.Parse(txtMauSo1.Text);
            int ms2 = int.Parse(txtMauSo2.Text);

            if (txtTuSo1.Text == "" || txtTuSo2.Text == "" || txtMauSo1.Text == "" || txtMauSo2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ phân số", "Thông báo"); return;
            }
            if (ms1 == 0 || ms2 == 0)
            {
                MessageBox.Show("Mẫu phải khác 0", "Thông báo"); return;
            }

            int kqT = ts1 * ms2;
            int kqM = ms1 * ts2;
            int ucln = UCLN(kqT, kqM);
            if (kqT == 0)
            {
                txtTuSoKQ.Text = 0 + "";
                txtMauSoKQ.Text = 0 + "";
                return;
            }
            txtTuSoKQ.Text = (kqT / ucln) + "";
            txtMauSoKQ.Text = (kqM / ucln) + "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
