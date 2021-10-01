using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai5
{
    public class Student
    {
        private string Name {get; set;}
        private int Age {get; set;}
        private double MarkLiter {get; set;}
        private double MarkMath {get; set;}
        private double MarkAVG {
            get{
                return Math.Round(((MarkMath + MarkLiter) / 2), 2);
            }
        }
        public Student()
        {
        }
        public void InPutStudent()
        {
            Console.Write("Input Name: ");
            Name = Console.ReadLine();
            Console.Write("Input Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Input Mark Literature: ");
            MarkLiter = int.Parse(Console.ReadLine());
            Console.Write("Input Mark Math: ");
            MarkMath = int.Parse(Console.ReadLine());
        }
        public void OutputStudent()
        {
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}", Name, Age, MarkLiter, MarkMath, MarkAVG);
        }


    }
}
