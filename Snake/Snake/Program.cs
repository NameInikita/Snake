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
            Point p3 = new Point(6, 7, '#');
            Point p4 = new Point(7, 8, '#');
            Point p5 = new Point(9, 10, '#');


            Console.WriteLine();


            List<Point> list1 = new List<Point>();
            list1.Add(p1);
            list1.Add(p2);
            list1.Add(p3);
            list1.Add(p4);
            list1.Add(p5);
            list1.Add(p1);


            foreach (Point elem in list1)
                Console.WriteLine(elem);

            Console.ReadKey();
        }
    }
}
