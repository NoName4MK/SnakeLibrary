using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySnakeFram
{
    public class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        //char symbol;
        Random random = new Random();
        public FoodCreator(int mapWidht, int mapHeight)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            //this.symbol = symbol;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y);
        }
    }
}
