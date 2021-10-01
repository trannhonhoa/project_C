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
namespace updateData_bai63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conc = null;
        string strConc = "Server=DESKTOP-P9L00KA; Database=CSDLTest; User Id=sa; pwd=trannhonhoa";
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhMucVaoCmb();
        }
        private void HienThiDanhMucVaoCmb()
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.DanhMuc";
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();
            cmbDanhMuc.Items.Clear();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                cmbDanhMuc.Items.Add(ma+"-"+ten);
            }
            reader.Close();
        }
        int madm = -1;
        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDanhMuc.SelectedIndex == -1) return;
            string line = cmbDanhMuc.SelectedItem.ToString();
            string[] arr = line.Split('-');
            madm = int.Parse(arr[0]);
            HienThiSanPhamTheoDanhMuc(madm);

        }
        
        private void HienThiSanPhamTheoDanhMuc(int madm)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.SanPham where Ma = @madm";
            command.Connection = conc;

            command.Parameters.Add("@madm", SqlDbType.Int).Value = madm;

            SqlDataReader reader = command.ExecuteReader();
            lvSanPham.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + "");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2)+"");

                lvSanPham.Items.Add(lvi);
            }
            reader.Close();


        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvSanPham.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            txtMa.Text = lvi.SubItems[0].Text;
            txtTen.Text = lvi.SubItems[1].Text;
            txtGia.Text = lvi.SubItems[2].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed) 
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "update dbo.SanPham set Ten = N'"+txtTen.Text+"' , DonGia= "+txtGia.Text+"  where Ma ="+txtMa.Text+"  ";
            command.CommandText = sql;
            command.Connection = conc;
            
            int ret = command.ExecuteNonQuery();
            if(ret > 0){
                HienThiSanPhamTheoDanhMuc(madm);
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "update dbo.SanPham set Ten=@ten, DonGia=@gia where Ma=@ma ";

            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = txtGia.Text;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text; 
            command.CommandText = sql;
            command.Connection = conc;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiSanPhamTheoDanhMuc(madm);
            }
        }
    }
}
