using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai54_DocGhiFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> dssv = new List<SinhVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            sv.NamSinh = dtpNamSinh.Value;
            dssv.Add(sv);
            ShowSinhVien();
        }

        private void ShowSinhVien()
        {
            listSV.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                listSV.Items.Add(sv);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\csdl.txt";
                bool kq = FileFactory.LuuFile(dssv, path);
                if (kq)
                {
                    MessageBox.Show("Luu thanh cong");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath +"\\csdl.txt";
            dssv = FileFactory.DocFile(path);
            try
            {
                ShowSinhVien();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDoc.PerformClick();
        }

        
    }
}
