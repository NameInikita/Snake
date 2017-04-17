using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x1;
        public int x2;
        public char sym;


        public Point()
        {
        }
        public Point(int x1, int x2, char sym)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.sym = sym;
        }
        

        public void Draw()
        {
            Console.SetCursorPosition(x1, x2);
            Console.Write(sym);
        }

    }
}
