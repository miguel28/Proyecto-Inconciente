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
        Background back1;
        Sprite sprite1;
        SpriteFont font;

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

            // TODO: use this.Content to load your game content here
            back1 = new Background("Backgrounds\\background1", spriteBatch);
            back1.UseLimits = true;

            sprite1 = new Player(spriteBatch);
            sprite1.SetAnim(new int[] { 0, 1, 2, 3, 2, 1 }, 0.25f);

            font = Content.Load<SpriteFont>("Fonts\\Arial");
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
            /*if (Keyboard.GetState().IsKeyDown(Keys.Up))
                back1.Position += new Vector2(0,-10);
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                back1.Position += new Vector2(0, 10);*/
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                back1.Position += new Vector2(2, 0);
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                back1.Position += new Vector2(-2, 0);

            back1.Update(gameTime);

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
            spriteBatch.Begin();

            back1.Draw(gameTime);
            sprite1.Draw(gameTime);

            spriteBatch.DrawString(font, "Pos:" + sprite1.Position.ToString() , new Vector2(10, 10), Color.White);
            spriteBatch.DrawString(font, "Spd:" + sprite1.Speed.ToString(), new Vector2(10, 30), Color.White);



            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
