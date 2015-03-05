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
        public enum Type {
            CIRCLE,
            CROSS
        }

        private Type type;

        /// <summary>
        /// Creates a new Mark object
        /// </summary>
        /// <param name="type">The type of the mark</param>
        /// <param name="texture">The texture to use as the mark</param>
        /// <param name="pos">The position of the Mark</param>
        public Mark(Type type, Texture2D texture, Vector2 pos): base(texture, pos) {
            this.type = type;
        }

    }
}
