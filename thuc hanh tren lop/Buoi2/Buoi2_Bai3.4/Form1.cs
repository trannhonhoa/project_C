using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            int ngay = int.Parse(txtNgay.Text);
            int thang = int.Parse(txtThang.Text);
            int nam = int.Parse(txtNam.Text);
            if (ngay < 1|| ngay > 31 || thang > 12 || thang < 1)
            {
                MessageBox.Show("Ngay khong hop le");
            }
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                if (ngay <= 31)
                {
                    MessageBox.Show("Ngay hop le");
                }
                else
                {
                    MessageBox.Show("Ngay khong hop le");
                }
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                if (ngay <= 30)
                {
                    MessageBox.Show("Ngay hop le");
                }
                else
                {
                    MessageBox.Show("Ngay khong hop le");
                }
            }
            else if (thang == 2)
            {
                if (ngay <= 28)
                {
                    MessageBox.Show("Ngay hop le");
                }
                else
                {
                    MessageBox.Show("Ngay khong hop le");
                }

            }
            
        }
    }
}
