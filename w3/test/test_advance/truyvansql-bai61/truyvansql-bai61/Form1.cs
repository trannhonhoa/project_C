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
namespace truyvansql_bai61
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
        SqlConnection conc = null;

        string sqlConc = "Server=DESKTOP-P9L00KA; Database=CSDLTest; User Id=sa; pwd=trannhonhoa";
        private void btnDemsosanpham_Click(object sender, EventArgs e)
        {
            if (conc == null)
            {
                conc = new SqlConnection(sqlConc);
            }
            if (conc.State == ConnectionState.Closed)
            {
                conc.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(*) from dbo.SanPham";
            command.Connection = conc;

            object data = command.ExecuteScalar();
            int n = (int)data;
            lblSoSanPham.Text = "Co" + n + "San Pham"; 
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (conc == null)
            {
                conc = new SqlConnection(sqlConc);
            }
            if (conc.State == ConnectionState.Closed)
            {
                conc.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.SanPham where Ma=" + txtChiTiet.Text;
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                MessageBox.Show(ma + " " + ten + " " + gia);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conc == null)
            {
                conc = new SqlConnection(sqlConc);
            }
            if (conc.State == ConnectionState.Closed)
            {
                conc.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.SanPham where Ma=@ma";
            command.Connection = conc;

            SqlParameter parma = new SqlParameter("@ma", SqlDbType.Int);
            parma.Value = txtChiTiet.Text;
            command.Parameters.Add(parma);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                MessageBox.Show(ma + " " + ten + " " + gia);
            }
            
        }

        private void btnHienThiSanPham_Click(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(sqlConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.SanPham";
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0)+"");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + "");

                listView1.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
