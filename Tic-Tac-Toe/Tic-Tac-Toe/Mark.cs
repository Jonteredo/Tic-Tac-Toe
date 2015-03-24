using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    public class Mark: TicTacToeObject
    {
        /// <summary>
        /// The Mark types
        /// </summary>
        public enum Type
        {
            CIRCLE,
            CROSS
        }

        private Type type;
        private int ownerId;

        /// <summary>
        /// Creates a new Mark object
        /// </summary>
        /// <param name="type">The type of the mark</param>
        /// <param name="texture">The texture to use as the mark</param>
        /// <param name="pos">The position of the Mark</param>
        public Mark(Type type, Texture2D texture, Vector2 pos, int ownerId): base(texture, pos)
        {
            this.type = type;
            this.ownerId = ownerId;
        }

        /// <summary>
        /// Draws the mark on the screen
        /// </summary>
        /// <param name="spriteBatch"></param>
        public override void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, pos, Color.White);
        }

        /// <summary>
        /// Get the ID of the player who placed this mark
        /// </summary>
        public int OwnerId { get { return ownerId;  } }

    }
}
