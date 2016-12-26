using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LevelEditor
{
    public static class Draw
    {
        public static Image ChopImage(Image src, Rectangle cropRect)
        {
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                                 cropRect,
                                 GraphicsUnit.Pixel);
            }
            return target;
        }

        public static void DrawGrid(ref Image img, Size grid)
        {
            Graphics g = Graphics.FromImage(img);
            float[] dashValues = { 5, 2, 15, 4 };
            Pen blackPen = new Pen(Color.Black, 0.5f);
            blackPen.DashPattern = dashValues;

            for (int i = 0; i < img.Height; i += grid.Width)
            {
                g.DrawLine(blackPen, new Point(0, i), new Point(img.Width, i));
            }

            for (int i = 0; i < img.Width; i += grid.Width)
            {
                g.DrawLine(blackPen, new Point(i, 0), new Point(i, img.Width));
            }
        }
    }
}
