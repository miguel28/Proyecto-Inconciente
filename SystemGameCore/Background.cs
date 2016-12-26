using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SystemGameCore
{
    public class Background
    {
        public Image BitmapImage;
        public bool Visible = true;

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

        public void Load(string path)
        {
            BitmapImage = new Bitmap(path);
        }

        public void Save(string path)
        {
            BitmapImage.Save(path);
        }
    }
}
