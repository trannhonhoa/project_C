using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XuLyVe100Ghe();
        }
        private void XuLyVe100Ghe()
        {
            tableVeXe.Controls.Clear();
            int ghe = 1;
            for(int i = 0; i< 4; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (ghe > 30)
                    {
                        continue;
                    }
                    else
                    {
                        Label lblGhe = new Label();
                        lblGhe.Text = ghe + "";
                        lblGhe.AutoSize = false;
                        lblGhe.Dock = DockStyle.Fill;
                        lblGhe.TextAlign = ContentAlignment.TopLeft;
                        lblGhe.BackColor = Color.White;
                        lblGhe.BorderStyle = BorderStyle.Fixed3D;
                        tableVeXe.Controls.Add(lblGhe, j, i);
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
                lblghe.BackColor = Color.Blue;
            }
            else if (lblghe.BackColor == Color.Blue)
            {
                lblghe.BackColor = Color.White;
            }
            else if (lblghe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được chọn", "Thông báo");
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < tableVeXe.Controls.Count; i++)
            {
                Label lblGhe = tableVeXe.Controls[i] as Label;
                if (lblGhe.BackColor == Color.Blue)
                {
                    lblGhe.BackColor = Color.Yellow;
                    count++;
                }
            }
            if (count == 0)
                MessageBox.Show("Bạn chưa chọn ghế!");
            else
            {
                lblThanhTien.Text = (count * 100000) + " VND";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableVeXe.Controls.Count; i++)
            {
                Label lblGhe = tableVeXe.Controls[i] as Label;
                if (lblGhe.BackColor == Color.Blue)
                {
                    lblGhe.BackColor = Color.White;
                }
            }
            lblThanhTien.Text = 0 + " VND";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
