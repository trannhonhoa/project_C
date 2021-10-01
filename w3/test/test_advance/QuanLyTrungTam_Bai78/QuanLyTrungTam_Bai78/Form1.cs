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
            if (conc == null)
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
            command.Connection = conc;

            return command;
        }
        private void TaiTrungTam()
        {
            Openconnection();
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

                SqlCommand commandLop = TaoCommand("select * from Lop where MaTT="+matt);
                SqlDataReader readerLop = commandLop.ExecuteReader();
                while (readerLop.Read())
                {
                    string maLop = readerLop.GetString(0);
                    string tenLop = readerLop.GetString(1);
                    TreeNode nodeLop = new TreeNode(tenLop);
                    nodeLop.Tag = maLop;
                    nodeTT.Nodes.Add(nodeLop);
                }
            }
            readerTT.Close();
        }
    }
}
