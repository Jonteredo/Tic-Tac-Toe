using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    public abstract class Mark: TicTacToeObject
    {
        public enum Type {
            CIRCLE,
            CROSS
        }

        private Type type;

        public Mark(Type type, Texture2D texture, Vector2 pos): base(texture, pos) {
            this.type = type;
        }

    }
}
