using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Proyecto_Inconsiente.Logic
{
    public class Sprite : Graphic
    {
        private int currentFrame;
        private int[] currentAnimPatern;
        private float animTime = 0f;
        private float targetAnimTime = 0f;
        protected Rectangle sourceRectangle;
        protected Rectangle destinationRectangle;

        public Sprite(string spriteName, SpriteBatch batch)
            :base (spriteName, batch)
        {
            Rows = 1;
            Columns = 1;
        }

        public int Rows { get; set; }
        public int Columns { get; set; }

        public int TotalFrames
        {
            get
            {
                return Rows * Columns;
            }
        }

        public int CurrentFrame
        {
            get
            {
                return currentFrame;
            }
        }

        public void SetAnim(int[] pattern, float speed)
        {
            currentAnimPatern = pattern;
            animTime = 0f;
            targetAnimTime = speed;
        }

        public void StopAnim()
        {
            currentAnimPatern = null;
        }

        public override void Update(GameTime gameTime)
        {
            if (currentAnimPatern != null)
            {
                animTime += (float)gameTime.ElapsedGameTime.TotalSeconds;

                if(animTime >=targetAnimTime)
                {
                    currentFrame++;
                    animTime = 0f;
                }

                if (currentFrame >= currentAnimPatern.Length)
                    currentFrame = 0;

                int width = Texture.Width / Columns;
                int height = Texture.Height / Rows;
                int row = (int)((float)currentAnimPatern[currentFrame] / (float)Columns);
                int column = currentAnimPatern[currentFrame] % Columns;

                sourceRectangle = new Rectangle(width * column, height * row, width, height);
                destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, width, height);
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Batch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            //base.Draw(gameTime);
        }
    }
}
