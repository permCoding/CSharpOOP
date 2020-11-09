using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabRab
{
    class Program
    {   
        static void task_8_SelectMany_test(Student[] students, Direct[] directions)
        {
            var groups = directions
                .SelectMany(d => students
                    .Select(s => new { s.Balls, s.IdDirect })
                    .Where(item => item.IdDirect == d.IdDirect)
                )
                .GroupBy(item => item.IdDirect);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group.Select(item => item.Balls))
                    Console.WriteLine(item);
            }
        }
        static dynamic task_8_SelectMany(Student[] students, Direct[] directions)
        {
            var groups = directions
                .SelectMany(d => students
                    .Select(s => new { s.Balls, s.IdDirect })
                    .Where(item => item.IdDirect == d.IdDirect)
                )
                .GroupBy(item => item.IdDirect);

            return directions
                .Join(
                    groups,
                    d => d.IdDirect,
                    g => g.Key,
                    (d, g) => new {
                        ND = d.NameDirect,
                        AVG = (double)g
                            .Select(item => item.Balls)
                            .OrderByDescending(item => item)
                            .Take(d.Limit)
                            .Sum() / d.Limit
                    }
                )
                .OrderByDescending(item => item.AVG);
        }
        static void task_8_Join_GroupBy_test(Student[] students, Direct[] directions)
        {
            var pairs = directions
                .Join(
                    students,
                    d => d.IdDirect,
                    s => s.IdDirect,
                    (d, s) => new { s.Balls, d.IdDirect }
                );

            foreach (var item in pairs)
                Console.WriteLine($"{item.IdDirect} {item.Balls}");
            foreach (var group in pairs.GroupBy(item => item.IdDirect))
            {
                Console.WriteLine(); // группируем по направлениям
                foreach (var item in group)
                    Console.WriteLine($"{item.IdDirect} {item.Balls}");
            }
        }
        static dynamic task_8_Join_GroupBy(Student[] students, Direct[] directions)
        {
            var groups = directions
                .Join(
                    students,
                    d => d.IdDirect,
                    s => s.IdDirect,
                    (d, s) => new { s.Balls, d.IdDirect }
                )
                .GroupBy(item => item.IdDirect); // группируем в списки по направлениям

            return directions
                .Join(
                    groups,
                    d => d.IdDirect,
                    g => g.Key,
                    (d, g) => new { 
                        ND = d.NameDirect, 
                        AVG = (double)g // каждая группа - это коллекция
                            .Select(item => item.Balls)
                            .OrderByDescending(item => item)
                            .Take(d.Limit)
                            .Sum() / d.Limit
                    } // вычисляем по направлениям
                )
                .OrderByDescending(item => item.AVG);
        }
        static dynamic task_8_GroupJoin(Student[] students, Direct[] directions)
        {
            return directions
                .GroupJoin(
                    students,
                    d => d.IdDirect,
                    s => s.IdDirect,
                    (d, s) => new {
                        ND = d.NameDirect,
                        AVG = (double)s
                            .Select(item => item.Balls)
                            .OrderByDescending(item => item)
                            .Take(d.Limit)
                            .Sum() / d.Limit
                    }
                )
                .OrderByDescending(item => item.AVG);
        }
        /*
            task_8 вывести названия направлений обучения, отсортировав их
            в порядке убывания по среднему баллу набранных абитуриентов 
            (те, которые уложились в лимит набора)
        */
        static void Main(string[] args)
        {
            Example.example_dynamic();

            #region get data students, directions
            var students = File
                .ReadAllLines("students.txt")
                .Skip(1)
                .Select(line => new Student(line.Split(';')))
                .ToArray();

            var directions = File
                .ReadAllLines("directions.txt")
                .Skip(1)
                .Select(line => new Direct(line.Split(';')))
                .ToArray();
            #endregion

            //task_8_SelectMany_test(students, directions);
            //task_8_Join_GroupBy_test(students, directions);

            //var result = task_8_SelectMany(students, directions);
            //var result = task_8_Join_GroupBy(students, directions);
            //var result = task_8_GroupJoin(students, directions);

            //foreach (var item in result)
            //    Console.WriteLine($"{item.AVG:f2} {item.ND}");

            Console.ReadLine();
        }
    }
}
