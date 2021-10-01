using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ThemSanPham_bai62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conc = null;
        string strConc = "Server=DESKTOP-P9L00KA; Database=CSDLTest; User Id=sa; pwd=trannhonhoa";
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
        }
        private void HienThiDanhSachSanPham()
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.SanPham";
            command.Connection = conc;
            lvSanPham.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + "");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2)+"");

                lvSanPham.Items.Add(lvi);
            }
            reader.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "Insert into dbo.SanPham(Ma, Ten, DonGia, MaDanhMuc)"+
                " values (" + txtMa.Text + ",N'" + txtTen.Text + "', " + txtGia.Text + ","+ txtDanhMuc.Text + ")";
            command.CommandText = sql;
            command.Connection = conc;
            int ret = command.ExecuteNonQuery();

            if (ret > 0)
            {
                MessageBox.Show("Them Thanh Cong");
                HienThiDanhSachSanPham();
            }
            else
            {
                MessageBox.Show("Them That Bai!!");
            }

        }

    }
}
