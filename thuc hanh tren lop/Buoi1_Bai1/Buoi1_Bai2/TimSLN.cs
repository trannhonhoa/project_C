using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai2
{
    public class TimSLN
    {
        public int InputNumber()
        {
            
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public int FindMax(int n){
            int max, i, temp;
            max = 0;
            i = 0;
            do
            {
                Console.Write("Input number {0} =", i + 1);
                temp = int.Parse(Console.ReadLine());
                if (max < temp)
                    max = temp;
                i++;
            } while (i < n);
            return max;
        }
    }
}
