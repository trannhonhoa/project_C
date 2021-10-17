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
    public partial class frmDanhMuc : Form
    {
        public static bool coThayDoi = false;
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.Ma = textMaDM.Text;
            dm.Ten = textTenDM.Text;
            frmSanPham.danhSachDM.Add(dm);
            HienThiLenLisBox();
            textTenDM.Text = "";
            textMaDM.Text = "";
            textMaDM.Focus();
            coThayDoi = true;
        }
        void HienThiLenLisBox()
        {
            lstDanhMuc.Items.Clear();
            foreach (DanhMuc dm in frmSanPham.danhSachDM)
            {
                lstDanhMuc.Items.Add(dm);
            }
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                textMaDM.Text = dm.Ma;
                textTenDM.Text = dm.Ten;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                lstDanhMuc.Items.Remove(dm);
            }
            coThayDoi = true;
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiLenLisBox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (coThayDoi)
            {
                DialogResult = DialogResult.OK;
            }
            else{
                DialogResult = DialogResult.Cancel;
            }

        }
    }
}
