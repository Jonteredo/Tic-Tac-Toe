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
        private Dictionary<Vector2, Mark> marks = new Dictionary<Vector2,Mark>();
        private Marker[] markers = new Marker[2];
        private int activeMarker;

        /// <summary>
        /// Creates a new board
        /// </summary>
        /// <param name="texture">The texture of the board</param>
        /// <param name="size">The size of the board</param>
        public PlayBoard(Texture2D texture, Vector2 size): base(texture, new Vector2(0,0)) {
            this.size = size;
        }

        /// <summary>
        /// Adds the markers to the board
        /// </summary>
        /// <param name="marker1"></param>
        /// <param name="marker2"></param>
        /// <returns></returns>
        public PlayBoard addMarkers(Marker marker1, Marker marker2) {
            markers[0] = marker1;
            markers[1] = marker2;
            return this;
        }

        /// <summary>
        /// Updates the game logic
        /// </summary>
        /// <param name="window"></param>
        public override void update(GameWindow window) {
            if (markers[activeMarker] != null) {
                markers[activeMarker].update(window);
            }
        }

        /// <summary>
        /// Draws board and marks on the screen
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch to draw with</param>
        public override void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle((int)pos.X, (int)pos.Y, (int)size.X, (int)size.Y), Color.White);

            foreach (var piece in marks) {
                piece.Value.draw(spriteBatch);
            }

        }

        /// <summary>
        /// Tries to place mark at given position
        /// </summary>
        /// <param name="x">The position in X, from the left horizontally.</param>
        /// <param name="y">The position in Y, from the top vertecally.</param>
        /// <param name="type">The type of mark to place</param>
        /// <returns>True if it was successful, False if there already is a mark at the position</returns>
        public bool tryToMark(int x, int y, Mark.Type type) {
            //TODO: Ta reda på vilken ruta som kordinaterna är i. 
            //TODO: Testa om det går att lägga till och gör det om det går annars returnera falskt. 
            //TODO: Ändra vem som spelar om plceringen var lyckad
            return false;
        }

        /// <summary>
        /// Check if position is empty of any mark
        /// </summary>
        /// <param name="x">The position in X, from the left horizontally</param>
        /// <param name="y">The position in Y, from the top vertecally</param>
        /// <returns>True if there is no mark, False if there is a mark</returns>
        private bool isEmpty(int x, int y) {
            return false; //TODO kolla så att det är något på positionen x,y. Returera 'true' om det är tom och 'false' om det finns något
        }

        /// <summary>
        /// Getter for the size
        /// </summary>
        public Vector2 Size { get { return size; } }

    }
}
