using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai35_quanlykhachhang
{
    public partial class Form1 : Form
    {
        DanhSachKhachHang database = new DanhSachKhachHang();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.ten = txtTen.Text;
            kh.soLuongMua = int.Parse(txtSoluong.Text);
            kh.laSinhVien = chkLaSinhVien.Checked;
            database.Mua(kh);
            lblThanhTien.Text = kh.TinhTien+"";
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtSoluong.Text = "";
            chkLaSinhVien.Checked = false;
            lblThanhTien.Text = "";
            txtTen.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtTongKhacHang.Text = database.TongSoKhachHang+"";
            lblTong.Text = database.TongSoKhachHangLaSinhVien+"";
            txtTongDoanhThu.Text = database.TongDoanhThu + "";
        }

        private void txtTongKhacHang_DoubleClick(object sender, EventArgs e)
        {
            Form frmKh = new Form();
            frmKh.Width = frmKh.Height = 300;
            ListBox listBoxKH = new ListBox();
            frmKh.Controls.Add(listBoxKH);
            listBoxKH.Dock = DockStyle.Fill;
            foreach(KhachHang kh in database.Khachs){
                listBoxKH.Items.Add(kh.ten);
            }
            frmKh.StartPosition = FormStartPosition.CenterParent;
            frmKh.Show();

        }

        private void txtTongSV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKh = new Form();
            frmKh.Width = frmKh.Height = 300;
            ListBox listBoxKH = new ListBox();
            frmKh.Controls.Add(listBoxKH);
            listBoxKH.Dock = DockStyle.Fill;
            foreach (KhachHang kh in database.Khachs)
            {
                if (kh.laSinhVien)
                {

                    listBoxKH.Items.Add(kh.ten);
                }
            }
            frmKh.StartPosition = FormStartPosition.CenterParent;
            frmKh.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Muon tat ha", "A du", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        
    }
}
