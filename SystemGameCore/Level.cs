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

        public string Name = "";

        public CollisionMap Collision = new CollisionMap();
        public List<Background> Layers = new List<Background>();

        public Level()
        {
            Resize(new Size(32, 32), new Size(100, 50));
        }

        public void Create()
        {
            if (Layers.Count == 0)
            {
                AddNewLayer();
            }
        }

        public void Load(string path)
        {
            
        }

        public void Resize(Size grid, Size map)
        {
            GridSize = grid;
            MapSize = map;

            Collision.Resize(GridSize, MapSize);
        }

        public Image GetAllLayers()
        {
            Size s = SizeInPixels;
            Bitmap img = new Bitmap(s.Width, s.Height);
            Graphics g = Graphics.FromImage(img);

            Layers.ForEach(x => g.DrawImage(x.BitmapImage, new Point()));

            return img;
        }

        public void AddNewLayer()
        {
            Background b = new Background();
            b.Resize(SizeInPixels);
            Layers.Add(b);
        }

        public void RemoveLayer(int index)
        {
            if (Layers.Count > 0 && index < Layers.Count)
            {
                // delete
                Layers.RemoveAt(index);
            }
        }

        public string[] GetLayersLabels()
        {
            List<string> labels = new List<string>();
            for (int i = 0; i < Layers.Count; i++)
                labels.Add("Layer " + i.ToString());
            return labels.ToArray();
        }

        public Size SizeInPixels
        {
            get
            {
                return new Size(MapSize.Width * GridSize.Width, MapSize.Height * GridSize.Height);
            }
        }

        public void SaveMapAsImage(string filePath)
        {
            GetAllLayers().Save(filePath + "/" + Name + "_Rendered.png");
        }

        public void Save(string filePath)
        {

        }
    }
}
