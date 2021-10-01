using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSanpham
{
    public partial class frmSanPham : Form
    {
        public static List<DanhMuc> danhSachDM = new List<DanhMuc>();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDanhMuc.coThayDoi = false;
            if (frmDM.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhMuc();
            }
        }

        private void HienThiDanhMuc()
        {
            
            foreach (DanhMuc dm in danhSachDM)
            {
                cmbDanhmuc.Items.Add(dm);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbDanhmuc.SelectedIndex == -1)
            {
                return;
            }
            DanhMuc dm = cmbDanhmuc.SelectedItem as DanhMuc;
            SanPham sp = new SanPham();
            sp.MaSP = txtMa.Text;
            sp.TenSP = txtTen.Text;
            sp.DonGia = double.Parse(txtDongia.Text);
            sp.XuatXu = txtXuatXu.Text;
            sp.HanDung = dtpHanDung.Value;
            dm.ThemSanPham(sp);
        }
        

        

        
    }
}
