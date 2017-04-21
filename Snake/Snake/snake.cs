using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            newList = new List<Point>();
            for (int i=0;i<lenght;i++)
            {
                Point p = new Point(tail);//точка копия хвоста
                p.Move(i, direction);//двигаю точку на i в направлении direction
                newList.Add(p); 

            }
        }
    }
}
