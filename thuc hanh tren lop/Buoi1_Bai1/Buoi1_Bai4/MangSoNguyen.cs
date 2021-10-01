using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai4
{
    public class MangSoNguyen
    {
        public int InputNumber()
        {
            int n;
            do
            {
                Console.Write("Input number:");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.Write("Number must greater than zero");
            } while (n <= 0);
            return n;
        }
        public void InputArray(int[]arr)
        {
            for(int i = 0; i < arr.Length; i++){
                Console.Write("a[{0}]: = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void OutputArray(int[] arr)
        {
            Console.Write("Quantity number in array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
                
            }
        }
        public int MaxElement(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public int MinElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

    }
}
