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
namespace Bai65_Thaotacvoistore
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
            HienThiToanBoSanPham(); 
        }
        private void HienThiToanBoSanPham()
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "LayToanBoSanPham";
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                ListViewItem lvi = new ListViewItem(ma + "");
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(gia+"");

                lvSP.Items.Add(lvi);
            }
            reader.Close();
        }

        private void lvSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSP.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSP.SelectedItems[0];

                int ma = int.Parse(lvi.SubItems[0].Text);
                HienThiChiTietSanPham(ma);
                
            }
        }
        private void HienThiChiTietSanPham(int masp)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ChiTietSanPham";
            command.Connection = conc;

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Int);
            parMa.Value = masp;
            command.Parameters.Add(parMa);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                txtMa.Text = reader.GetInt32(0) + "";
                txtTen.Text = reader.GetString(1);
                txtGia.Text = reader.GetInt32(2)+"";
                txtDanhMuc.Text = reader.GetInt32(3)+"";
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemSanPham";
            command.Connection = conc;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text;
            command.Parameters.Add("@dongia", SqlDbType.Int).Value = txtGia.Text;
            command.Parameters.Add("@madm", SqlDbType.Int).Value = txtDanhMuc.Text;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Succes");
                HienThiToanBoSanPham();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CapNhatGia";
            command.Connection = conc;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            command.Parameters.Add("@dongia", SqlDbType.Int).Value = txtGia.Text;

            lvSP.Items.Clear();
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiToanBoSanPham();
                MessageBox.Show("Succes");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaSanPham";
            command.Connection = conc;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
            lvSP.Items.Clear();
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiToanBoSanPham();
                MessageBox.Show("Succes");
            }
        }
    }
}
