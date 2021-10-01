using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimSLN maxNumber = new TimSLN();
            Console.Write("Input quantity number: ");
            int n = maxNumber.InputNumber();
            Console.WriteLine("Max number is: {0}", maxNumber.FindMax(n));
            Console.ReadLine();
        }
    }
}
