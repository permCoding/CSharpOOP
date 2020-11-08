using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using Student = LINQ_MS_SQL.Models.Student;

namespace LINQ_MS_SQL
{
    class Program
    {
        static string connectionString =
            @"Server=localhost\SQLEXPRESS; Database=Abitura; Trusted_Connection=True;";
        static void CheckConnection()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    Console.WriteLine("Success");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void CreateTable()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"CREATE TABLE TabStudents(" +
                        $"IdStudent INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                        $"NameStudent VARCHAR(20) NOT NULL, " +
                        $"Sex CHAR(1) NOT NULL, " +
                        $"BallMath INT NOT NULL, " +
                        $"BallLang INT NOT NULL, " +
                        $"BallInf INT NOT NULL, " +
                        $"IdDirect INT NOT NULL)";
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void SelectTableStudents()
        {
            try
            {
                DataContext dc = new DataContext(connectionString);
                Table<Student> students = dc.GetTable<Student>();
                Console.WriteLine(String.Join("\n", students));
                Console.WriteLine($"count = {students.Count()}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void DeleteAll()
        {
            DataContext db = new DataContext(connectionString);
            int deletedRowsNumber = db.ExecuteCommand("DELETE FROM TabStudents");
            Console.WriteLine(deletedRowsNumber);
        }
        static void DeleteWhere()
        {
            DataContext db = new DataContext(connectionString);
            db.ExecuteCommand("DELETE FROM TabStudents WHERE IdStudent={0}", 9);
        }
        static void InsertIntoTableOneStudentSQL(Student student)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                { // IdStudent;NameStudent;Sex;BallMath;BallLang;BallInf;IdDirect
                    conn.Open();
                    string sql = $"INSERT INTO TabStudents (NameStudent, Sex, BallMath, BallLang, BallInf, IdDirect) " +
                        $"VALUES ('{student.NameStudent}', '{student.Sex}', {student.BallMath}, " +
                        $"{student.BallLang}, {student.BallInf}, {student.IdDirect})";
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void InsertIntoTableOneStudentSQLParams(Student student)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"INSERT INTO TabStudents (NameStudent, Sex, BallMath, BallLang, BallInf, IdDirect) " +
                        $"VALUES (@name, @sex, @math, @lang, @inf, @dir)";
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;

                    SqlParameter p_name = new SqlParameter("@name", SqlDbType.VarChar)
                    {
                        Value = student.NameStudent
                    };
                    SqlParameter p_sex = new SqlParameter("@sex", SqlDbType.Char)
                    {
                        Value = student.Sex
                    };
                    SqlParameter p_math = new SqlParameter("@math", SqlDbType.Int)
                    {
                        Value = student.BallMath
                    };
                    SqlParameter p_lang = new SqlParameter("@lang", SqlDbType.Int)
                    {
                        Value = student.BallLang
                    };
                    SqlParameter p_inf = new SqlParameter("@inf", SqlDbType.Int)
                    {
                        Value = student.BallInf
                    };
                    SqlParameter p_dir = new SqlParameter("@dir", SqlDbType.Int)
                    {
                        Value = student.IdDirect
                    };
                    SqlParameter[] pars = new SqlParameter[]
                        { p_name, p_sex, p_math, p_lang, p_inf, p_dir };
                    cmd.Parameters.AddRange(pars);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void InsertIntoTableOneStudentLINQ(Student student)
        {
            try
            {
                DataContext dc = new DataContext(connectionString);
                dc.GetTable<Student>().InsertOnSubmit(student);
                dc.SubmitChanges();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void InsertIntoTableAllStudentLINQ(Student[] students)
        {
            try
            {
                DataContext dc = new DataContext(connectionString);
                dc.GetTable<Student>().InsertAllOnSubmit(students);
                dc.SubmitChanges();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
        static Student[] GetStudentsFromTxt()
        {
            return File
                .ReadAllLines("students.txt")
                .Skip(1)
                .Select(line => new Student(line.Split(';')))
                .ToArray();
        }
        static void UpdateLINQ()
        {
            DataContext dc = new DataContext(connectionString);
            var filter = dc
                .GetTable<Student>()
                .Where(st => st.IdStudent == 213)
                .FirstOrDefault();
            if (filter != null)
            {
                filter.Sex = filter.Sex == 'м' ? 'ж' : 'м';
                dc.SubmitChanges();
            }
        }
        static void UpdateLINQLast()
        {
            DataContext dc = new DataContext(connectionString);
            var filter = dc
                .GetTable<Student>()
                .OrderByDescending(st => st.IdStudent)
                .FirstOrDefault();
            if (filter != null)
            {
                filter.Sex = filter.Sex == 'м' ? 'ж' : 'м';
                dc.SubmitChanges();
            }
        }
        static void UpdateLINQWhere()
        {
            DataContext dc = new DataContext(connectionString);
            var filter = dc
                .GetTable<Student>()
                .Where(st => st.Sex == 'ж');
            foreach (var item in filter)
                item.Sex = 'Ж';
            dc.SubmitChanges();
        }
        static void Main(string[] args)
        {
            //CheckConnection();

            //CreateTable();

            //DeleteAll();

            //DeleteWhere();

            #region варианты реализации insert`s
            //var students = GetStudentsFromTxt();
            //Console.WriteLine(students.Count());

            //foreach (var student in students)
            //{
            //    //InsertIntoTableOneStudentSQLParams(student);
            //    //InsertIntoTableOneStudentSQL(student);
            //    //InsertIntoTableOneStudentLINQ(student);
            //}

            //InsertIntoTableAllStudentLINQ(students);
            #endregion

            //UpdateLINQ();

            //UpdateLINQLast();

            //UpdateLINQWhere();

            SelectTableStudents();

            Console.ReadLine();
        }
    }
}
