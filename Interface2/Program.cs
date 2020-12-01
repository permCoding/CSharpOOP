using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program
    {
        interface IHuman
        {
            int Goto();
        }
        interface IOrk
        {
            int Goto();
        }
        class Actor : IHuman, IOrk
        {
            public int Pos { get; set; }
            //public int Goto()
            //{
            //    return ++Pos;
            //}
            public Actor(int pos = 0)
            {
                Pos = pos;
            }
            int IOrk.Goto()
            {
                Pos++;
                return ++Pos;
            }
            int IHuman.Goto()
            {
                return ++Pos;
            }
        }
        static void Main(string[] args)
        {
            #region описание
            // как ещё можно объединять сущности
            // будет класс, который реализует два интерфейса
            // будут два интерфейса с одинаковым методом
            // неявная и явная реализация интерфейсов
            #endregion

            Actor obj1 = new Actor();
            Actor obj2 = new Actor();

            ((IHuman)obj1).Goto();
            (obj2 as IOrk).Goto();

            Console.WriteLine(obj1.Pos);
            Console.WriteLine(obj2.Pos);

            Console.ReadLine();
        }
    }
}
