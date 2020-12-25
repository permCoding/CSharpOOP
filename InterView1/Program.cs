using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace InterView1
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://pcoding.ru/csv/04.txt";

            WebClient webClient = new WebClient();
            string s = webClient.DownloadString(link);
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
