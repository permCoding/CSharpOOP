using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLabRab
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string NameStudent { get; set; }
        public char Sex { get; set; }
        public int BallMath { get; set; }
        public int BallLang { get; set; }
        public int BallInf { get; set; }

        public int IdDirect { get; set; }
        public int Balls => BallInf + BallLang + BallMath;
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
    }
    public class Direct
    {
        public int IdDirect { get; set; }
        public string NameDirect { get; set; }
        public int MinBall { get; set; }
        public int Limit { get; set; }
        public Direct(params string[] attr)
        {
            IdDirect = int.Parse(attr[0]);
            NameDirect = attr[1];
            MinBall = int.Parse(attr[2]);
            Limit = int.Parse(attr[3]);
        }
    }
}
