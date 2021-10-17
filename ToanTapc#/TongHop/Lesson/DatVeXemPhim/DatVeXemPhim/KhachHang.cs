using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVeXemPhim
{
    public class KhachHang
    {
        public string Name {get; set;}
        public string Phone { get; set; }
        public List<int> Ghes { get; set; }
        public KhachHang()
        {
            Ghes = new List<int>();
        }
        public int TinhTien
        {
            get
            {
                return Ghes.Count * 100000;
            }
        }
        public override string ToString()
        {
            return Name + "-" + Phone;
        }
        public DateTime GioDatGhe
        {
            get; set;
        }
    }
}
