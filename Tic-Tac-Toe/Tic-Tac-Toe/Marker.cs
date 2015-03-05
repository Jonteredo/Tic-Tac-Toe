using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Tic_Tac_Toe
{
    public abstract class Marker
    {

        private String name;
        private Mark.Type type;

        /// <summary>
        /// Creates a new Marker object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public Marker(String name, Mark.Type type) {
            this.name = name;
            this.type = type;
        }

        /// <summary>
        /// Tries to mark the given position with the type of the Marker
        /// </summary>
        /// <returns>True if it was successful, False if there was a mark at the position</returns>
        public bool tryToMark(int x, int y) {
            return Game1.playBoard.tryToMark(x, y, type);
        }

        /// <summary>
        /// Updates the marker
        /// </summary>
        /// <param name="window"></param>
        public virtual void update(GameWindow window) {
            //TODO: Test om musen har blivit klickad och testa med att placera en Mark
        }


    }
}
