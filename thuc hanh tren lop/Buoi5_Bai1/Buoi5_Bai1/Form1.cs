using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckSNT(int n)
        {
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private string InSNT(int n)
        {
            string s = "";
            for (int i = 2; i < n; i++)
            {
                if (CheckSNT(i))
                {
                    s += i + " ";
                }
            }
            return s;
        }
        private void btnLamlai_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapN.Text);
            if (CheckSNT(n))
            {
                txtKiemTra.Text = n + " là số nguyên tố";
            }
            else
            {
                txtKiemTra.Text = n + "không phải số nguyên tố";
            }
            txtSoLuong.Text = InSNT(n).ToString();
        }

        
    }
}
