using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LevelEditor
{
    public static class Helpers
    {
        public static  void ReorderPoints(ref Point p1, ref Point p2)
        {
            Point ptemp;
            if (p2.X < p1.X && p2.Y < p1.Y)
            {
                ptemp = p1;
                p1 = p2;
                p2 = ptemp;
            }
        }

        public static  Point CalcUnitPoint(Point p, Size Grid)
        {
            return new Point(p.X / Grid.Width, p.Y / Grid.Height);
        }

        public static  Rectangle FromTwoPoints(Point p1, Point p2)
        {
            ReorderPoints(ref p1, ref p2);
            return new Rectangle(p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
        }

        public static  Rectangle CalcUnitRectangle(Point p1, Point p2, Size grid)
        {
            Rectangle r = FromTwoPoints(CalcUnitPoint(p1, grid), CalcUnitPoint(p2, grid));

            r.Width++;
            r.Height++;

            return r;
        }

        public static  Rectangle GetExpandedRectangle(Rectangle unit, Size grid)
        {
            return new Rectangle(unit.X * grid.Width
                               , unit.Y * grid.Height
                               , unit.Width * grid.Width
                               , unit.Height * grid.Height);
        }

        public static Point GetExpandablePoint (Point p, Size grid)
        {
            return new Point(p.X * grid.Width, p.Y * grid.Height);
        }

        public static  bool IsRectangleNull(Rectangle rect)
        {
            return rect.Width == 0 && rect.Height == 0;
        }

        public static bool IsEqual(Point p1, Point p2)
        {
            return (p1.X == p2.X && p1.Y == p2.Y);
        }

        public static Rectangle CloneRectangle(Rectangle src)
        {
            return new Rectangle(src.X, src.Y, src.Width, src.Height);
        }
    }
}
