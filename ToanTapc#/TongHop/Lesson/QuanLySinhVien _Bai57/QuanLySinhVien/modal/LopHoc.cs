using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.modal
{
    [Serializable]
    public class LopHoc
    {
        
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string GiaoVienCoVan { get; set; }
        public Dictionary<string, SinhVien> SinhViens { get; set; }
        public LopHoc()
        {
            SinhViens = new Dictionary<string, SinhVien>();
        }
        public override string ToString()
        {
            return TenLop;
        }
        public Khoa KhoaChuQuan { get; set; }
    }
}
