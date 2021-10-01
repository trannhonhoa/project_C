using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon = 0;
            int loai = 5;
            TamGiac tg = new TamGiac();
            do
            {
                Console.WriteLine("1. Nhap tam giac");
                Console.WriteLine("2. Xuat tam giac");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("Moi nhap lua chon ");
                Console.WriteLine("---------------------");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        tg.Nhap();
                        loai = tg.TimTamGiac();

                        break;
                    case 2:
                        tg.Xuat();
                        tg.TimLoaiTG(loai);
                        break;

                }


            } while (chon != 0);
        }
    }
}
