using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckSHH(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) sum += i;
            }
            if (sum == n) return true;
            return false;
        }
        private void btnLamlai_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapN.Text);
            if (CheckSHH(n))
            {
                string s = n + " là số hoàn hảo";
                MessageBox.Show(s, "Thông báo");
            }
            else
            {
                string s = n + " không phải là số hoàn hảo";
                MessageBox.Show(s, "Thông báo");
            }
        }
    }
}
