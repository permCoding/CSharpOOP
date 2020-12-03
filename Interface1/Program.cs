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

            King fig1 = new King();
            var fig2 = new Pawn();
            // я сменил название IMove на более адекватное IFigure
            List<IFigure> lst = new List<IFigure>() { fig1, fig2 };

            lst.Add(new Rook());

            foreach (IFigure fig in lst)
                fig.GoTo();

            foreach (IFigure fig in lst)
                fig.PrintPos();

            Console.ReadLine();
        }
    }
}
