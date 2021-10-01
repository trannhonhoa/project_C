using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai1
{
    class TimSoLonNhat
    {
        public int InputNumber()
        {
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public int FindMax(int a, int b, int c)
        {
            int max;
            max = a > b ? a : b;
            max = max > c ? max : c;
            return max;
        }
    }
}
