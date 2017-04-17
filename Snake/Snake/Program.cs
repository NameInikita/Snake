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


            Point p1 = new Point();
            Point p2 = new Point();
            p1.x1 = 1;
            p1.x2 = 4;
            p1.sym = '*';
            p1.Draw(p1.x1, p1.x2,p1.sym);

            Thread.Sleep(1000);
            p2.x1 = 4;
            p2.x2 = 4;
            p2.sym = '#';
            p2.Draw(p2.x1, p2.x2, p2.sym);




            Console.ReadKey();
        }
       
    }
}
