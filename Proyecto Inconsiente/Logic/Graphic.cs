using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Proyecto_Inconsiente.Logic
{
    public class Graphic : GameObject
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

        public SpriteBatch Batch;
        public Color Colorize;

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            if (gfx != null)
                Batch.Draw(gfx, Position, Colorize);
        }
    }
}
