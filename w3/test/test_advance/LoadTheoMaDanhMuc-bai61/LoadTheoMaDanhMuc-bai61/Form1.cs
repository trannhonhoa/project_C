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
namespace LoadTheoMaDanhMuc_bai61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conc = null;
        string strconc = "Server=DESKTOP-P9L00KA; Database=CSDLTest; User Id=sa; pwd=trannhonhoa";
        private void Form1_Load(object sender, EventArgs e)
        {
            if (conc == null)
                conc = new SqlConnection(strconc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.DanhMuc";
            command.Connection = conc;

            listDanhMuc.Items.Clear();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // tra ve kieu string
                string line = reader.GetInt32(0) + "-" + reader.GetString(1);
                listDanhMuc.Items.Add(line);
            }
            reader.Close();
        }

        private void listDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tra ve kieu string
            if (listDanhMuc.SelectedIndex == -1)
            {
                return;
            }
            
            string line = listDanhMuc.SelectedItem.ToString();
            string[] arr = line.Split('-');
            int madm = int.Parse(arr[0]);

            if (conc == null)
                conc = new SqlConnection(strconc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dbo.SanPham where MaDanhMuc = @madm";
            command.Connection = conc;

            SqlParameter parMaDanhMuc = new SqlParameter("@madm", SqlDbType.Int);
            parMaDanhMuc.Value = madm;

            command.Parameters.Add(parMaDanhMuc);

            lvSanPham.Items.Clear();
            SqlDataReader reader = command. ();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + "");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2)+"");

                lvSanPham.Items.Add(lvi);
            }
            reader.Close();

        }
    }
}
