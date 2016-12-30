using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Proyecto_Inconsiente.Logic
{
    public class Graphic
    {
        private Texture2D gfx;
        
        public Graphic(string textureName, SpriteBatch batch = null)
        {
            gfx = Globals.Content.Load<Texture2D>(textureName);
            Batch = batch;
            Colorize = Color.White;
        }

        public Texture2D Texture
        {
            get
            {
                return gfx;
            }
        }

        public Vector2 Position;
        public Vector2 Speed;
        public Vector2 Acceleration;
        public SpriteBatch Batch;

        public bool UseDynamics
        {
            get;
            set;
        }

        public Color Colorize
        {
            get;
            set;
        }

        public virtual void Update(GameTime gameTime)
        {
            if (UseDynamics)
            {
                float sec = (float)gameTime.ElapsedGameTime.TotalSeconds;
                Vector2 deltaspeed = Vector2.Transform(Acceleration, Matrix.CreateScale(sec));
                Speed += deltaspeed;

                Vector2 deltapos = Vector2.Transform(Speed, Matrix.CreateScale(sec));
                Position += deltapos;
            }
        }

        public virtual void Draw(GameTime gameTime)
        {
            if (gfx != null)
                Batch.Draw(gfx, Position, Colorize);
        }
    }
}
