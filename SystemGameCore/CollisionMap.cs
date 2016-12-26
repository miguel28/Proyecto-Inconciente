using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SystemGameCore
{
    public enum CollElem : int
    {
        Allowed,
        Blocked
    }

    public class CollisionMap
    {
        public CollElem[,] CollMap;
        public Size GridSize;
        public Size MapSize;

        public CollisionMap()
        {

        }

        public void Resize(Size grid, Size map)
        {
            CollElem[,] newmap = new CollElem[map.Width, map.Height];

            int w = Math.Min(map.Width, MapSize.Width);
            int h = Math.Min(map.Height, MapSize.Height);

            GridSize = grid;
            MapSize = map;

            if (CollMap != null)
            {
                // resize
                for (int x = 0; x < w; x++)
                    for ( int y = 0; y< h; y++ )
                        newmap[x, y] = CollMap[x, y];
            }
            else // create
                CollMap = newmap;
        }
    }
}
