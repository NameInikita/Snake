using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x1 = 1;
            int x2 = 3;
            char symd1 = '*';

            Draw(x1, x2, symd1);

            Draw(14, 3, '*');


            Console.ReadKey();
        }
        static void Draw(int a,int b, char x)
        {
            Console.SetCursorPosition(a, b);
            Console.Write(x);
        }
    }
}
