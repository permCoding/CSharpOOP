using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface IFigure
    {
        int Pos { get; set; }
        int GoTo();
        void PrintPos();
    }
}
