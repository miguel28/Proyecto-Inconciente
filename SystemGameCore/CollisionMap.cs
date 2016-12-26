using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SystemGameCore
{
    public enum CollElem : int
    {
        Allowed,
        Blocked
    }

    public class CollisionMap
    {
        [XmlIgnore]
        public int[,] CollMap;
        public Size GridSize;
        public Size MapSize;

        public CollisionMap()
        {

        }

        public void Resize(Size grid, Size map)
        {
            int[,] newmap = new int[map.Width, map.Height];

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

        public void Save(string fileName)
        {
            File.WriteAllBytes(fileName, ToBytes(CollMap));
        }

        public void Load(string fileName)
        {
            CollMap = FromBytes(File.ReadAllBytes(fileName));
        }

        public static byte[] ToBytes(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            byte[] bytes = ms.ToArray();
            return bytes;
        }
        public static int[,] FromBytes(byte[] buffer)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(buffer);
            int[,] mat = (int[,])bf.Deserialize(ms);
            return mat;
        }
    }
}
