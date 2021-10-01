using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSanpham
{
    public class DanhMuc
    {
        private Dictionary<string, SanPham> dssp = new Dictionary<string,SanPham>();
        public string Ma { get; set; }
        public string Ten { get; set;  }
        public void ThemSanPham(SanPham sp)
        {
            if (this.dssp.ContainsKey(sp.MaSP) == false)
            {

                this.dssp.Add(sp.MaSP, sp);
                sp.Nhom = this;
            }
        }
        public Dictionary<string, SanPham> SanPhams
        {
            get { return this.dssp;}
            set { this.dssp = value; }
        }
        public override string ToString()
        {
            return this.Ten;
        }
    }
}
