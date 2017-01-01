using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Proyecto_Inconsiente.Logic;
namespace Proyecto_Inconsiente
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class MainGameLogic : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteBatch world;
        Background back1;
        Player sprite1;
        SpriteFont font;
        GameLevel level2;
        Camera2D camera;

        public MainGameLogic()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            /// Set Global Variables
            Globals.Content = Content;
            Globals.Graphics = graphics;
            Globals.MainGame = this;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            camera = new Camera2D(GraphicsDevice.Viewport);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            world = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            back1 = new Background("Backgrounds\\background1", world);

            sprite1 = new Player(world);
            sprite1.SetAnim(new int[] { 0, 1, 2, 3, 2, 1 }, 0.25f);

            font = Content.Load<SpriteFont>("Fonts\\Arial");

            level2 = GameLevel.LoadGameLevel("Levels\\Level2.xml", world);
            sprite1.Level = level2;
            camera.Width = level2.Collision.Texture.Width;
            camera.Height = level2.Collision.Texture.Height;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                //camera.Position += new Vector2(-1, 0);
            }
                
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                //camera.Position += new Vector2(1, 0);
            }

            camera.Follow(sprite1, .3f);
               
            back1.Update(gameTime);
            level2.Update(gameTime);
            sprite1.Update(gameTime);
            

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGray);

            // TODO: Add your drawing code here
            Matrix tranform = camera.GetViewMatrix();

            world.Begin(transformMatrix: tranform);
            back1.Draw(gameTime);
            level2.Draw(gameTime);
            sprite1.Draw(gameTime);
            world.End();

            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Pos:" + sprite1.Position.ToString() , new Vector2(10, 10), Color.White);
            spriteBatch.DrawString(font, "Spd:" + sprite1.Speed.ToString(), new Vector2(10, 30), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
