using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabRab
{
    class Example
    {
        int v2 = 0; // так можно, глобально
        //var v1 = 0; // так нельзя, глобально
        dynamic v3; //  так можно, глобально
        class A { public int x = 666; }
        public static void example_dynamic()
        {
            int x1 = 10; // явная типизация
            object x2 = 10;
            var x3 = 10; // неявная типизация, только для локального использования
            dynamic x4 = 10; // динамическая типизация и нестатическая
            x4 = 1000.0001; // можно менять тип значений
            try
            {
                Console.WriteLine(x4.Length); // не проверяется корректность элементов класса
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); // только на этапе исполнения
            }

            int y1; // так можно - без инициализации значением
            //var y2; // так нельзя

            Console.WriteLine(x1.GetType());
            Console.WriteLine(x2.GetType());
            Console.WriteLine(x3.GetType());
            Console.WriteLine(x4.GetType());

            Console.WriteLine(x1 + 5);
            Console.WriteLine((int)x2 + 5);
            Console.WriteLine(x3 + 5);
            Console.WriteLine(x4 + 5);

            A a1 = new A();
            object a2 = new A();
            Console.WriteLine(a1.x); // можно непосредственно обращаться к элементам
            //Console.WriteLine(a2.x); // так нельзя
            Console.WriteLine(((A)a2).x); // приходится делать приведение типов

            //var get_v() { return 55; }; // так нельзя
            dynamic get_d() { return 999; } // когда не знаем какой тип данных будет
            Console.WriteLine(100 + get_d());
        }
    }
}
