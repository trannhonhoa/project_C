using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(txtThang.Text);
            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    {
                        MessageBox.Show("Mua xuan");
                        break;
                    }
                case 4:
                case 5:
                case 6:
                    {
                        MessageBox.Show("Mua Ha");
                        break;
                    }
                case 7:
                case 8:
                case 9:
                    {
                        MessageBox.Show("Mua Thu");
                        break;
                    }
                case 10:
                case 11:
                case 12:
                    {
                        MessageBox.Show("Mua Dong");
                        break;
                    }
                default:
                    MessageBox.Show("Thang nay khong hop le");
                    break;
            }
        }

        
    }
}
