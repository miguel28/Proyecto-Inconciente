using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Proyecto_Inconsiente.Logic
{
    public class Background : Graphic
    {
        private int win_width;
        private int win_height;

        public Background(string backgroundName, SpriteBatch batch) 
            : base(backgroundName, batch)
        {
            win_width = Globals.Graphics.GraphicsDevice.Viewport.Width;
            win_height = Globals.Graphics.GraphicsDevice.Viewport.Height;
        }

        public bool UseLimits
        {
            get;
            set;
        }

        public override void Update(GameTime gameTime)
        {
            
            base.Update(gameTime);

            if (UseLimits)
            {
                if (base.Position.X < win_width - base.Texture.Width)
                    base.Position.X = win_width - base.Texture.Width;
                if (base.Position.Y < win_height - base.Texture.Height)
                    base.Position.Y = win_height - base.Texture.Height;

                if (base.Position.X > 0)
                    base.Position.X = 0;
                if (base.Position.Y > 0)
                    base.Position.Y = 0;
            }
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
