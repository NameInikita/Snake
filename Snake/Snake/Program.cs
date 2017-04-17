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
            Point p1 = new Point(2, 3, '*');
            p1.Draw();
            Thread.Sleep(500);
            Point p2 = new Point(5, 3, '#');

            p2.Draw();


            Console.ReadKey();
        }
    }
}
