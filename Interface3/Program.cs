using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region описание
            // свойства класса реализованы на других классах (не наследование)
            #endregion

            Laptop lt1 = new Laptop("HP x212");
            // все параметры передавать через конструктор
            lt1.screen = new Screen();
            lt1.screen.Colors = 32;
            lt1.screen.Width = 1920;
            lt1.screen.Height = 1080;

            lt1.screen.PrintInfo(Properties.Resources.algo);

            Laptop lt2 = new Laptop("Acer e14");
            // все параметры передавать через конструктор
            lt2.screen = new ScreenRotate();
            lt2.screen.Colors = 32;
            lt2.screen.Width = 1920;
            lt2.screen.Height = 1080;            
            // Direction - false - true
            lt2.screen.PrintInfo(Properties.Resources.algo);

            Console.ReadLine();
        }
    }
}
