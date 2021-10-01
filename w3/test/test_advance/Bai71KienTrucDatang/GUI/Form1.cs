using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbbl = new SanPhamBLL();
            List<SanPham> dsss = spbbl.LayToanBoSanPham();
            lvSanPham.Items.Clear();
            foreach(SanPham sp in dsss){
                ListViewItem lvi = new ListViewItem(sp.MaSP+"");
                lvi.SubItems.Add(sp.TenSP);
                lvi.SubItems.Add(sp.DonGia + "");
                lvi.SubItems.Add(sp.MaDM + "");
                lvSanPham.Items.Add(lvi);
                lvi.Tag = sp;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSanPham.SelectedItems[0];
                SanPham sp = lvi.Tag as SanPham;
                SanPhamBLL spbll = new SanPhamBLL();
                bool kq = spbll.XoaSanPham(sp.MaSP);
                if (kq)
                {
                    btnNap.PerformClick();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            SanPham sp = new SanPham();
            sp.MaSP = int.Parse(txtMa.Text);
            sp.TenSP = txtTen.Text;
            sp.DonGia = int.Parse(txtGia.Text);
            sp.MaDM = int.Parse(txtMaDM.Text);
            bool kq = spbll.ThemSanPham(sp);
            if (kq)
            {
                btnNap.PerformClick();
            }
            else
            {
                MessageBox.Show("Khong duoc de trong!!!");
            }
        }
        
    }
}
