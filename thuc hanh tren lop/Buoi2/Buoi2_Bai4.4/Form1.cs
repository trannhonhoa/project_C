using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtn.Text, out n))
            {
                MessageBox.Show("N phai la so");
                return;

            }
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (2 * i - 1);
            }
            txtS.Text = sum + "";
        }
    }
}
