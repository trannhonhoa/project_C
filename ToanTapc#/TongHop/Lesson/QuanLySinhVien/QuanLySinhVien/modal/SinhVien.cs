﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.modal
{
    public class SinhVien
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DateTime NamSinh { get; set; }
        public bool GioiTinh { get; set; }
        public LopHoc LopChuQuan { get; set; }
        public override string ToString()
        {
            return Ten;
        }
    }
}
