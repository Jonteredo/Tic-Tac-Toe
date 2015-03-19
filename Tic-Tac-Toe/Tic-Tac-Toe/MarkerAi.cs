using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    class MarkerAi: Marker
    {
        /// <summary>
        /// Initialize a AI player
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="markTexture"></param>
        public MarkerAi(String name, Mark.Type type, Texture2D markTexture): base(name, type, markTexture)
        {
        
        }

        /// <summary>
        /// Make AI move
        /// </summary>
        /// <param name="window"></param>
        public override void update(GameWindow window)
        {
            PlayBoard playBoard = Game1.playBoard;
        }


    }
}
