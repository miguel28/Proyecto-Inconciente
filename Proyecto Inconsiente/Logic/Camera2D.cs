using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Proyecto_Inconsiente.Logic
{
    public class Camera2D
    {
        private readonly Viewport _viewport;

        public Camera2D(Viewport viewport)
        {
            _viewport = viewport;

            Rotation = 0;
            Zoom = 1;
            Origin = new Vector2(viewport.Width / 2f, viewport.Height / 2f);
            Position = Vector2.Zero;
        }

        public Vector2 Position;
        public float Rotation;
        public float Zoom;
        public Vector2 Origin;
        public bool UseLimits = true;
        public int Width;
        public int Height;

        public void Follow(GameObject obj, float frame)
        {
            Rectangle r = new Rectangle((int)Position.X, (int)Position.Y, _viewport.Width, _viewport.Height);

            int x0 = (int)obj.Position.X - r.X;
            int y0 = (int)obj.Position.Y - r.Y;

            int x1 = (int)(r.Width * frame);
            int x2 = (int)(r.Width * (1f- frame));
            int y1 = (int)(r.Height * frame);
            int y2 = (int)(r.Height * (1f - frame));

            Position.X = obj.Position.X - (r.Width / 2);
            Position.Y = obj.Position.Y - (r.Height / 2);
                /*if (x0 < x1)
            {
                Position.X = r.X - x1;
            }
            else if (x0 > x2)
            {
                Position.X = r.Right - x2;
            }
            else
            {

            }*/

            /*
            if (y0 < y1)
            {
                Position.Y = r.Y - y1;
            }

            if (y0 > y2)
            {
                Position.Y = r.Bottom - y2;
            }*/
        }

        public Matrix GetViewMatrix()
        {
            if (UseLimits)
            {
                if (Position.X < 0)
                    Position.X = 0;
                if (Position.Y < 0)
                    Position.Y = 0;
                
                if (Position.X > Width - _viewport.Width)
                    Position.X = Width - _viewport.Width;
                if (Position.Y > Height - _viewport.Height)
                    Position.Y = Height - _viewport.Height;
            }

            return
                Matrix.CreateTranslation(new Vector3(-Position, 0.0f)) *
                Matrix.CreateTranslation(new Vector3(-Origin, 0.0f)) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateScale(Zoom, Zoom, 1) *
                Matrix.CreateTranslation(new Vector3(Origin, 0.0f));
        }
    }
}
