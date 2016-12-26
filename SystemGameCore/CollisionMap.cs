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

        public void ResizeMap()
        {
            CollMap = new CollElem[MapSize.Width, MapSize.Height];
        }
    }
}
