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

        public MarkerAi(String name, Mark.Type type, Texture2D markTexture): base(name, type, markTexture) {
        
        }

        public override void update(GameWindow window) {
            PlayBoard playBoard = Game1.playBoard;
        }


    }
}
