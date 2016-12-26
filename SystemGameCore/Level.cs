using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SystemGameCore
{
    public class Level
    {
        public Size GridSize;
        public Size MapSize;

        public string Name;

        public CollisionMap Collision = new CollisionMap();
        public List<Background> Layers = new List<Background>();

        public Level()
        {
            GridSize = new Size(32, 32);
            MapSize = new Size(100, 50);

            Collision.GridSize = GridSize;
            Collision.MapSize = MapSize;
        }

        public void ResizeMap()
        {

        }

        public Image GetAllLayers()
        {
            return null;
        }

        public Size SizeInPixels
        {
            get
            {
                return new Size(MapSize.Width * GridSize.Width, MapSize.Height * GridSize.Height);
            }
        }
    }
}
