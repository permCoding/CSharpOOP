using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrogsDLL;

namespace FrogsTestDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Solver solver = new Solver(3, "OXOX_XO");
            solver.Find();
            Console.WriteLine(solver.Next);
            Console.WriteLine();

            foreach (string step in solver.Result)
            {
                Console.WriteLine(step);
            }

            Console.ReadLine();
        }
    }
}
