using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (string.Compare(txtUser.Text, "nguyenvanhung", true) == 0 && string.Compare(txtPass.Text, "abc12345", true) == 0)
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    Close();
                   
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhâp lại", "Thông báo");
                    txtUser.Clear();
                    txtPass.Clear();
                    txtUser.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        
    }
}
