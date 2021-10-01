using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimSoLonNhat maxNumber = new TimSoLonNhat();
            int a, b, c, max;
            Console.Write("Input first number: ");
            a = maxNumber.InputNumber();
            Console.Write("Input seconds number: ");
            b = maxNumber.InputNumber();
            Console.Write("Input third number: ");
            c = maxNumber.InputNumber();
            max = maxNumber.FindMax(a, b, c);
            Console.WriteLine("Max number is: {0}", max);
            Console.ReadKey();
        }
    }
}
