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

        public static Image ReplaceColor(Image img, Color find, Color replace)
        {
            Bitmap bmp = (Bitmap)img;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color gotColor = bmp.GetPixel(x, y);
                    if (IsEqual(gotColor, find))
                    {
                        bmp.SetPixel(x, y, replace);
                    }                    
                }
            }
            return bmp;
        }

        public static bool IsEqual(Color c1, Color c2)
        {
            return (c1.A == c2.A && c1.R == c2.R && c1.G == c2.G && c1.B == c2.B);
        }

        public static Image SetTransparecy(Image img, Color find)
        {
            return ReplaceColor(img, find, Color.FromArgb(0, 0, 0, 0));
        }

        public static Image DrawEmptyRectangle(Image img, Rectangle r)
        {
            Bitmap bmp = (Bitmap)img;
            for (int x = r.X; x < (r.Right); x++)
            {
                for (int y = r.Y; y < (r.Bottom); y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(0,0,0,0));
                }
            }
            return bmp;
        }
    }
}
