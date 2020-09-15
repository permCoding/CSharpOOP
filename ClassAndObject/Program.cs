using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }
        public string Name { get; set; }
        public Person() { }
        public Person(string name)
        {
            Name = name;
        }
        public void PrintPerson()
        {
            Console.WriteLine($"{this.Age}\t{this.Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person men1 = new Person();
            men1.Age = 33;
            Person men2 = new Person("Вася");
            men2.Age = 22;

            men1.PrintPerson();
            men2.PrintPerson();

            Console.ReadLine();
        }
    }
}
