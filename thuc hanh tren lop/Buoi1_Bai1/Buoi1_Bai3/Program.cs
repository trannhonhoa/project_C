using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            GiaiThuaN fac = new GiaiThuaN();
            Console.Write("Input Number: ");
            int n = fac.InputNumber();
            Console.WriteLine("Factorial {0} ! = {1}", n, fac.Factorial(n));
            Console.ReadKey();
        }
    }
}
