using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class King : IMove
    {
        public int Pos { get; set; }
        public int GoTo()
        {
            return ++Pos;
        }
        public void PrintPos()
        {
            Console.WriteLine($"king's position - {Pos}");
        }
        public King(int pos = 0)
        {
            Pos = pos;
        }
    }
    public class Pawn : IMove
    {
        public int Pos { get; set; }

        public int GoTo()
        {
            Pos++;
            return ++Pos;
        }

        public void PrintPos()
        {
            Console.WriteLine($"pawn's position - {Pos}");
        }
        public Pawn()
        {
            Pos = 0;
        }
    }
    public class Rook : IMove
    {
        public int Pos { get; set; }
        public int GoTo()
        {
            return 0;
        }
        public void PrintPos()
        {
            //
        }
        public Rook(int pos = 0)
        {
            Pos = pos;
        }
    }
}