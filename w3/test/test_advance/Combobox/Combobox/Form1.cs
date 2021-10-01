using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDathang_Click(object sender, EventArgs e)
        {
            string details ="";
            details="Thong Tin Khach Hang:\n\n\n";
            details+="Ho va ten:\n\t " + txtName.Text;
            details+="So dien thoai:\n\t "+ txtPhone.Text;
            details+="San Pham khach hang:\n\t : " +listSanPham.SelectedItem;
            details+="Hinh thuc thanh toan:\n\t: " + comboboxPay.SelectedItem;
            listChitet.Text = details;
            
        }

        private void comboboxPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxPay.SelectedIndex != -1)
            {
                MessageBox.Show("Ban chon" + comboboxPay.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pay atm = new Pay();
            atm.Ma = 1;
            atm.hinhthuc = "Chuyen Khoan ATM";
            atm.PhiThanhToan = 0;
            comboBox1.Items.Add(atm);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                // pay la mot doi tuong ton tai trong combobox
                Pay pay = comboBox1.SelectedItem as Pay;
                MessageBox.Show(pay.hinhthuc);
            }
        }

        

        
    }
}
