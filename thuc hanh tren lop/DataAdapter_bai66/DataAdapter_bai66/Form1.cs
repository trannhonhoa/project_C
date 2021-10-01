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
namespace DataAdapter_bai66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection conc = null;
        string strConc = "Server=DESKTOP-P9L00KA; Database=CSDLTest; User Id=sa; pwd=trannhonhoa";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void btnNapDuLieu_Click(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            adapter = new SqlDataAdapter("Select * from SanPham", conc);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            row["Ma"] = txtMa.Text;
            row["Ten"] = txtTen.Text;
            row["Dongia"] = txtDonGia.Text;
            row["MaDanhMuc"] = txtMaDM.Text;
            ds.Tables[0].Rows.Add(row);
            int kq = adapter.Update(ds.Tables[0]);
            if (kq > 0)
            {
                MessageBox.Show("Thanh Cong");
                btnNapDuLieu.PerformClick();
            }
        }

        
        int vt = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds.Tables[0].Rows[vt];
            txtMa.Text = row["Ma"].ToString();
            txtTen.Text= row["Ten"].ToString();
            txtDonGia.Text = row["DonGia"].ToString();
            txtMaDM.Text = row["MaDanhMuc"].ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].Rows[vt];
            row.BeginEdit();
            row["Ma"] = txtMa.Text;
            row["Ten"] = txtTen.Text;
            row["DonGia"] = txtDonGia.Text;
            row["MaDanhMuc"] = txtMaDM.Text;
            row.EndEdit();

            int kq = adapter.Update(ds.Tables[0]);
            if (kq > 0)
            {
                btnNapDuLieu.PerformClick();
                MessageBox.Show("Success");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].Rows[vt];
            row.Delete();
            int kq = adapter.Update(ds.Tables[0]);
            if (kq > 0)
            {
                btnNapDuLieu.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
