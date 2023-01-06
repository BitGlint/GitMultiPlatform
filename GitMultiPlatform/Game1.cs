using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GitMultiPlatform
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _misc;
        private int _posX = 100;
        private int _posY = 100;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _misc = Content.Load<Texture2D>("Misc");
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboard.IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            if (keyboard.IsKeyDown(Keys.Left))
            {
                _posX--;
            }
            if (keyboard.IsKeyDown(Keys.Right))
            {
                _posX++;
            }
            if (keyboard.IsKeyDown(Keys.Up))
            {
                _posY--;
            }
            if (keyboard.IsKeyDown(Keys.Down))
            {
                _posY++;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_misc, new Vector2(_posX, _posY), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
