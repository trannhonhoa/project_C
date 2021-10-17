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
namespace QuanLyTrungTam_Bai78
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strConc = "Server=DESKTOP-P9L00KA; Database=CSDL_QLTT; User id = sa; pwd=trannhonhoa";
        SqlConnection conc = null;
        private void Openconnection()
        {
            if(conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
        }
        private void CloseConnection()
        {
            if (conc != null && conc.State == ConnectionState.Open)
                conc.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TaiTrungTam();
        }
        SqlCommand TaoCommand(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            SqlConnection conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
            command.Connection = conc;

            return command;
        }
        private void TaiTrungTam()
        {
            
            SqlCommand commandTT = TaoCommand("select * from CacTrungTam");
            SqlDataReader readerTT = commandTT.ExecuteReader();
            tvTrungTam.Nodes.Clear();
            while (readerTT.Read())
            {
                string matt = readerTT.GetString(0);
                string tentt = readerTT.GetString(1);
                TreeNode nodeTT = new TreeNode(tentt);
                nodeTT.Tag = matt;
                tvTrungTam.Nodes.Add(nodeTT);

                SqlCommand commandLop = TaoCommand("select * from Lop where MaTT='"+matt+"'");
                SqlDataReader readerLop = commandLop.ExecuteReader();
                while (readerLop.Read())
                {
                    string maLop = readerLop.GetString(0);
                    string tenLop = readerLop.GetString(1);
                    TreeNode nodeLop = new TreeNode(tenLop);
                    nodeLop.Tag = maLop;
                    nodeTT.Nodes.Add(nodeLop);

                    SqlCommand commandSV = TaoCommand("select * from SinhVien where MaLop='"+ maLop+"'");
                    
                    SqlDataReader readerSV = commandSV.ExecuteReader();
                    while (readerSV.Read())
                    {
                        string maSv = readerSV.GetString(0);
                        string tenSv = readerSV.GetString(1);
                        string sdt = readerSV.GetString(2);
                        TreeNode nodeSv = new TreeNode(tenSv);
                        nodeSv.Tag = maSv;
                        nodeLop.Nodes.Add(nodeSv);
                    }
                    readerSV.Close();
                }
                readerLop.Close();
                
            }
            readerTT.Close();
        }

        private void tvTrungTam_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Level == 0)
                {
                    string matt = e.Node.Tag.ToString();
                    HienThiLopLenListView(matt);
                }
                else if (e.Node.Level == 1)
                {
                    string malop = e.Node.Tag.ToString();
                    HienThiSinhVienLenListView(malop);
                }
            }
        }

        private void HienThiSinhVienLenListView(string malop)
        {
            lvData.Items.Clear();
            lvData.Columns.Clear();
            lvData.Columns.Add("Ma SV", 100);
            lvData.Columns.Add("Ten SV", 300);
            lvData.Columns.Add("SDT", 150);
            conc = new SqlConnection(strConc);
            Openconnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SinhVien where MaLop='"+ malop+"'";
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                string sdt = reader.GetString(2);
                ListViewItem lvi = new ListViewItem(ma);
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(sdt);
                lvData.Items.Add(lvi);
            }
            reader.Close();
        }

        private void HienThiLopLenListView(string matt)
        {
            lvData.Items.Clear();
            lvData.Columns.Clear();
            lvData.Columns.Add("Ma Lop", 100);
            lvData.Columns.Add("Ten Lop", 300);
            conc = new SqlConnection(strConc);
            Openconnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Lop where MaTT='"+matt+"'";
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                ListViewItem lvi = new ListViewItem(ma);
                lvi.SubItems.Add(ten);

                lvData.Items.Add(lvi);
            }
            reader.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Openconnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SinhVien where TenSV like @ten";
            command.Connection = conc;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = "%"+txtTen.Text+"%";
            SqlDataReader reader = command.ExecuteReader();
            lvData.Items.Clear();
            lvData.Columns.Clear();
            lvData.Columns.Add("Ma SV", 100);
            lvData.Columns.Add("Ten SV", 300);
            lvData.Columns.Add("SDT", 150);
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                string sdt = reader.GetString(2);
                ListViewItem lvi = new ListViewItem(ma);
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(sdt);
                lvData.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
