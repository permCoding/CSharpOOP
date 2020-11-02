using CsvHelper;
using LINQCsv.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LINQCsv
{
    class Program
    {
        static void example_00() // ReadAllLines
        {
            string nameFile = "students.txt";

            //Console.WriteLine(File.ReadAllText(nameFile));

            string[] lines = File.ReadAllLines(nameFile);
            Console.WriteLine(String.Join("\n", lines));
        }
        static void example_01() // LINQ String.Join
        {
            string nameFile = "students.csv"; // или txt или csv
            var lines = File.ReadAllLines(nameFile);
            //var lines = Properties.Resources.students.Split('\n');

            var students = lines
                .Skip(1)
                .Select(item => new Student(item.Split(';')))
                .Where(item => item.Sex == 'м')
                .OrderBy(item => item.Balls)
                .Take(10);

            Console.WriteLine(String.Join('\n', students));
        }
        static void example_02() // StreamReader
        {
            string nameFile = "students.csv";
            string line = "";
            StreamReader sr = new StreamReader(nameFile);
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close(); // Close
        }
        static void example_03() // using StreamReader
        {
            string nameFile = "students.csv";
            string line = "";
            using (StreamReader sr = new StreamReader(nameFile))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        static void example_04() // CsvReader while
        {
            string nameFile = "students.csv";
            using (StreamReader sr = new StreamReader(nameFile))
            {
                using (CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture))
                {
                    cr.Configuration.HasHeaderRecord = true; // это по умолчанию
                    cr.Configuration.Delimiter = ";";
                    IEnumerable getEnum = cr.GetRecords<Student>();
                    IEnumerator getIn = getEnum.GetEnumerator();
                    while (getIn.MoveNext())
                    {
                        Console.WriteLine((Student)getIn.Current);
                    }
                }
            }
        }
        static void example_05() // CsvReader foreach
        {
            string nameFile = "students.csv";
            using (StreamReader sr = new StreamReader(nameFile))
            {
                using (CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture))
                {
                    cr.Configuration.Delimiter = ";";
                    cr.Configuration.MissingFieldFound = null;
                    foreach (var item in cr.GetRecords<Student>())
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
        static void example_06() // CsvReader LINQ
        {
            string nameFile = "students.csv";
            using (StreamReader sr = new StreamReader(nameFile))
            {
                using (CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture))
                {
                    cr.Configuration.Delimiter = ";";

                    var students = cr.GetRecords<Student>();

                    var filter = students
                        .Where(item => item.Sex == 'м')
                        .OrderByDescending(item => item.Balls)
                        .Take(10);

                    Console.WriteLine(String.Join('\n', filter));
                }
            }
        }
        static List<Student> example_06(string nameFile) // CsvReader LINQ return - для example_08
        {
            List<Student> students; // тут будет результат
            using (StreamReader sr = new StreamReader(nameFile))
            {
                using (CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture))
                {
                    cr.Configuration.Delimiter = ";";
                    students = cr.GetRecords<Student>()
                        .Where(item => item.Sex == 'м')
                        .OrderByDescending(item => item.Balls)
                        .Take(10)
                        .ToList();
                }
            }
            return students;
        }
        static void example_07_a() // read() GetRecord<Student>
        {
            string nameFile = "students.csv";
            using (StreamReader sr = new StreamReader(nameFile))
            {
                var cr = new CsvReader(sr, CultureInfo.CurrentCulture);
                cr.Configuration.Delimiter = ";";
                while (cr.Read())
                {
                    Student st = cr.GetRecord<Student>();
                    Console.WriteLine(st);
                }
                cr.Dispose();
            }
        }
        static void example_07_b() // read() GetField
        {
            string nameFile = "students.csv";
            using (StreamReader sr = new StreamReader(nameFile))
            {
                var cr = new CsvReader(sr, CultureInfo.CurrentCulture);
                cr.Read(); // это просто чтение заголовков
                cr.Configuration.Delimiter = ";";
                while (cr.Read())
                {
                    var id = cr.GetField<int>(0);
                    var name = cr.GetField<string>(1);
                    var sex = cr.GetField<char>(2);
                    var idGroup = cr.GetField<int>(6);
                    Console.WriteLine(
                        new Student(
                            id,
                            name,
                            sex,
                            cr.GetField<int>(3),
                            cr.GetField<int>(4),
                            cr.GetField<int>(5),
                            idGroup
                        )
                    );
                }
                cr.Dispose();
            }
        }
        static void example_08() // foreach WriteRecord
        {
            string inputFile = "students.csv";
            var filter = example_06(inputFile); // example_06(string)

            string outputFile = "result.csv";
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                using (CsvWriter cw = new CsvWriter(sw, CultureInfo.CurrentCulture))
                {
                    cw.Configuration.NewLine = CsvHelper.Configuration.NewLine.LF;
                    //cw.WriteHeader<Student>();
                    //cw.NextRecord();
                    foreach (var item in filter)
                    {
                        //cw.WriteRecord(item);
                        cw.WriteRecord(new { item.IdStudent, item.NameStudent, item.Sex, item.Balls, item.IdDirect });
                        cw.NextRecord();
                    }
                }
            }
        }
        static void example_09() // CsvReader EnumerateRecords
        {
            string nameFile = "students.csv";
            StreamReader sr = new StreamReader(nameFile);
            CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture);
            cr.Configuration.Delimiter = ";";
            var student = new Student();
            var students = cr.EnumerateRecords(student);

            //foreach (var item in students)
            //    Console.WriteLine((Student)item);

            Console.WriteLine(String.Join('\n', students));

            sr.Close(); cr.Dispose();
        }
        static void example_10() // CsvReader LINQ anonymousTypeDefinition
        {
            string nameFile = "directions.csv";
            StreamReader sr = new StreamReader(nameFile);
            CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture);
            cr.Configuration.Delimiter = ";";
            var anonymousTypeDefinition = new
            { //idDirect; NameDirect; minBall; limit
                idDirect = default(int),
                NameDirect = string.Empty,
                minBall = default(int),
                limit = default(int)
            };
            var records = cr.GetRecords(anonymousTypeDefinition);
            //foreach (var item in students)
            //    Console.WriteLine((Student)item);

            Console.WriteLine(String.Join('\n', records));

            sr.Close(); cr.Dispose();
        }
        static List<Student> GetStudents(string nameFile) // CsvReader LINQ return - для example_08
        {
            List<Student> students; // тут будет результат
            using (StreamReader sr = new StreamReader(nameFile))
            {
                using (CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture))
                {
                    cr.Configuration.Delimiter = ";";
                    students = cr.GetRecords<Student>().ToList();
                }
            }
            return students;
        }
        static void example_11() // CsvReader students directions LINQ
        {   // лучше всю эту работу проводить на стороне сервера через SQL
            List<Student> students = GetStudents("students.csv"); // получили всех студентов

            using (StreamReader sr = new StreamReader("directions.csv"))
            using (CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture))
            {
                cr.Configuration.Delimiter = ";";
                var directions = cr.GetRecords( // получили все направления
                    new { 
                        idDirect = default(int), 
                        NameDirect = string.Empty, 
                        minBall = default(int), 
                        limit = default(int) 
                    }
                );

                string find_group = "ИСб"; // сделали Запрос - только по этому направлению
                var query = directions
                    .Join(students
                        .Where(item => item.Sex == 'м'), // только муж
                        d => d.idDirect,
                        s => s.IdDirect,
                        (d, s) => new { ND = d.NameDirect, NS = s.NameStudent, B = s.Balls }) // анонимный тип
                    .Where(item => item.ND == find_group)
                    .OrderByDescending(item => item.B);
                foreach (var item in query)
                    Console.WriteLine($"{item.ND,5} {item.B,5} {item.NS,15}");
            }
        }
        static void Main()
        {
            //example_00();

            //example_01();

            //example_02();

            //example_03();

            //example_04();

            //example_05();

            //example_06();

            //example_07_a();
            //example_07_b();

            //example_08();

            //example_09();

            //example_10();

            example_11();

            Console.ReadLine();
        }
    }
}
