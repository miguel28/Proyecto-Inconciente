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
    public class Background
    {
        [XmlIgnore]
        public Image BitmapImage;

        [XmlIgnore]
        public bool Visible = true;

        public Background()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">Expanded Size</param>
        public void Resize(Size s)
        {
            Bitmap newimage = new Bitmap(s.Width, s.Height);

            if (BitmapImage != null)
            {
                Graphics g = Graphics.FromImage(newimage);
                g.DrawImage(BitmapImage, new Point());
            }
            else
                BitmapImage = newimage;
            
        } 

        public void Load(string path, Size s)
        {
            if (File.Exists(path))
                BitmapImage = new Bitmap(path);
            else
                Resize(s); // creates
        }

        public void Save(string path)
        {
            BitmapImage.Save(path);
        }
    }
}
