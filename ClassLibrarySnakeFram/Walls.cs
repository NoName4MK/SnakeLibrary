using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySnakeFram
{
    public class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            Line line = new Line(0, mapWidth - 1, 0, mapHeight - 1);
            wallList.Add(line);

        }
        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
        public bool IsHitFuture(Point point)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHitFuture(point))
                {
                    return true;
                }
            }
            return false;
        }
        //public void Draw()
        //{
        //    foreach (var wall in wallList)
        //    {
        //        wall.Draw();
        //    }
        //}
    }
}
