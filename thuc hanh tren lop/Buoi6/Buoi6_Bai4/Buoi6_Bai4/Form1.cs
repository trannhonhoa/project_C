using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai4
{
    public partial class Form1 : Form
    {
        List<SinhVien> dssv = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbLop.Items.AddRange(new string[] { "DH20TH1", "DH20KT1" });
        }
        private void HienThiDanhSach()
        {
            lvSinhVien.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                ListViewItem lvi = new ListViewItem(sv.MaSV);
                lvi.SubItems.Add(sv.HoTen);
                lvi.SubItems.Add(sv.DiaChi);
                lvi.SubItems.Add(sv.NgaySinh.ToString("MM/dd/yy"));
                lvi.SubItems.Add(sv.Lop);
                lvi.Tag = sv;
                lvSinhVien.Items.Add(lvi);
            }
        }
        private void CheckSinhVien()
        {
            if (txtMa.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin", "Thông báo"); return;
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CheckSinhVien();
            SinhVien sv = new SinhVien();
            sv.MaSV = txtMa.Text;
            sv.HoTen = txtHoTen.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.NgaySinh = dtpNgSinh.Value;
            sv.Lop = cmbLop.SelectedItem.ToString();
            
            dssv.Add(sv);
            HienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSinhVien.SelectedItems[0];
                SinhVien sv = lvi.Tag as SinhVien;
                dssv.Remove(dssv.Single(x => x.MaSV == sv.MaSV));
            }
            HienThiDanhSach();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Tập tin txt| *.txt| Tất cả | *.";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool kq = FileSerializable.SaveFile(dssv, saveFileDialog1.FileName);
                if (kq)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lưu thất bại", "Thông báo");
                }
            }
        }

        
    }
}
