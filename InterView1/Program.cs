using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace InterView1
{
    class Example
    {
        private string link;
        public string reader()
        {
            WebClient webClient = new WebClient();
            string s = webClient.DownloadString(link);
            return s;
        }
        public Example(string link)
        {
            this.link = link;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://pcoding.ru/csv/04.txt";

            Example example1 = new Example(link);
            Console.WriteLine(example1.reader());
            
            Console.ReadLine();
        }
    }
}
