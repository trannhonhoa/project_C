using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }
        private void btnHienThongTin_Click(object sender, EventArgs e)
        {

            string s = "";
            s += "Họ tên: " + txtHoten.Text;
            s += "\r\nGiới tính: " + (radNam.Checked ? "Nam" : "Nữ");
            s += "\r\nNgày Sinh: " + dtpNgaySinh.Value;
            s += "\r\nĐịa chỉ: " + txtDiaChi.Text;
            if (IsPhoneNumber(txtDienThoai.Text))
            {
                s += "\r\nĐiện thoai: " + txtDienThoai.Text;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo"); return;
            }
            if (IsValidEmail(txtEmail.Text))
            {
                s += "\r\nEmail: " + txtEmail.Text; 
            }
            else
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo"); return;
            }
            s += "\r\nTình trạng: " + (chkDiNhau.Checked ? "Đang đi nhậu" : "Đang trốn việc");
            MessageBox.Show(s);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        

        
    }
}
