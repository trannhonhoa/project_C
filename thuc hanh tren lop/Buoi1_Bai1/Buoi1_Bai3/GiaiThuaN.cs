using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai3
{
    public class GiaiThuaN
    {
        public int InputNumber()
        {

            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public long Factorial(int n){
            long temp = 1;
            for(int i = 1; i<=n ;i++){
                temp = temp * i;
            }
            return temp;
        }
    }
}
