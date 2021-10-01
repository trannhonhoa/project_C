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
namespace ProjectTongHop_Bai69
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conc = null;
        string strConc = "Server=DESKTOP-P9L00KA; Database=CSDL_QLKH; User Id=sa; pwd=trannhonhoa";
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiToanBoKhachHang();
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
        private void HienThiToanBoKhachHang()
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from dbo.KhachHang";
                command.Connection = conc;

                SqlDataReader reader = command.ExecuteReader();
                lvKhachhang.Items.Clear();
                lvKhachhang.Groups.Clear();
                ListViewGroup lvgVip = new ListViewGroup("Khach Hang Vip");
                lvKhachhang.Groups.Add(lvgVip);
                ListViewGroup lvgThuong = new ListViewGroup("Khach Hang thuong");
                lvKhachhang.Groups.Add(lvgThuong);
                while (reader.Read())
                {
                    int ma = reader.GetInt32(0);
                    string ten = reader.GetString(1);
                    int gioitinh = reader.GetInt32(2);
                    string phone = reader.GetString(3);
                    string loaiKH = reader.GetString(4);
                    ListViewItem lvi = new ListViewItem(lvKhachhang.Items.Count+1+"");
                    lvi.SubItems.Add(ma+"");
                    lvi.SubItems.Add(ten);
                    lvi.SubItems.Add(gioitinh == 0 ? "Name" : "Nu");
                    lvi.SubItems.Add(phone);
                  

                    lvKhachhang.Items.Add(lvi);

                    if (string.Compare(loaiKH, "VIP", true) == 0)
                    {
                        lvi.Group = lvgVip;
                    }
                    else
                    {
                        lvi.Group = lvgThuong;
                    }
                    if (gioitinh == 0)
                    {
                        lvi.ImageIndex = 2;
                    }
                    else if (gioitinh == 1)
                    {
                        lvi.ImageIndex = 6;
                    }
                    lvi.Tag = ma;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachhang.SelectedItems.Count == 0) return;
            {
                ListViewItem lvi = lvKhachhang.SelectedItems[0];

                int ma = (int)lvi.Tag;
                HienThiThongTinChiTietKhachHang(ma);
            }
        }
        private void HienThiThongTinChiTietKhachHang(int ma)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from KhachHang where Ma=@ma";
                command.Connection = conc;
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string ten = reader.GetString(1);
                    int gioitinh = reader.GetInt32(2);
                    string phone = reader.GetString(3);
                    string loaiKh = reader.GetString(4);

                    txtMa.Text = ma + "";
                    txtTen.Text = ten;
                    if (gioitinh == 0)
                        rdNam.Checked = true;
                    else
                        rdNu.Checked = true;
                    txtPhone.Text = phone;
                    if (string.Compare(loaiKh, "VIP", true) == 0)
                    {
                        cmbLoaiKH.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbLoaiKH.SelectedIndex = 1;
                    }

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtPhone.Text = "";
            cmbLoaiKH.SelectedIndex = -1;
            txtMa.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") return;
            int ma = int.Parse(txtMa.Text);
            if (KiemhTraTonTai(ma) == true)
            {
                CapNhatKhachHang(ma);
            }
            else
            {
                ThemMoiKhacHang();
            }
        }
        private void CapNhatKhachHang(int ma)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Update KhachHang Set ten=@ten, gioitinh=@gioitinh, phone=@phone, loaiKh=@loaiKh where Ma = @ma";
                command.Connection = conc;

                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
                command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text;
                command.Parameters.Add("@gioitinh", SqlDbType.Int).Value = rdNam.Checked ? 1 : 0;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = txtPhone.Text;
                command.Parameters.Add("@loaiKh", SqlDbType.NVarChar).Value = cmbLoaiKH.Text;

                int ret = command.ExecuteNonQuery();

                if (ret > 0)
                {
                    HienThiToanBoKhachHang();
                    btnTaoMoi.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ThemMoiKhacHang()
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql = "insert into KhachHang values(@ma, @ten, @gioitinh, @phone, @loaiKh)";
                command.CommandText = sql;
                command.Connection = conc;

                command.Parameters.Add("@ma", SqlDbType.Int).Value = txtMa.Text;
                command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text;
                command.Parameters.Add("@gioitinh", SqlDbType.Int).Value = rdNam.Checked ? 1 : 0;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = txtPhone.Text;
                command.Parameters.Add("@loaiKh", SqlDbType.NVarChar).Value = cmbLoaiKH.Text;

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Succes");
                    HienThiToanBoKhachHang();
                    btnTaoMoi.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool KiemhTraTonTai(int ma)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from KhachHang where Ma=@ma";
                command.Connection = conc;
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;

                SqlDataReader reader = command.ExecuteReader();

                bool kq = reader.Read();

                reader.Close();

                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvKhachhang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ban Chua Chon");
                return;
            }
            ListViewItem lvi = lvKhachhang.SelectedItems[0];
            int ma = int.Parse(lvi.SubItems[0].Text);
            DialogResult dia = MessageBox.Show("Are you sure!","Xac nhan xoa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dia == DialogResult.OK){
                try
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "delete from KhachHang where Ma=@ma";
                    command.Connection = conc;
                    command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;

                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        HienThiToanBoKhachHang();
                        btnTaoMoi.PerformClick();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmInan frm = new frmInan();
            frm.Show();
        }

       
    }
}
