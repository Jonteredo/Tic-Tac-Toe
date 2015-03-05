using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Base object to extend
    /// </summary>
    public abstract class TicTacToeObject
    {
        protected Texture2D texture;
        protected Vector2 pos;

        /// <summary>
        /// Creates a new object
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="pos"></param>
        public TicTacToeObject(Texture2D texture, Vector2 pos) {
            this.texture = texture;
            this.pos = pos;
        }

        /// <summary>
        /// Updates the logic of the object
        /// </summary>
        /// <param name="window"></param>
        public virtual void update(GameWindow window)
        {

        }

        /// <summary>
        /// Draws the object on the screen
        /// </summary>
        /// <param name="spriteBatch"></param>
        public virtual void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, pos, Color.White);
        }
    }
}
