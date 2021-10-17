using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocGhiFileSerialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<SinhVien> dssv = new List<SinhVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            sv.Ngsinh = dptNgaySinh.Value;
            dssv.Add(sv);
            HienThiSinhVien();
        }
        private void HienThiSinhVien()
        {
            listSinhVien.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                listSinhVien.Items.Add(sv);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string path = @"D:\database.txt";
            bool kt = FileFactory.LuuFile(dssv, path);
            if (kt) MessageBox.Show("Success");
            else MessageBox.Show("Fail");
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string path = @"D:\database.txt";
            if (System.IO.File.Exists(path))
            {
                dssv = FileFactory.DocFile(path);
                HienThiSinhVien();
            }
        }
    }
}
