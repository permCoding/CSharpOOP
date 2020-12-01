using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region описание
            // как объединить разные типы в один список?
            #endregion

            var fig1 = new King();
            fig1.GoTo();
            fig1.PrintPos();

            Console.ReadLine();
        }
    }
}
