using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithListAndLinq
{
    class Person2
    {
        public string FullName { get; private set; }
        public int Age { get; private set; }

        public Person2(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
    }
}
