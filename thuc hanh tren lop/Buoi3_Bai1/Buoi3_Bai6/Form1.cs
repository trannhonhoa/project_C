using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string s = txtNhapChuoi.Text;
            if (s != "")
            {
                lstTen.Items.Add(s);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndex != -1)
            {
                lstTen.Items.Remove(lstTen.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tên xóa", "Thông báo");
            }
        }

        private void btnMauChu_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.ForeColor = colorDialog1.Color;
            }
        }

        private void lstTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndex != -1)
            {
                txtHienThi.Text = lstTen.SelectedItem.ToString();
            }
        }

        private void btnMauNen_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.BackColor = colorDialog1.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.Font = fontDialog1.Font;
            }
        }

        
    }
}
