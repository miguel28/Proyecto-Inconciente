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
        public string Name = "";
        public bool Visible = true;

        public void Create(Level l)
        {
            Size s = l.SizeInPixels;
            BitmapImage = new Bitmap(s.Width, s.Height);
        } 
    }
}
