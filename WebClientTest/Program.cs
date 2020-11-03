using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientTest
{
    class Program
    {
        static void Main()
        {
            WebClient webClient = new WebClient();
            string s = webClient.DownloadString("https://pcoding.ru/csv/00.txt");
            
            Console.WriteLine(s);
            
            Console.ReadLine();
        }
    }
}
