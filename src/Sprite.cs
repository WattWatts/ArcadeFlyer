using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ArcadeFlyer2D
{

    class Sprite
    {
        private Vector2 postion;
        private Vector2 spriteImage;
        private float spriteWidth;

        public float spriteHeight
        {
            get
            {
                float scale = spriteWidth / spriteImage.Width;
                return spriteImage.Height * scale;
            }
        }

        public Rectangle PositionRectangle
        {
            get
            {
                return new Rectangle((int)position.X,(int)position.Y, (int)spriteWidth, (int)SpriteHeight);
            }
        }

        public Sprite(Vector2 position)
        {
            this.position = position;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(spriteImage, PositionRectangle, Color.White);
        }

    }
}