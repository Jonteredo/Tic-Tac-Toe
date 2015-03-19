using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    class MarkerSuperAi: Marker
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="markTexture"></param>
        public MarkerSuperAi(String name, Mark.Type type, Texture2D markTexture): base(name, type, markTexture) {
            //Build with the following algoritm http://neverstopbuilding.com/minimax
        }

        public override void update(GameWindow window) {
            PlayBoard playBoard = Game1.playBoard;
        }

    }
}
