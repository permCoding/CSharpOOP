using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQCsv.Models
{
    public interface IUnionType
    {

    }
    public class Student: IUnionType
    {
        //[Name("idStudent")] // так пишут атрибут, если нужно сменить имя поля
        public int IdStudent { get; set; }
        public string NameStudent { get; set; }
        public char Sex { get; set; }
        public int BallMath { get; set; }
        public int BallLang { get; set; }
        public int BallInf { get; set; }

        //[Name("idDirect")] // using CsvHelper.Configuration.Attributes;
        public int IdDirect { get; set; }
        public int Balls => BallInf + BallLang + BallMath;
        public Student()
        {

        }
        public Student(int idStudent, string nameStudent, char sex,
            int ballMath, int ballLang, int ballInf, int idDirect)
        {
            IdStudent = idStudent;
            NameStudent = nameStudent;
            Sex = sex;
            BallMath = ballMath;
            BallLang = ballLang;
            BallInf = ballInf;
            IdDirect = idDirect;
        }
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
            return $"{IdStudent,3} {NameStudent,-10}\t{Sex} | " +
                $"{BallMath,3} + {BallLang,3} + {BallInf,3} = {Balls,3} | {IdDirect,3}";
        }
    }
}
