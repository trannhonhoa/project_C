using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            MangSoNguyen arrInt = new MangSoNguyen();
            int n = arrInt.InputNumber();
            int [] arr = new int[n];
            arrInt.InputArray(arr);
            arrInt.OutputArray(arr);
            Console.WriteLine("\nMax: {0}", arrInt.MaxElement(arr));
            Console.WriteLine("Min: {0} ", arrInt.MinElement(arr));
            Console.WriteLine("Sum: {0}", arrInt.Sum(arr));
            Console.WriteLine("Element in array after sort ");
            arrInt.Sort(arr);
            arrInt.OutputArray(arr);
            Console.ReadKey();

        }
    }
}
