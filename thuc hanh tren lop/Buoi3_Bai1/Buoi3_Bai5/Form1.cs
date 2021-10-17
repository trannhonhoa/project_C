using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int TimMax(int so1, int so2){
            if (so1 < so2)
                return so1;
            else
                return so2;
        }
        private string TimUocChung(int a, int b)
        {
            int max = TimMax(a, b);
            string chuoi = "";
            for (int i = 1; i <= max; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    chuoi += i + ", ";
                }
            }
            return chuoi;
        }
        private int timUCLN(int a, int b)
        {
            int max = TimMax(a, b);
            int ucln = 1;
            for (int i = 2; i <= max; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    ucln = i;
                }
            }
            return ucln;
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            if (rad1.Checked)
            {
                txtKetQua.Text = TimUocChung(n, m);
            }
            else if (rad2.Checked)
            {
                txtKetQua.Text = timUCLN(m, n) + "";
            }
        }
    }
}
