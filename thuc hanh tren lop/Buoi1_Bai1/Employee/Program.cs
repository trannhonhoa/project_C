using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Quantity Employee: ");
            int n = int.Parse(Console.ReadLine());
            Employee [] arr = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input infor of employee {0}: ", i + 1);
                arr[i] = new Employee();
                arr[i].InputEmployee();
                Console.WriteLine("\n");
            }
            Console.WriteLine("List Employee");
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}", "ID", "Name", "Year of Birth","Salary", "InCome");
            for (int i = 0; i < n; i++)
            {
                arr[i].DisplayEmployee();
            }
            Console.ReadKey();
            
            
        }
    }
}
