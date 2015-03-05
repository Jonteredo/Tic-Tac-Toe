using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    public abstract class TicTacToeObject
    {
        protected Texture2D texture;
        protected Vector2 pos;

        public TicTacToeObject(Texture2D texture, Vector2 pos) {
            this.texture = texture;
            this.pos = pos;
        }

        public virtual void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, pos, Color.White);
        }
    }
}
