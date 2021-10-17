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
namespace QuanLySinhVien_Bai79
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conc = null;
        string strConc = "Server=DESKTOP-P9L00KA; Database=CSDL_QLSV; User Id=sa; pwd=trannhonhoa";
        private void Form1_Load(object sender, EventArgs e)
        {
            NapDuLieuMenu();
        }
        private void OpenConnection()
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
        private void NapDuLieuMenu()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Lop";
            command.Connection = conc;
            
            SqlDataReader reader = command.ExecuteReader();
            menuDanhSachLop.DropDownItems.Clear();
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Tat ca cac lop");
            menuItem.Tag = "all";
            menuItem.Click += menuItem_Click;
            menuDanhSachLop.DropDownItems.Add(menuItem);
            while (reader.Read())
            {
                string maLop = reader.GetString(0);
                string tenLop = reader.GetString(1);
                menuItem = new ToolStripMenuItem(tenLop);
                menuItem.Tag = maLop;
                menuItem.Click += menuItem_Click;
                menuDanhSachLop.DropDownItems.Add(menuItem);
            }
            reader.Close();
        }
        ToolStripMenuItem menuPrevous = null;
        void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuItem.Checked = !menuItem.Checked;
            if (menuPrevous != null)
                menuPrevous.Checked = false;
            menuPrevous = menuItem;
            string ma = menuItem.Tag.ToString();
            if (ma == "all")
            {
                HienThiToanBoLop();
            }
            else
            {
                HienThiSinhVienTheoLop(ma);
            }
        }

        private void HienThiSinhVienTheoLop(string maSV)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from HocSinh where Malop='" + maSV + "'";
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();
            lvSinhVien.Items.Clear();
            lvSinhVien.Groups.Clear();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                var stt = 1;
                ListViewItem lvi = new ListViewItem(stt + "");
                lvi.SubItems.Add(ma);
                lvi.SubItems.Add(ten);
                lvSinhVien.Items.Add(lvi);
                stt++;
                


            }
            reader.Close();
        }

        

        private void HienThiToanBoLop()
        {
            OpenConnection();
            SqlCommand commandLop = new SqlCommand();
            commandLop.CommandType = CommandType.Text;
            commandLop.CommandText = "Select * from Lop";
            commandLop.Connection = conc;
            SqlDataReader readerLop = commandLop.ExecuteReader();
            lvSinhVien.Items.Clear();
            lvSinhVien.Groups.Clear();

            while (readerLop.Read())
            {
                ListViewGroup lvg = new ListViewGroup(readerLop.GetString(1));
                lvg.Tag = readerLop.GetString(0);
                lvSinhVien.Groups.Add(lvg);
            }
            readerLop.Close();
            foreach(ListViewGroup lvg in lvSinhVien.Groups)
            {
                string maLop = lvg.Tag.ToString();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from HocSinh where Malop='"+maLop+"'";
                command.Connection = conc;

                SqlDataReader reader = command.ExecuteReader();
                var stt = 1;
                while (reader.Read())
                {
                    string ma = reader.GetString(0);
                    string ten = reader.GetString(1);
                   
                    ListViewItem lvi = new ListViewItem(stt +"");
                    lvi.SubItems.Add(ma);
                    lvi.SubItems.Add(ten);
                    lvSinhVien.Items.Add(lvi);
                    stt++;
                    lvi.Group = lvg;

                  
                }
                reader.Close();
            }
        }
    }
}
