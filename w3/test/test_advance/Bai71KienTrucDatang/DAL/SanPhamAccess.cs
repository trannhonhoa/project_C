using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class SanPhamAccess:DatabaseAccess
    {
        public List<SanPham> LayToanBoSanPham()
        {
            List<SanPham> dssp = new List<SanPham>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham";
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                int madm = reader.GetInt32(3);

                SanPham sp = new SanPham();
                sp.MaSP = ma;
                sp.TenSP = ten;
                sp.DonGia = gia;
                sp.MaDM = madm;

                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }
        public bool XoaSanPham(int ma){
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from SanPham where MaSP = @ma";
            command.Connection = conc;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            int ret = command.ExecuteNonQuery();
            return ret > 0;

       }
        public bool ThemSanPham(SanPham sp)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into SanPham Values(@ma, @ten, @gia, @madm)";
            command.Connection = conc;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = sp.MaSP;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = sp.TenSP;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = sp.DonGia;
            command.Parameters.Add("@madm", SqlDbType.Int).Value = sp.MaDM;

            int ret = command.ExecuteNonQuery();
            return ret > 0;
        }
    }
}
