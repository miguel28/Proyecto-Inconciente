using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Proyecto_Inconsiente.Logic
{
    public class GameLevel : GameObject
    {
        public static GameLevel LoadGameLevel(string fileName, SpriteBatch batch)
        {
            GameLevel level = new GameLevel();
            SystemGameCore.Level instance = SystemGameCore.Level.LoadLevel(fileName);

            if (instance != null)
            {
                string path = Path.GetDirectoryName(fileName);
                string basename = Path.GetFileNameWithoutExtension(fileName);

                level.Collision = new Background(path + "\\" + basename + "_Coll", batch);

                int i = 0;
                foreach (SystemGameCore.Background l in instance.Layers)
                {
                    Background b = new Background(path + "\\" + basename + "_Layer" + i.ToString(), batch);
                    level.Layers.Add(b);
                    i++;
                }
            }

            return level;
        }

        public Background Collision;
        public List<Background> Layers = new List<Background>();
        public bool ShowCollisionMap = false;
        private Color[] pixelColours;

        public GameLevel()
        {
        }

        public override void Update(GameTime gameTime)
        {
            if (pixelColours == null)
            {
                pixelColours = new Color[Collision.Texture.Width * Collision.Texture.Height];
                Collision.Texture.GetData<Color>(pixelColours);
            }
            
            Layers.ForEach(x => x.Position = this.Position);
            Collision.Position = this.Position;
        }

        public override void Draw(GameTime gameTime)
        {
            Layers.ForEach(x => x.Draw(gameTime));
            Collision.Draw(gameTime);
        }

        public bool IsColliding (Vector2 collpos)
        {
            return GetPixel((int)collpos.X, (int)collpos.Y).A > 0;
        }

        public Color GetPixel(int x, int y)
        {
            return pixelColours[x + (y * Collision.Texture.Width)];
        }
    }
}
