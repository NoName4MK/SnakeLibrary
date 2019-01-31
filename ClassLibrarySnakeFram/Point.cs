using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySnakeFram
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
        }
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Down: y = y + offset; break;
                case Direction.Up: y = y - offset; break;
                case Direction.Right: x = x + offset; break;
                case Direction.Left: x = x - offset; break;
            }

        }

        //public void Clear()
        //{
        //    //symbol = "";
        //    //Draw();
        //}
        //public Point Draw()
        //{
        //   Point p = new Point(this.x, this.y);
        //   return p;
        //}
        internal bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
