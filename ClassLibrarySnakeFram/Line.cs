using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySnakeFram
{
    public class Line : Figure
    {
        public Line(int xLeft, int xRight, int yLeft, int yRight)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point point = new Point(x, yLeft);
                pList.Add(point);
                if (yLeft != yRight)
                {
                    point = new Point(x, yRight);
                    pList.Add(point);
                }
            }
            for (int y = yLeft; y <= yRight; y++)
            {
                Point point = new Point(xLeft, y);
                pList.Add(point);
                if (xLeft != xRight)
                {
                    point = new Point(xRight, y);
                    pList.Add(point);
                }
            }
        }
    }
}
