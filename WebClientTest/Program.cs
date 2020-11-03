using System;
using System.Collections.Generic;
using System.Globalization;
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
            string s = webClient.DownloadString("https://pcoding.ru/csv/04.txt");

            Console.WriteLine(s);



            #region примеры обработки чисел с точкой            
            //Console.WriteLine(double.Parse("1,5") + 0.10);

            //Console.WriteLine(double.Parse("1.5", CultureInfo.InvariantCulture) + 0.10);

            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //Console.WriteLine(double.Parse("1.5") + 0.10);
            //Console.WriteLine(double.Parse("1.5", CultureInfo.InvariantCulture) + 0.10);
            //Console.WriteLine(double.Parse("1.5", CultureInfo.CurrentCulture) + 0.10);

            //string number = "1.5";
            //Console.WriteLine(double.Parse(number, CultureInfo.CurrentCulture) + 0.10);
            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            //Console.WriteLine(double.Parse("1,5") + 0.10);
            ////Console.WriteLine(double.Parse("1.5") + 0.10);
            #endregion

            Console.ReadLine();
        }
    }
}
