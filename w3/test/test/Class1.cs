using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Class1
    {
        private string name;
        private int age;

        public int Age
        {
          get { return age; }
          set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Class1(string name, int age){
            this.name = name;
            this.age = age;
        }
    }
}
