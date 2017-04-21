using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_snake
{
    class Point
    {
        int a, b;
        char sym;
            
        public Point(int a,int b,char sym)
        {
            this.a = a;
            this.b = b;
            this.sym = sym;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            bool flag = false;

            double first = 0;
            double second = 0;

            char oper = '\0';

            Console.Write("Это простейший калькулятор для двух чисел\n");
            Console.WriteLine(@"В этом калькуляторе можно производить следующе операции:
            + сложение
            - вычитание
            *  умножение
            / деление
            % остаток от деления
            q- ВЫХОД из калькулятора");

            do
            {
                try
                {
                    Console.Write("Введите первое число :");
                    first = double.Parse(Console.ReadLine());

                    Console.Write("Введите второе число :");
                    second = double.Parse(Console.ReadLine());

                    Console.Write("Введите операцию: ");
                    oper = char.Parse(Console.ReadLine());

                }
                catch
                {
                    flag = true;
                    Console.WriteLine("Внимательно читайте инструкцию!");
                }
                if (!flag)
                {
                    switch (oper)
                    {
                        case '+': Console.WriteLine("{0} + {1} = {2}", first, second, (first + second)); break;
                        case '-': Console.WriteLine("{0} - {1} = {2}", first, second, (first - second)); break;
                        case '*': Console.WriteLine("{0} * {1} = {2}", first, second, (first * second)); break;
                        case '/': Console.WriteLine("{0} / {1} = {2}", first, second, (first / second)); break;
                        case '%': Console.WriteLine("{0} % {1} = {2}", first, second, (first % second)); break;
                        case 'q': quit = true; break;

                        default: Console.WriteLine("Некорректная операция"); break;
                    }
                }
                Console.WriteLine("Заверщить работу калькулятора? y/n ");
                char exit = char.Parse(Console.ReadLine());
                if (exit == 'y') break;


                flag = false;

            }
            while (!quit);


        }

    }
}
