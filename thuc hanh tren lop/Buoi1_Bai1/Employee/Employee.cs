using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        private int ID {get; set;}
        private string Name { get; set; }
        private int yearOfBirth { get; set; }
        private double salaryLevel { get; set; }
        private double basicSalary { get; set; }
        public double GetIncome {
            get
            {
                return salaryLevel * basicSalary;
            }
        }
        public void InputEmployee()
        {
            Console.Write("ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Year of Birth: ");
            yearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Salary Level: ");
            salaryLevel = double.Parse(Console.ReadLine());
            Console.Write("Basic Salary: ");
            basicSalary = int.Parse(Console.ReadLine());
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}", ID, Name, yearOfBirth, basicSalary, GetIncome);
        }

    }
}
