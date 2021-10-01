using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai35_quanlykhachhang
{
    class DanhSachKhachHang
    {
        List<KhachHang> dskh = new List<KhachHang>();
        public List<KhachHang> Khachs
        {
            get { return dskh; }
        }
        public void Mua(KhachHang kh)
        {
            dskh.Add(kh);
        }
        public int TongSoKhachHang
        {
            get
            {
                return dskh.Count;
            }
        }
        public int TongSoKhachHangLaSinhVien
        {
            get
            {
                int sosinhvien = 0;
                foreach (KhachHang kh in dskh)
                {
                    if (kh.laSinhVien)
                    {
                        sosinhvien += 1;
                    }
                }
                return sosinhvien;
            }
        }
        public double TongDoanhThu
        {
            get
            {
                double Sum = 0;
                foreach (KhachHang kh in dskh)
                {
                    Sum += kh.TinhTien;
                }
                return Sum;
            }
        }
    }
}
