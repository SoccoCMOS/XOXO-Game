using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOXO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piece> l = new List<Piece>();
            l.Add(Piece.O);
            l.Add(Piece.E);
            l.Add(Piece.O);
            l.Add(Piece.E);
            l.Add(Piece.X);
            l.Add(Piece.X);
            l.Add(Piece.O);
            l.Add(Piece.E);
            l.Add(Piece.X);

            Board b = new Board(3, 3, l);

            Console.WriteLine("Evaluation" + b.evalConfig());
            while (true);
        }
    }
}
