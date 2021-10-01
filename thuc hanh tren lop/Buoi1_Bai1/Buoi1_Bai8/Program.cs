using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai8
{
    class Program
    {
        static void Main(string[] args)
        
        {
            
            Console.Write("Nhap vao so luong tam giac: ");
            int n = int.Parse(Console.ReadLine());
            TamGiac[] arr = new TamGiac[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Nhap thong tin tam giac thu {0}: ", i + 1);
                arr[i] = new TamGiac();
                arr[i].NhapTamGiac();
                Console.WriteLine("\n");
            }
            Console.WriteLine("List Tam giac");
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, 15}", "Canh1", "Canh2", "Canh3", "Chu vi", "Dien tich", "Loai Tam Giac");
            for (int i = 0; i < n; i++)
            {
                arr[i].HienThiTamGiac();
            }
            Console.ReadKey();
        }
    }
}
