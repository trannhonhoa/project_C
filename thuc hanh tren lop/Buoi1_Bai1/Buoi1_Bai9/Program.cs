using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh tinh Bieu thuc bac 2: ");
            Phuongtrinhbac2 pt1 = new Phuongtrinhbac2(2, 4, 1);
            pt1.TinhNghiem();
            Console.ReadKey();
        }
    }
}
