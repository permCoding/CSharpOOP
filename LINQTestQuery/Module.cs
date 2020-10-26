using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestQuery
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            return p1.Age > p2.Age ? 1 : -1;
        }
    }
    public class Student
    {
        public int IdSudent { get; set; }
        public string NameStudent { get; set; }
        public int IdGroup { get; set; }
        public Student(int idStudent, string name, int idGroup)
        {
            IdSudent = idStudent;
            NameStudent = name;
            IdGroup = idGroup;
        }
    }
    public class Group
    {
        public int IdGroup { get; set; }
        public string NameGroup { get; set; }
        public Group(int idGroup, string name)
        {
            IdGroup = idGroup;
            NameGroup = name;
        }
    }
}
