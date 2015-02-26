using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private Texture2D playboard;
        private Texture2D cirkel;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle cirkelCoords;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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

            this.cirkelCoords = new Rectangle(325, 165, 150, 150);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            playboard = Content.Load<Texture2D>("playboard");
            cirkel = Content.Load<Texture2D>("cirkel");
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            KeyboardState keyboardState = Keyboard.GetState();

            if (this.cirkelCoords.X <= 800)
            {
                if (keyboardState.IsKeyDown(Keys.Right))
                    this.cirkelCoords.X += 5;
                if (keyboardState.IsKeyDown(Keys.Left))
                    this.cirkelCoords.X -= 5;
            }

            if (cirkelCoords.Y <= 640 - 160)
            {
                if (keyboardState.IsKeyDown(Keys.Down))
                    this.cirkelCoords.Y += 5;
                if (keyboardState.IsKeyDown(Keys.Up))
                    this.cirkelCoords.Y -= 5;
            }

            if (cirkelCoords.X < 0)
            {
                cirkelCoords.X = 0;
            }
            if (cirkelCoords.X > 800)
            {
                cirkelCoords.X = 800;
            }
            if (cirkelCoords.Y < 0)
            {
                cirkelCoords.Y = 0;
            }
            if (cirkelCoords.Y > 800)
            {
                cirkelCoords.Y = 800;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(playboard, new Rectangle(0, 0, 800, 480), Color.White);
            spriteBatch.Draw(cirkel, this.cirkelCoords, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
