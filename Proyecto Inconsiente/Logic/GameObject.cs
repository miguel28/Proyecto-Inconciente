using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Proyecto_Inconsiente.Logic
{
    public class GameObject
    {
        public Vector2 Position;
        public Vector2 Speed;
        public Vector2 Acceleration;

        public bool UseDynamics
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

        }
    }
}
