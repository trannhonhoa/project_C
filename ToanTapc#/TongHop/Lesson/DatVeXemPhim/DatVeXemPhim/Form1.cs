using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatVeXemPhim
{
    public partial class Form1 : Form
    {
        List<KhachHang> dskh = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XuLyVe100Ghe();
        }
        private void XuLyVe100Ghe()
        {
            pnGhe.Controls.Clear();
            int ghe = 1;
            for (int i = 0; i < pnGhe.RowCount; i++)
            {
                for (int j = 0; j < pnGhe.ColumnCount; j++)
                {
                    Label lblGhe = new Label();
                    lblGhe.Text = ghe + "";
                    lblGhe.AutoSize = false;
                    lblGhe.Dock = DockStyle.Fill;
                    lblGhe.TextAlign = ContentAlignment.MiddleCenter;
                    lblGhe.Width = lblGhe.Height = 50;
                    lblGhe.BackColor = Color.White;
                    pnGhe.Controls.Add(lblGhe, j, i);
                    ghe++;

                    lblGhe.Click += lblGhe_Click;

                }
            }
        }

        void lblGhe_Click(object sender, EventArgs e)
        {
            Label lblghe = sender as Label;
            if (lblghe.BackColor == Color.White)
            {
                lblghe.BackColor = Color.Green;
            }
            else if (lblghe.BackColor == Color.Green)
            {
                lblghe.BackColor = Color.White;
            }
            else if (lblghe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghe nay da co nguoi chon");
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            frmDatve frm = new frmDatve();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                KhachHang kh = new KhachHang();
                kh.Name = frm.txtTen.Text;
                kh.Phone = frm.txtSDT.Text;
                kh.GioDatGhe = DateTime.Now;
                for (int i = 0; i < pnGhe.Controls.Count; i++)
                {
                    
                    Label lblGhe = pnGhe.Controls[i] as Label;
                    if (lblGhe.BackColor == Color.Green)
                    {
                        lblGhe.BackColor = Color.Yellow;
                        int ghe = int.Parse(lblGhe.Text);
                        kh.Ghes.Add(ghe);
                    }
                    
                }
                lblThanhTien.Text = kh.TinhTien+"";
                dskh.Add(kh);
                HienThiTongTien();
                HienThiKhacHangLenCheckBox();
            }
        }

        private void HienThiKhacHangLenCheckBox()
        {
            listKhachHang.Items.Clear();
            foreach (KhachHang kh in dskh)
            {
                listKhachHang.Items.Add(kh);
            }
        }

        private void HienThiTongTien()
        {
            int sum = 0;
            foreach (KhachHang kh in dskh)
            {
                sum += kh.TinhTien;
            }
            lblTongThanhTien.Text=sum+"";
        }

        private void listKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listKhachHang.SelectedIndex != -1)
            {
                KhachHang kh = listKhachHang.SelectedItem as KhachHang;
                lblThanhTien.Text = kh.TinhTien+"";
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (listKhachHang.SelectedIndex != -1)
            {
                KhachHang kh = listKhachHang.SelectedItem as KhachHang;
                DateTime d1 = DateTime.Now;
                TimeSpan time = d1 - kh.GioDatGhe;
                if (time.Minutes > 30 )
                {
                    MessageBox.Show("Qua time");
                    return;
                }
                for (int i = 0; i < pnGhe.Controls.Count; i++)
                {
                    Label lblGhe = pnGhe.Controls[i] as Label;
                    int maGhe = int.Parse(lblGhe.Text);
                    int flag = 0;
                    while (kh.Ghes.Count > 0 && flag < kh.Ghes.Count)
                    {
                        int gheDat = kh.Ghes[0];
                        if (maGhe == gheDat)
                        {
                            lblGhe.BackColor = Color.White;
                            kh.Ghes.Remove(gheDat);
                        }
                        flag++;
                    }
                }
                dskh.Remove(kh);
                HienThiKhacHangLenCheckBox();
                HienThiTongTien();

            }
            else
            {
                MessageBox.Show("Ban phai chon khach hang truoc");
            }
        }

        
    }
}
