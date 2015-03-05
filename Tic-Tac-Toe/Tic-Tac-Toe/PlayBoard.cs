using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    public class PlayBoard: TicTacToeObject
    {
        private Vector2 size;

        public PlayBoard(Texture2D texture, Vector2 size): base(texture, new Vector2(0,0)) {
            this.size = size;
        }

        public override void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle((int)pos.X, (int)pos.Y, (int)size.X, (int)size.Y), Color.White);
        }

    }
}
