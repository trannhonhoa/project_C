using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person : IComparable <Person>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person()
        {
            this.name = null;
            this.age = -1;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return "Name: " + name + "| Age: " + age;
        }

        
        public int CompareTo(Person other)
        {
            if (this.age < other.age)
            {
                return 1;
            }
            else if(this.age > other.age)
            {
                return 1;
            }
            return 0;
        }
       }

    }
