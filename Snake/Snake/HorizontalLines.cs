using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLines:Figure
    {

        public HorizontalLines(int xLeft,int xRight,int y,char sym)
        {
            newList = new List<Point>();

            for (int x= xLeft;x<xRight;x++)
            {
                Point p = new Point(x, y, sym);
                newList.Add(p);

            }
        }
    }
}
