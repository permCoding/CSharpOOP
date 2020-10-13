using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace rabbit_routes
{
    class Program
    {
        static int[] numberRoutes;
        static Dictionary<int, int> numberRoutesDict;
        static int GetNumberRoutes(int k, int n)
        {
            // if (n < 0) return 0;
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int count = 0;
                for (int step = 1; step <= Math.Min(k, n); step++)
                {
                    count += GetNumberRoutes(k, n - step);
                }
                return count;
            }
        }
        static int GetNumberRoutesMem(int k, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int count = 0;
                for (int step = 1; step <= Math.Min(k, n); step++)
                {
                    if (numberRoutes[n - step] == 0)
                    {
                        numberRoutes[n - step] = GetNumberRoutesMem(k, n - step);
                    }   
                    count += numberRoutes[n - step];
                }
                return count;
            }
        }
        static int GetNumberRoutesDict(int k, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int count = 0;
                for (int step = 1; step <= Math.Min(k, n); step++)
                {
                    if (!numberRoutesDict.Keys.Contains(n - step))
                    {
                        numberRoutesDict[n - step] = GetNumberRoutesDict(k, n - step);
                    }
                    count += numberRoutesDict[n - step];
                }
                return count;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(item => int.Parse(item))
                .ToArray();
            int k = arr[0], n = arr[1];

            // способ 1
            // Console.WriteLine(GetNumberRoutes(k, n));

            // способ 2
            // numberRoutes = new int[n];
            // Console.WriteLine(GetNumberRoutesMem(k, n));

            // способ 3
            numberRoutesDict = new Dictionary<int, int>();
            Console.WriteLine(GetNumberRoutesDict(k, n));

            Console.ReadLine();
        }
    }
}
