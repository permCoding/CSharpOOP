using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct
{
    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonClass(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public struct PersonStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
