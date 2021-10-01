using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.modal;
namespace QuanLySinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Dictionary<string, Khoa> CSDL = new Dictionary<string, Khoa>();
        private void frmMain_Load(object sender, EventArgs e)
        {
            LamGiaDuLieu();
            HienThiLenTv();
            HienThiLenCombox();
        }
        private void HienThiLenTv()
        {
            tvKhoa.Nodes.Clear();
            foreach (KeyValuePair<string, Khoa> item in CSDL)
            {
                Khoa kh = item.Value;
                TreeNode nodekhoa = new TreeNode(kh.TenKhoa);
                nodekhoa.Tag = kh;

                tvKhoa.Nodes.Add(nodekhoa);

                foreach (KeyValuePair<string, LopHoc> itemLop in kh.Lops)
                {
                    LopHoc lop = itemLop.Value;
                    TreeNode nodeLop = new TreeNode(lop.TenLop);
                    nodeLop.Tag = lop;
                    nodekhoa.Nodes.Add(nodeLop);
                }
            }
            tvKhoa.ExpandAll();
        }
        private void LamGiaDuLieu() {
            // Khoa
            Khoa cntt = new Khoa() { MaKhoa = "CNTT", TenKhoa ="Khoa CNTT"};
            Khoa dt = new Khoa() { MaKhoa = "dt", TenKhoa = "Khoa dien tu" };
            Khoa kinhte = new Khoa(){MaKhoa="kt", TenKhoa="Kinh te"};
            CSDL.Add(cntt.MaKhoa, cntt);
            CSDL.Add(dt.MaKhoa, dt);
            CSDL.Add(kinhte.MaKhoa, kinhte);
            // Lop
            LopHoc lopcntt1 = new LopHoc() { MaLop = "cntt1", TenLop = "Dai hoc tin hoc 1", GiaoVienCoVan = "Cuong" };
            cntt.Lops.Add(lopcntt1.MaLop, lopcntt1);
            lopcntt1.KhoaChuQuan = cntt;

            LopHoc lopcntt2 = new LopHoc() { MaLop = "cntt2", TenLop = "Dai hoc tin hoc 2", GiaoVienCoVan = "Cuong" };
            cntt.Lops.Add(lopcntt2.MaLop, lopcntt2);
            lopcntt2.KhoaChuQuan = cntt;

            LopHoc kinhte1 = new LopHoc() { MaLop = "kinte1", TenLop = "Dai hoc kinh te 1", GiaoVienCoVan = "Cuong" };
            kinhte.Lops.Add(kinhte1.MaLop, kinhte1);
            kinhte1.KhoaChuQuan = kinhte;


            //Sinh vien

            SinhVien teo = new SinhVien() { Ma="sv1", Ten="Nguyen van Teo", GioiTinh=false, NamSinh= new DateTime(2001, 2,3)};
            lopcntt1.SinhViens.Add(teo.Ma, teo);
            teo.LopChuQuan = lopcntt1;

            SinhVien buoi = new SinhVien() { Ma = "sv1", Ten = "Nguyen Thi Buoi", GioiTinh = true, NamSinh = new DateTime(2001, 4, 3) };
            kinhte1.SinhViens.Add(buoi.Ma, buoi);
            buoi.LopChuQuan = lopcntt1;
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Level == 1) // node Khoa = 0, node Lop = 1
                {
                    LopHoc lp = e.Node.Tag as LopHoc;
                    HienThiTheoLop(lp);
                }
                else
                {
                    lvSinhVien.Items.Clear();
                }
            }
        }
        private void HienThiLenCombox()
        {
            cmbKhoa.Items.Clear();
            foreach (KeyValuePair<string, Khoa> itemKhoa in CSDL)
            {
                Khoa kh = itemKhoa.Value;
                cmbKhoa.Items.Add(kh);
            }
        }
        private void HienThiTheoLop(LopHoc lp)
        {
            lvSinhVien.Items.Clear();
            foreach (KeyValuePair<string, SinhVien> itemSV in lp.SinhViens)
            {
                SinhVien sv = itemSV.Value;
                ListViewItem lvi = new ListViewItem(sv.Ma);
                lvi.SubItems.Add(sv.Ten);
                lvi.SubItems.Add(sv.GioiTinh == false ? "Name" : "Nu");
                lvi.SubItems.Add(sv.NamSinh.ToString("dd/MM/yy"));
                lvSinhVien.Items.Add(lvi);
                lvi.Tag = sv;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedIndex == -1) return;
            Khoa kh = cmbKhoa.SelectedItem as Khoa;
            HienLopThiLenCombox(kh);

        }
        private void HienLopThiLenCombox(Khoa kh)
        {
            cmbLop.Items.Clear();
            foreach (KeyValuePair<string, LopHoc> itemLop in kh.Lops)
            {
                LopHoc lop = itemLop.Value;
                cmbLop.Items.Add(lop);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Ban chua chon khoa");
                return;
            }
            if (cmbLop.SelectedIndex == -1)
            {
                MessageBox.Show("Ban chua chon Lop");
                return;
            }
            SinhVien sv = new SinhVien();
            sv.Ma = txtMa.Text;
            sv.Ten = txtTen.Text;
            sv.GioiTinh = rdNu.Checked;
            LopHoc lp = cmbLop.SelectedItem as LopHoc;
            sv.LopChuQuan = lp;
            lp.SinhViens.Add(sv.Ma, sv);
            HienThiTheoLop(lp);
            MessageBox.Show("Da Luu Thanh Cong !!!"); 
        }
        SinhVien SinhVienSelected = null;
        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (SinhVienSelected == null)
            {
                MessageBox.Show("Chua chon sinh vien");
                return;
            }
            LopHoc lp = SinhVienSelected.LopChuQuan;
            lp.SinhViens.Remove(SinhVienSelected.Ma);
            HienThiTheoLop(new LopHoc());
            MessageBox.Show("Xoa Thanh Cong");
            
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == -1) return;
            
            ListViewItem lvi = lvSinhVien.SelectedItems[0];
            SinhVien sv = lvi.Tag as SinhVien;
            txtMa.Text = sv.Ma;
            txtTen.Text = sv.Ten;
            if (sv.GioiTinh)
            {
                rdNu.Checked = true;
            }
            else
            {
                rdNam.Checked = true;
            }
            SinhVienSelected = sv;
        }
    }
}
