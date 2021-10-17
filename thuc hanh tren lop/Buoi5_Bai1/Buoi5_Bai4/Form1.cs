using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float ChuViHinhTron()
        {
            float c = float.Parse(txtNhap.Text);
            float d = (float)(Math.Sqrt(c * c + c * c));
            float r = d / 2;
            float cvHT = (float)(r * 2 * Math.PI);
            return cvHT;
        }
        private float DienTichHinhTron()
        {
            float c = float.Parse(txtNhap.Text);
            float d = (float)(Math.Sqrt(c * c + c * c));
            float r = d / 2;
            float dtHT = (float)(r * r * Math.PI);
            return dtHT;
        }
        private float ChuViHinhVuong()   
        {
            float d = float.Parse(txtNhap.Text);
            return d * 4;
            
        }
        private float DienTichHinhVuong()
        {
            float d = float.Parse(txtNhap.Text);
            return d * d;

        }
        private float ChuViHinhChuNhat()
        {
            float d = float.Parse(txtNhap.Text);
            return (d + d) * 2  ;

        }
        private float DienTichHinhChuNhat()
        {
            float d = float.Parse(txtNhap.Text);
            return d * d;

        }
        private float ChuViHinhTamGiac()
        {
            float d = float.Parse(txtNhap.Text);
            return (d + d + d);

        }
        private float DienTichHinhTamGiac()
        {
            float d = float.Parse(txtNhap.Text);
            float h = d * (float)(Math.Sqrt(3) / 2);
            float dtTG = (d * h) / 2;
            return dtTG;

        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhâp 1 cạnh", "Thông báo"); return; 
            }
            if (radHinhTron.Checked)
            {
                txtChuVi.Text = ChuViHinhTron().ToString();
                txtDienTich.Text = DienTichHinhTron().ToString();
            }
            if (radHinhVuong.Checked)
            {
                txtChuVi.Text = ChuViHinhVuong().ToString();
                txtDienTich.Text = DienTichHinhVuong().ToString();
            }
            if (radHinhChuNhat.Checked)
            {
                txtChuVi.Text = ChuViHinhChuNhat().ToString();
                txtDienTich.Text = DienTichHinhChuNhat().ToString();
            }
            if (radHinhTamGiac.Checked)
            {
                txtChuVi.Text = ChuViHinhTamGiac().ToString();
                txtDienTich.Text = DienTichHinhTamGiac().ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtNhap.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        
    }
}
