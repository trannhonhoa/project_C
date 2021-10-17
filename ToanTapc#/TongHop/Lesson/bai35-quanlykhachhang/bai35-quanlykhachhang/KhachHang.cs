using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai35_quanlykhachhang
{
    class KhachHang
    {
      
        const double GIA = 20000;
        public string ten { get; set; }
        public int soLuongMua { get; set; }
        public bool laSinhVien { get; set; }
        public double TinhTien{
            get{
                if (this.laSinhVien == true)
                    return soLuongMua * GIA * 0.95;
                else 
                    return soLuongMua * GIA;   
            }
        }
    }
}
