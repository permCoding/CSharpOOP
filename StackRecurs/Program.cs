using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackRecurs
{
    class Program
    {
        static int GetSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + GetSum(n - 1);
            }
        }  
        static void Main(string[] args)
        {
            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);
            //}
            int n = 11000;
            Console.WriteLine($"{n} - {GetSum(n)}");
            Console.ReadLine();
        }
    }
}
