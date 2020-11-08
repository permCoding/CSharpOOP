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
        static void task_8_GroupJoin()
        {
            var students = File
                .ReadAllLines("students.txt")
                .Skip(1)
                .Select(line => new Student(line.Split(';')));

            var directions = File
                .ReadAllLines("directions.txt")
                .Skip(1)
                .Select(line => new Direct(line.Split(';')));

            var filter = directions
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

            foreach (var item in filter)
                Console.WriteLine($"{item.AVG:f2} {item.ND}");
        }
        static void task_8_Join_GroupBy()
        {
            var students = File
                .ReadAllLines("students.txt")
                .Skip(1)
                .Select(line => new Student(line.Split(';')));

            var directions = File
                .ReadAllLines("directions.txt")
                .Skip(1)
                .Select(line => new Direct(line.Split(';')));

            var groups = directions
                .Join(
                    students,
                    d => d.IdDirect,
                    s => s.IdDirect,
                    (d, s) => new { s.Balls, d.IdDirect }
                )
                .GroupBy(item => item.IdDirect);

            var for_direct = directions
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

            foreach (var item in for_direct)
                Console.WriteLine($"{item.AVG:f2} {item.ND}");
        }
        static void task_8_SelectMany()
        {
            var students = File
                .ReadAllLines("students.txt")
                .Skip(1)
                .Select(line => new Student(line.Split(';')));

            var directions = File
                .ReadAllLines("directions.txt")
                .Skip(1)
                .Select(line => new Direct(line.Split(';')));

            var groups = directions
                .SelectMany(d => students
                    .Select(s => new { s.Balls, s.IdDirect })
                    .Where(item => item.IdDirect == d.IdDirect)
                )
                .GroupBy(item => item.IdDirect);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var item in group.Select(item => item.Balls))
            //        Console.WriteLine(item);
            //}

            var for_direct = directions
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

            foreach (var item in for_direct)
                Console.WriteLine($"{item.AVG:f2} {item.ND}");
        }

        static void Main(string[] args)
        {
            task_8_GroupJoin();
            Console.WriteLine();
            task_8_Join_GroupBy();
            Console.WriteLine();
            task_8_SelectMany();
            Console.ReadLine();
        }
    }
}
