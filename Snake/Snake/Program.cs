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
            /*Point p1 = new Point(2, 3, '*');
            p1.Draw();
            Thread.Sleep(500);
            Point p2 = new Point(5, 3, '#');
            p2.Draw();
            Point p3 = new Point(6, 7, '#');
            Point p4 = new Point(7, 8, '#');
            Point p5 = new Point(9, 10, '#');


            Console.WriteLine();*/
            

            HorizontalLines hl = new HorizontalLines(1,25,1,'@');
            hl.Drow();
            HorizontalLines hl1 = new HorizontalLines(1,26, 15, '&');
            hl1.Drow();

            VerticalLine vl = new VerticalLine(1, 15, 1, '*');
            vl.DrawVLine();

            VerticalLine vl1 = new VerticalLine(1, 15, 25, '*');
            vl1.DrawVLine();


            Console.ReadKey();
        }
    }
}
