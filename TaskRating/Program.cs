using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRating
{
    class Program
    {
        static List<string> GetListRandom()
        {
            Random rnd = new Random();

            string s = "AAA AA+ AA AA- A+ A A- BBB BB+ BB BB- B+ B B- CCC+ CCC CCC- CC C D";

            return s
                .Split()
                .OrderBy(n => rnd.Next())
                .ToList();
        }
        static void Main(string[] args)
        {
            var lst = GetListRandom();
            lst.ForEach(item => Console.Write(item + " ")); Console.WriteLine();
            Console.WriteLine(String.Join(" ", lst));


            Console.WriteLine(String.Join(" ", lst.OrderBy(item => item))); // не работает

            // есть несколько способов решения
            // но один очевидный и самый тривиальный - использовать Linq

            Console.ReadLine();
        }
    }
}
