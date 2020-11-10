using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRating
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = GetListRandom();
            //lst.ForEach(item => Console.Write(item + " ")); Console.WriteLine();
            Console.WriteLine(String.Join(" ", lst));

            //Console.WriteLine(String.Join(" ", lst.OrderBy(item => item))); // не работает

            //Console.WriteLine(String.Join(" ", lstSortDict(lst)));

            Console.WriteLine(String.Join(" ", lstSortDict(lst)));

            Console.WriteLine(String.Join(" ", lstSortDecor(lst)));
            
            Console.ReadLine();
        }

        private static string[] lstSortDecor(List<string> lst)
        {
            /*
                AAAY
                AYYY                            
                AA+ => AAXY
                AA  => AAYY
                AA- => AAZY                
             */
            return lst
                .OrderBy(item => 
                    (item
                    .Replace('+', 'X')
                    .Replace('-', 'Z') + "YYY")
                    .Substring(0, 4)
                )
                .ToArray();
        }
        static List<string> GetListRandom()
        {
            Random rnd = new Random();

            string s = "AAA AA+ AA AA- A+ A A- BBB BB+ BB BB- B+ B B- CCC+ CCC CCC- CC C D";

            return s
                .Split()
                .OrderBy(n => rnd.Next())
                .ToList();
        }
        private static string[] lstSortDict(List<string> lst)
        { // сортируем по суммарному весу символов в строке рейтинга
            Dictionary<char, int> d = new Dictionary<char, int>
            {
                ['A'] = 10000,
                ['B'] = 1000,
                ['C'] = 100,
                ['D'] = 10,
                ['+'] = 1,
                ['-'] = -1
            };
            return lst
                .OrderByDescending(item =>
                    item
                    .ToCharArray()
                    .Select(chr => d[chr])
                    .Sum()
                )
                .ToArray();
        }
    }
}
