using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestQuery
{
    class Program
    {
        public static void example_00() // сравним SELECT - синтаксис ЗАПРОСА и МЕТОДА
        {
            string[] colors = new string[] { "red", "green", "blue", "dark", "yellow" };

            var query1 = colors.Select(color => color.Length); // синтаксис метода расширения
            var query2 = from color in colors // синтаксис запроса
                         select color.Length;

            Console.WriteLine(String.Join(" ", query1));
            Console.WriteLine(String.Join(" ", query2));
        }
        public static void example_01() // 01 строку в массив целых чисел
        {
            string line = "1 5 7 3 9";
            int[] arr = line
                .Split(' ')
                .Select(item => int.Parse(item))
                .ToArray();
            string result = String.Join(" ", arr);
            Console.WriteLine(result);
        }
        public static void example_02() // 02 строку в список целых чисел
        {
            string line = "1 5 7 3 9";
            List<int> arr = line
                .Split(' ')
                .Select(item => int.Parse(item))
                .ToList();
            string result = String.Join(" ", arr);
            Console.WriteLine(result);
        }
        public static void example_03() // 03 строку в массив целых чисел через Convert
        {
            string line = "1 5 7 3 9";
            int[] arr = line
                .Split(' ')
                .Select(item => Convert.ToInt32(item))
                .ToArray();
            string result = String.Join(" ", arr);
            Console.WriteLine(result);
        }
        public static void example_04_yield()
        {
            foreach (int value in GetNextOddValue())
            {
                Console.WriteLine(value);
            }
        }
        public static IEnumerable<int> GetNextOddValue(int a = 1, int b = 10)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                    yield return i;
            }
        }
        public static void example_04() // 04 строку в перечислитель + for
        {
            string line = "1 5 7 3 9";
            IEnumerable<int> ienum = line
                .Split(' ')
                .Select(item => int.Parse(item));
            string result = "";
            foreach (var item in ienum)
            {
                result += item + " ";
            }
            Console.WriteLine(result);
        }
        public static void example_05() // 05 строку в перечислитель + while
        {
            string line = "1 5 7 3 9";
            IEnumerable<int> ienum = line
                .Split(' ')
                .Select(item => int.Parse(item));
            string result = "";
            IEnumerator<int> ietor = ienum.GetEnumerator();
            while (ietor.MoveNext())
            {
                result += ietor.Current.ToString() + " ";
            }
            Console.WriteLine(result);
        }
        public static void example_06() // 06 массив строк в список объектов через for
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            List<Person> persons = new List<Person>();
            foreach (var line in lines)
            {
                Person person = new Person(
                    line.Split(seps)[0],
                    Convert.ToInt32(line.Split(seps)[1]));
                persons.Add(person);
            }
            foreach (var item in persons)
                Console.WriteLine($"{item.Age}\t{item.Name}");
        }
        public static void example_07() // 07 массив строк в список объектов через Select
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            List<Person> persons = lines
                .Select(line => new Person(line.Split(seps)[0], Int32.Parse(line.Split(seps)[1])))
                .ToList();
            foreach (var item in persons)
                Console.WriteLine($"{item.Age}\t{item.Name}");
        }
        public static void example_08() // 08 сортировка массива чисел Array
        {
            string line = "9 5 7 1 3";
            int[] arr = line
                .Split(' ')
                .Select(item => int.Parse(item))
                .ToArray();
            Array.Sort(arr);  //Array.Sort(arr, 0, 2);  Array.Reverse(arr);
            string result = String.Join(" ", arr);
            Console.WriteLine(result);
        }
        public static void example_09() // 09 сортировка массива объектов компаратором
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            Person[] persons = lines
                .Select(line => new Person(line.Split(seps)[0], Int32.Parse(line.Split(seps)[1])))
                .ToArray();
            AgeComparer ag = new AgeComparer();
            Array.Sort(persons, ag);
            foreach (var item in persons)
                Console.WriteLine($"{item.Age}\t{item.Name}");
        }
        public static void example_10() // 10 сортировка списка объектов компаратором
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            List<Person> persons = lines
                .Select(line => new Person(line.Split(seps)[0], Int32.Parse(line.Split(seps)[1])))
                .ToList();
            AgeComparer ag = new AgeComparer();
            persons.Sort(ag);
            foreach (var item in persons)
                Console.WriteLine($"{item.Age}\t{item.Name}");
        }
        public static void example_11() // 11 сортировка списка объектов LINQ
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            List<Person> persons = lines
                .Select(line => new Person(line.Split(seps)[0], Int32.Parse(line.Split(seps)[1])))
                .ToList();
            foreach (var item in persons.OrderBy(item => item.Age))  // OrderByDescending
                Console.WriteLine($"{item.Age}\t{item.Name}");
        }
        public static void example_12() // 12 сортировка списка объектов LINQ по двум параметрам
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            List<Person> persons = lines
                .Select(line => new Person(line.Split(seps)[0], Int32.Parse(line.Split(seps)[1])))
                .ToList();
            persons = persons
                .OrderBy(item => item.Age)
                .ThenByDescending(item => item.Name)
                .ToList();
            foreach (var item in persons)
                Console.WriteLine($"{item.Age}\t{item.Name}");
        }
        public static void example_13() // 13 группировка списка объектов по параметру
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            List<Person> persons = lines
                .Select(line => new Person(line.Split(seps)[0], Int32.Parse(line.Split(seps)[1])))
                .ToList();
            var grouping = persons
                .GroupBy(item => item.Age)
                .OrderBy(item => item.Key);
            foreach (var item in grouping)
                Console.WriteLine($"{item.Key}\t{item.Count()}");
        }
        public static void example_14() // 14 группировка списка объектов по параметру с выводом
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            List<Person> persons = lines
                .Select(line => new Person(line.Split(seps)[0], Int32.Parse(line.Split(seps)[1])))
                .ToList();
            var grouping = persons
                .GroupBy(item => item.Age)
                .OrderBy(item => item.Key);
            var group = grouping
                .Select(item =>
                    new { Age = item.Key, Count = item.Count(), Names = item.Select(a => a.Name) }
                );
            foreach (var item in group)
                Console.WriteLine($"age={item.Age} - count={item.Count}; {String.Join(", ", item.Names)}");
        }
        public static void example_15() // 15 группировка списка объектов в словарь
        {
            string text = Properties.Resources.data;
            string[] lines = text.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|' };
            List<Person> persons = lines
                .Select(line => new Person(line.Split(seps)[0], Int32.Parse(line.Split(seps)[1])))
                .ToList();
            var grouping_dict = persons.ToLookup(item => item.Age);
            int age_select = 32;
            foreach (var item in grouping_dict[age_select])
                Console.WriteLine($"age={age_select} - {item.Name}");
        }
        public static void example_16() // 16 JOIN пересечение двух множеств по признаку
        {
            var students = Properties.Resources.students
                .Split('\n')
                .Select(line => new Student(
                    Int32.Parse(line.Split()[0]),
                    line.Split()[1],
                    Int32.Parse(line.Split()[2])
                    )
                );
            var groups = Properties.Resources.groups
                .Split('\n')
                .Select(line => new Group(
                    Int32.Parse(line.Split()[0]),
                    line.Split()[1])
                );
            foreach (var item in students) // для контроля чтения
            {
                Console.WriteLine($"{item.IdSudent}; {item.NameStudent}; {item.IdGroup}");
            }
            foreach (var item in groups) // для контроля чтения
            {
                Console.WriteLine($"{item.IdGroup}; {item.NameGroup}");
            }

            string find_group = "ПИнб-3";
            var query = groups // тут не могу написать тип - он анонимный
                .Join(students,
                    g => g.IdGroup,
                    s => s.IdGroup,
                    (g, s) => new { NG = g.NameGroup, NS = s.NameStudent }) // анонимный тип
                .Where(item => item.NG == find_group)
                .OrderBy(item => item.NS);
            foreach (var item in query) //if (item.NG == select) Console.WriteLine($"{find_group} - {item.NS}");
                Console.WriteLine($"{item.NG} - {item.NS}");
        }
        public static void example_17() // 17 SelectMany комбинации сочетаний
        {
            string line1 = "red green blue dark yellow";
            string line2 = "ball cube";
            var enum1 = line1.Split();
            var enum2 = line2.Split();
            var combs = enum1.SelectMany(item1 => enum2.Select(item2 => new { Color = item1, Fig = item2 }));
            foreach (var comb in combs)
                Console.WriteLine($"{comb.Fig} - {comb.Color}");
        }
        public static void example_18() // 18 SelectMany комбинации сочетаний по условию
        {
            string[] allowedColors = new string[] { "red", "green" };
            // можно только разрешённые цвета или если первая буква цвета и фигуры совпадают
            string[] colors = new string[] { "red", "green", "blue", "dark", "yellow" };
            string[] figures = new string[] { "ball", "cube" };

            var combs = colors.SelectMany(item1 => figures
                .Select(item2 => new { Color = item1, Fig = item2 })  // все сочетания
                .Where(obj => allowedColors.Contains(obj.Color) || obj.Color[0] == obj.Fig[0])
            );
            foreach (var comb in combs)
                Console.WriteLine($"{comb.Fig} - {comb.Color}");
        }
        public static void example_19() // 19 TakeWhile
        {
            string line = "1 3 4 5 4 5 5 7 8";
            //int[] numbers = line.Split().Select(item => int.Parse(item)).ToArray();
            var numbers = line.Split().Select(item => int.Parse(item));
            var query1 = numbers.TakeWhile(num => num < 5);
            foreach (int item in query1)
                Console.WriteLine(item);
            Console.WriteLine();
            var query2 = numbers.TakeWhile((num, index) => num < 5 || index % 2 != 0);
            foreach (int item in query2)
                Console.WriteLine(item);
        }
        public static void example_20() // 20 Any All Concat Count Distinct Reverse
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine(arr1.Any(item => item % 2 != 0));
            Console.WriteLine(arr2.All(item => item % 2 != 0));
            var arr = arr1.Concat(arr2);
            Console.WriteLine(arr.Count());
            Console.WriteLine(String.Join(" ", arr.Distinct().Reverse()));
        }
        public static void example_21() // 21 Zip OrderBy ThenByDescending
        {
            int[] arr1 = new int[] { 4, 2, 2, 6, 2 };
            int[] arr2 = new int[] { 7, 9, 5, 1, 3 };
            var arr = arr1
                .Zip(arr2, (a, b) => new { a, b }) // анонимный тип
                .OrderBy(item => item.a)
                .ThenByDescending(item => item.b);
            foreach (var item in arr)
                Console.WriteLine($"{item.a} - {item.b}");
        }
        public static void example_22() // 22 HashSet Union Except Intersect
        {
            //var numbers = from i in Enumerable.Range(0, 10) select i;
            var numbers1 = Enumerable.Range(0, 10).Where(item => item % 2 != 0);
            Console.WriteLine(String.Join(" ", numbers1));
            var numbers2 = Enumerable.Range(0, 10).Where(item => item % 3 == 0);
            Console.WriteLine(String.Join(" ", numbers2));

            HashSet<int> set = new HashSet<int>();
            set = numbers1.Concat(numbers2).ToHashSet();
            Console.WriteLine(String.Join(" ", set));

            Console.WriteLine(String.Join(" ", numbers1.Union(numbers2)));

            Console.WriteLine(String.Join(" ", set.Except(numbers2)));

            var result = (new int[] { 1, 2, 3 }).Intersect(new int[] { 2, 3, 5, 6 });
            Console.WriteLine(String.Join(" ", result));
        }

        static void Main(string[] args)
        {
            example_17();

            Console.ReadLine();
        }
    }
}
