using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLines hl = new HorizontalLines(0,79,0,'+');
            hl.Drow();
            HorizontalLines hl1 = new HorizontalLines(0,79, 24, '+');
            hl1.Drow();
            VerticalLine vl = new VerticalLine(0, 24, 0, '+');
            vl.DrawVLine();
            VerticalLine vl1 = new VerticalLine(0, 24, 78, '+');
            vl1.DrawVLine();

            Point p = new Point(4, 5, '*');
            p.Draw();


            Console.ReadKey();
        }
    }
}
