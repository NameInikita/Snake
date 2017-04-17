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


        public void Draw(int a,int b,char ch)
        {
            Console.SetCursorPosition(x1, x2);
            Console.Write(sym);
        }

    }
}
