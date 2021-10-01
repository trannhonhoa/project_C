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
    public class SanPhamAccess:DataBaseAccess
    {
        public List<SanPham> LayToanBoSanPham()
        {
            List<SanPham> dssp = new List<SanPham>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham";
            command.Connection = conc;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                int madm = reader.GetInt32(3);

                SanPham sp = new SanPham();
                sp.MaDM = ma;
                sp.TenSp = ten;
                sp.DonGia = gia;
                sp.MaDM = madm;
                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }
    }
}
