using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace SystemGameCore
{
    public class Level
    {
        public Size GridSize;
        public Size MapSize;

        public string Name = "";

        public Background Collision = new Background();
        public List<Background> Layers = new List<Background>();

        private Bitmap _allLayers;

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

        public void Resize(Size grid, Size map)
        {
            GridSize = grid;
            MapSize = map;

            Collision.Resize(SizeInPixels);
        }

        public Image GetAllLayers(bool includecol = false)
        {
            Size s = SizeInPixels;
            if(_allLayers == null)
                _allLayers = new Bitmap(s.Width, s.Height);

            Graphics g = Graphics.FromImage(_allLayers);
            g.Clear(Color.Transparent);
            Layers.ForEach(x => g.DrawImage(x.BitmapImage, new Point()));

            if (includecol)
                g.DrawImage(Collision.BitmapImage, new Point());

            return _allLayers;
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
            GetAllLayers().Save(filePath);
        }

        public void SaveLevel(string fileName)
        {
            string path = Path.GetDirectoryName(fileName);
            string basename = Path.GetFileNameWithoutExtension(fileName);

            using (var writer = new System.IO.StreamWriter(fileName))
            {
                var serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(writer, this);
                writer.Flush();
            }

            Collision.Save(path + "\\" +basename + "_Coll.png");

            int i = 0;
            foreach(Background b in Layers)
            {
                b.Save(path + "\\" + basename + "_Layer" + i.ToString() + ".png");
                i++;
            }
        }

        public static Level LoadLevel(string fileName, bool LoadContents = true)
        {
            string path = Path.GetDirectoryName(fileName);
            string basename = Path.GetFileNameWithoutExtension(fileName);
            Level instance = null;
            using (var stream = System.IO.File.OpenRead(fileName))
            {
                var serializer = new XmlSerializer(typeof(Level));
                instance = serializer.Deserialize(stream) as Level;
            }

            if (instance != null && LoadContents)
            {
                instance.Collision.Load(path + "\\" + basename + "_Coll.png", instance.SizeInPixels);

                int i = 0;
                foreach(Background l in instance.Layers)
                {
                    instance.Layers[i].Load(path + "\\" + basename + "_Layer" + i.ToString() + ".png", instance.SizeInPixels);
                    i++;
                }
            }
            return instance;
        }
    }
}
