using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    public abstract class Marker
    {

        private int playerId;
        private String name;
        private Mark.Type type;
        private Texture2D markTexture;

        /// <summary>
        /// Creates a new Marker object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public Marker(String name, Mark.Type type, Texture2D markTexture) {
            this.name = name;
            this.type = type;
            this.markTexture = markTexture;
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
        public abstract void update(GameWindow window);

        /// <summary>
        /// Getter for the id
        /// </summary>
        public int PlayerID { get { return playerId; } set { playerId = value; } }

        /// <summary>
        /// Getter for the texture of the marker
        /// </summary>
        public Texture2D MarkTexture { get { return markTexture; } }

        /// <summary>
        /// Getter for the name
        /// </summary>
        public String Name { get { return name; } }

        /// <summary>
        /// Getter for the type
        /// </summary>
        public Mark.Type Type { get { return type; } }
    }
}
