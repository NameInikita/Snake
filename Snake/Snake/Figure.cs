using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> newList;

        public void DrawVLine()
        {
            foreach (Point elem in newList)
                elem.Draw();
        }

    }
}
