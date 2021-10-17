using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CheckSinhVien()
        {
            if (txtMa.Text == "" || txtHoTen.Text == "" || txtDienThoai.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo"); return;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbQueQuan.Items.AddRange(new string[] { "An Giang", "Đồng Tháp", "Cần Thơ" });
            radNam.Checked = true;
            cmbQueQuan.SelectedIndex = 0;
        }
        private void HienThiLenListView()
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CheckSinhVien();
            ListViewItem lvi = new ListViewItem(txtMa.Text);
            lvi.SubItems.Add(txtHoTen.Text);
            lvi.SubItems.Add(dtpNgSinh.Value.ToString("MM/dd/yy"));
            lvi.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
            lvi.SubItems.Add(txtDienThoai.Text);
            lvi.SubItems.Add(cmbQueQuan.SelectedItem.ToString());
            lvSinhVien.Items.Add(lvi);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSinhVien.SelectedItems[0];
                lvi.SubItems[0].Text = txtMa.Text;
                lvi.SubItems[1].Text = txtHoTen.Text;
                lvi.SubItems[2].Text = dtpNgSinh.Value.ToString("MM/dd/yy");
                lvi.SubItems[3].Text = radNam.Checked ? "Nam" : "Nữ";
                lvi.SubItems[4].Text = txtDienThoai.Text;
                lvi.SubItems[5].Text = cmbQueQuan.SelectedItem.ToString();
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSinhVien.SelectedItems[0];
                txtMa.Text = lvi.SubItems[0].Text;
             
                txtHoTen.Text = lvi.SubItems[1].Text;
                string ngaysinh = lvi.SubItems[2].Text;

                dtpNgSinh.Value = DateTime.Parse(lvi.SubItems[2].Text);
                

                if (lvi.SubItems[3].Text == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
     
                txtDienThoai.Text = lvi.SubItems[4].Text;
                cmbQueQuan.SelectedItem = lvi.SubItems[5].Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
        
    }
}
