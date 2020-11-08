using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace LINQ_MS_SQL.Models
{
    [Table(Name = "TabStudents")]
    public class Student
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdStudent { get; set; }

        [Column(Name = "NameStudent")]
        public string NameStudent { get; set; }

        [Column(Name = "Sex")]
        public char Sex { get; set; }

        [Column(Name = "BallMath")]
        public int BallMath { get; set; }

        [Column(Name = "BallLang")]
        public int BallLang { get; set; }

        [Column(Name = "BallInf")]
        public int BallInf { get; set; }

        [Column(Name = "IdDirect")]
        public int IdDirect { get; set; }

        public int Balls => BallInf + BallLang + BallMath;
        public Student() { }
        public Student(params string[] attr)
        {
            IdStudent = int.Parse(attr[0]);
            NameStudent = attr[1];
            Sex = Convert.ToChar(attr[2]);
            BallMath = int.Parse(attr[3]);
            BallLang = int.Parse(attr[4]);
            BallInf = int.Parse(attr[5]);
            IdDirect = int.Parse(attr[6]);
        }
        public override string ToString()
        {
            return $"{IdStudent,4} {NameStudent,-12} {Sex} | {Balls,3} | {IdDirect,3}";
        }
    }
}
