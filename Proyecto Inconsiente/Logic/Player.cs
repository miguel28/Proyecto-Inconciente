using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Proyecto_Inconsiente.Logic
{
    public enum PlayerMoves : int
    {
        Nothing,
        Left,
        Right,
    }
    public class Player : Sprite
    {
        public static Vector2 Gravity = new Vector2(0f,9.8f);

        private int win_width;
        private int win_height;
        private PlayerMoves CurrentMove;
        private PlayerMoves LastMove;

        public Player(SpriteBatch batch) 
            : base ("Characters\\maidchar01", batch)
        {
            base.Rows = 4;
            base.Columns = 4;
            base.UseDynamics = true;

            win_width = Globals.Graphics.GraphicsDevice.Viewport.Width;
            win_height = Globals.Graphics.GraphicsDevice.Viewport.Height;
        }

        public override void Update(GameTime gameTime)
        {
            ProcessInput();
            GravityProcess();

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

        public GameLevel Level;

        public bool TouchingGround;
        public bool Moving
        {
            get
            {
                return CurrentMove == PlayerMoves.Left || CurrentMove == PlayerMoves.Right;
            }
        }
        public bool MovingLeft
        {
            get
            {
                return CurrentMove == PlayerMoves.Left;
            }
        }
        public bool MovingRight
        {
            get
            {
                return CurrentMove == PlayerMoves.Right;
            }
        }

        private void ProcessInput()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                if (TouchingGround)
                {
                    base.Speed += new Vector2(0, -120);
                    base.Acceleration += new Vector2(0, -30);
                }
                else
                    base.Speed += new Vector2(0, -0.5f);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left) && Keyboard.GetState().IsKeyUp(Keys.Right))
                CurrentMove = PlayerMoves.Left;

            else if (Keyboard.GetState().IsKeyDown(Keys.Right) && Keyboard.GetState().IsKeyUp(Keys.Left))
                CurrentMove = PlayerMoves.Right;
            else
                CurrentMove = PlayerMoves.Nothing;

            if (MovingLeft && !Level.IsColliding(this.Position + new Vector2(-1f, 24)) )
                base.Position += new Vector2(-1f, 0);
            else if (MovingRight && !Level.IsColliding(this.Position + new Vector2(1f + 32f, 24)) )
                base.Position += new Vector2(1f, 0);

            if (Keyboard.GetState().IsKeyUp(Keys.Up))
                while ( (Level.IsColliding(this.Position + new Vector2(-1f, 47)) && !Level.IsColliding(this.Position + new Vector2(-1f, 24)))
                ||  (Level.IsColliding(this.Position + new Vector2(1f + 32f, 47)) && !Level.IsColliding(this.Position + new Vector2(1f + 32f, 24)))) 
                {
                    //if (!TouchingGround)
                    //    break;
                    this.Position.Y--;
                
                }

            if (LastMove == PlayerMoves.Nothing && Moving)
            {
                if (MovingLeft)
                    base.SetAnim(new int[] { 4, 5, 6, 7, 6, 5 }, 0.25f);
                else if (MovingRight)
                    base.SetAnim(new int[] { 8, 9, 10, 11, 10, 9 }, 0.25f);
            }
            else if ((LastMove == PlayerMoves.Left || LastMove == PlayerMoves.Right) && !Moving)
            {
                if (LastMove == PlayerMoves.Left)
                    base.SetAnim(new int[] { 4 }, 0.25f);
                else if (LastMove == PlayerMoves.Right)
                    base.SetAnim(new int[] { 8 }, 0.25f);
            }

            LastMove = CurrentMove;

        }

        private void GravityProcess()
        {
            // Avoid fall to the emptyness
            if (base.Position.Y + destinationRectangle.Height > 400)
            {
                if (!TouchingGround)
                {
                    TouchingGround = true;
                    base.Acceleration.Y = 0;
                    base.Speed.Y = 0;
                }
                
                base.Position.Y = 400 - destinationRectangle.Height;
                
            }
            else if(Level.IsColliding(this.Position + new Vector2(16,48)) && !TouchingGround)
            {
                TouchingGround = true;
                base.Acceleration.Y = 0;
                base.Speed.Y = 0;
            }
            else
            {
                TouchingGround = false;
            }

            if (!TouchingGround)
            {
                base.Acceleration += Gravity;
            }
        }
    }
}
