using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo");
                txtHoTen.Focus();
            }
            else
            {
                string hoten = txtHoTen.Text;
                if (radThuong.Checked)
                {
                    txtKetQua.Text = hoten.ToLower();
                }
                else if(radInHoa.Checked)
                {
                    txtKetQua.Text = hoten.ToUpper();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtKetQua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
