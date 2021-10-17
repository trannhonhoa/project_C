using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_Bai4
{
    [Serializable]
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
    }
}
