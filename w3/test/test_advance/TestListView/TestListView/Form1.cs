using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSanPham.SelectedItems[0];
                string ma = lvi.SubItems[0].Text;
                string ten = lvi.SubItems[1].Text;
                int gia = int.Parse(lvi.SubItems[2].Text);
                txtMa.Text = ma;
                txtTen.Text = ten;
                txtGia.Text = gia+"";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtMa.Text);
            lvi.SubItems.Add(txtTen.Text);
            lvi.SubItems.Add(txtGia.Text);
            lvSanPham.Items.Add(lvi);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                lvSanPham.Items.Remove(lvSanPham.SelectedItems[0]);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSanPham.SelectedItems[0];
                lvi.SubItems[0].Text = txtMa.Text;
                lvi.SubItems[1].Text = txtTen.Text;
                lvi.SubItems[2].Text = txtMa.Text;
            }
        }

        
    }
}
