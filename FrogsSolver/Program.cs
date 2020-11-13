using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogsSolver
{
    class Program
    {
        static void Solver_1()
        {
            SolverQueue_1 slv = new SolverQueue_1("OXO_OXX");

            Console.WriteLine(String.Join("\n", slv.que));

            slv.FindNext();

            Console.WriteLine(String.Join("\n", slv.que));
        }
        static void Solver_2()
        {
            SolverQueue_2 slv = new SolverQueue_2("OXO_OXX");

            slv.FindNext();

            foreach (var way in slv.que)
            {
                Console.WriteLine(String.Join("\n", way));
                Console.WriteLine();
            }
            Console.WriteLine("- - - -");
            
            slv.FindNext();
            
            foreach (var way in slv.que)
            {
                Console.WriteLine(String.Join("\n", way));
                Console.WriteLine();
            }
        }
        static void Solver_3()
        {
            SolverQueue_3 slv = new SolverQueue_3("OXO_OXX");

            slv.FindNext();

            var way = slv.que.Last();

            Console.WriteLine(String.Join("\n", way));
        }
        static void Main(string[] args)
        {
            //Solver_1();
            //Solver_2();
            Solver_3();

            Console.ReadLine();
        }
    }
}
