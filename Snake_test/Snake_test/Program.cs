using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake_test
{
    class Point
    {
        int x1;
        int x2;
        char sum;

        public int X1 { get { return x1; } set { x1 = value; } }
        public int X2 { get { return x2; } set { x2 = value; } }
        public char Sum { get { return sum; } set { sum = value; } }


    }


    class Program
    {
        static public void Draw(int x, int y, char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Point p1 = new Point();
          

            for (int i=0;i<10;i++)
            {
                p1.X1 = rnd.Next(1, 50);
                p1.X2 = rnd.Next(1, 25);
                Draw(p1.X1, p1.X2, '*');
                Thread.Sleep(2000);
                Console.Clear();
            }


            Console.ReadKey();



        }
    }
}
