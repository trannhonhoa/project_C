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

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            List<SanPham> dssp = spbll.LayToanBoSanPham();
            lvSanPham.Items.Clear();
            foreach (SanPham sp in dssp)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSP.ToString());
                lvi.SubItems.Add(sp.TenSp);
                lvi.SubItems.Add(sp.DonGia.ToString());
                lvi.SubItems.Add(sp.MaDM.ToString());
                lvSanPham.Items.Add(lvi);
            }
        }
    }
}
