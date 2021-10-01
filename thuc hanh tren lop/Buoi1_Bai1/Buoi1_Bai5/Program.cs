using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nInput quantity student: ");
            int n = int.Parse(Console.ReadLine());
            Student[] arrStd = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input infor of student {0}: ", i + 1);
                arrStd[i] = new Student();
                arrStd[i].InPutStudent();
                Console.WriteLine("\n");
            }
            Console.WriteLine("List student");
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}", "Name", "Age", "Literature", "Math", "Mark AVG");
            for (int i = 0; i < n; i++)
            {
                arrStd[i].OutputStudent();
            }
            Console.ReadKey();
        }
    }
}
