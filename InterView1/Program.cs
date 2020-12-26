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
        private static WebClient webClient = new WebClient();
        public string Link
        {
            //get { return link.Split('/').Last(); }
            get { return link; }
            set
            {
                if (value.StartsWith("http"))
                {
                    link = value;
                }
                else
                {
                    link = "https://pcoding.ru/csv/03.txt";
                    Console.WriteLine("Ссылка неверна");
                }
            }
        }

        public string reader()
        {
            return webClient.DownloadString(Link);
        }
        public string reader(string _link)
        {   
            return  webClient.DownloadString(_link);
        }
        public Example()
        {
            
        }
        public Example(string link)
        {
            this.Link = link;
        }
        public Example(int num)
        {
            this.Link = "https://pcoding.ru/csv/0"+ num.ToString() +".txt";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://pcoding.ru/csv/04.txt";

            //Example example1 = new Example(link);
            //example1.Link = "htps://pcoding.ru/csv/03.txt";

            //Example example2 = new Example(link);

            Example example3 = new Example(6);
            Console.WriteLine(example3.reader());
            //Console.WriteLine(example1.reader());
            //Console.WriteLine(example2.reader());

            //Console.WriteLine(example1.Link);
            //Console.WriteLine(example2.Link);


            Console.ReadLine();
        }
    }
}
