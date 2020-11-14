using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static int solver_que(params int[] arr) // найти количество путей
        {
            int x = arr[0], y = arr[1], a = arr[2], b = arr[3];
            Queue<int> que = new Queue<int>();
            que.Enqueue(x);
            int amount = 0;
            while (que.Count != 0)
            {
                int first = que.Dequeue();
                int way1 = first * a;
                int way2 = first + b;
                if (way1 < y) que.Enqueue(way1);
                if (way2 < y) que.Enqueue(way2);
                if (way1 == y) amount++;
                if (way2 == y) amount++;
            }
            return amount;
        }
        static List<List<int>> solver_que_ways(params int[] arr) // найти пути
        {
            int x = arr[0], y = arr[1], a = arr[2], b = arr[3];
            Queue<List<int>> que = new Queue<List<int>>();
            que.Enqueue(new List<int> { x });
            List<List<int>> ways = new List<List<int>>();
            while (que.Count != 0)
            {
                List<int> first = que.Dequeue();
                int last = first.Last();
                int next1 = last * a;
                int next2 = last + b;

                List<int> way1 = first.GetRange(0, first.Count);
                List<int> way2 = first.GetRange(0, first.Count);

                way1.Add(next1);
                way2.Add(next2);

                if (next1 < y) que.Enqueue(way1);
                if (next2 < y) que.Enqueue(way2);

                if (next1 == y) ways.Add(way1);
                if (next2 == y) ways.Add(way2);
            }
            return ways;
        }
        static void Main(string[] args)
        {
            #region задача про количестов путей
            /*  
                дано начальное число X = 1
                у исполнителя есть две команды - умножить на A и прибавить B
                например, A = 2 и B = 3, тогда *2 и +3
                сколько путей есть до числа Y = 10 ?
                все данные на вход подаются в одной строке через пробел: X Y A B 
                другая версия задачи: найти сами пути
             */
            #endregion

            int[] arr = Console.ReadLine().Split().Select(i => Int32.Parse(i)).ToArray();
            //Console.WriteLine(solver_que(arr));

            foreach (var way in solver_que_ways(arr))
                Console.WriteLine(String.Join(" ", way));
            

            Console.ReadLine();
        }
    }
}
