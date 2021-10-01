using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timenow = DateTime.Now;
            ThoiGian t1 = new ThoiGian();
            t1.Hien();
            Console.WriteLine("\n");
            ThoiGian t2 = new ThoiGian(27, 9, 2021, 10, 10, 10);
            t2.Hien();
            Console.WriteLine("\n");
            ThoiGian t3 = new ThoiGian(27, 9, 2021);
            t3.Hien();
            Console.WriteLine("\n");
            ThoiGian t4 = new ThoiGian(t3);
            t4.Hien();
            Console.WriteLine("\n");
            ThoiGian t5 = new ThoiGian(timenow);
            t5.Hien();
            Console.ReadKey();
        }
    }
}
