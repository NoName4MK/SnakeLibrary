using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySnakeFram
{
    public class Figure
    {
        public List<Point> pList;

        public Figure()
        {
        }
        public Figure(List<Point> points)
        {
            pList = points;
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        internal bool IsHitFuture(Point point)
        {
            return IsHit(point);
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
        //public void Draw()
        //{
        //    foreach (Point p in pList)
        //    {
        //        p.Draw();
        //    }
        //}
        public List<Point> Draw()
        {
            return pList;
        }

    }
}
