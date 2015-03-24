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
        public PlayBoard(Texture2D texture, Vector2 size): base(texture, new Vector2(0,0))
        {
            this.size = size;
        }

        /// <summary>
        /// Adds the markers to the board
        /// </summary>
        /// <param name="marker1"></param>
        /// <param name="marker2"></param>
        /// <returns></returns>
        public PlayBoard addMarkers(Marker marker1, Marker marker2)
        {
            markers[0] = marker1;
            markers[1] = marker2;

            // Pass the markers[] array index as ID
            marker1.PlayerID = 0;
            marker2.PlayerID = 1;

            return this;
        }

        /// <summary>
        /// Updates the game logic
        /// </summary>
        /// <param name="window"></param>
        public override void update(GameWindow window)
        {
            if (markers[activeMarker] != null)
            {
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

            foreach (var piece in marks)
            {
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
        public bool tryToMark(int x, int y, Mark.Type type)
        {
            Vector2 coords = translateCoords(x, y);

            // Spot is taken
            if (marks.ContainsKey(coords))
            {
                return false;
            }

            // Get the active marker player
            Marker player = markers[activeMarker];

            Vector2 realCoords = translateToRealCoords((int)coords.X, (int)coords.Y);

            // Add a new mark with correct type and coords
            marks.Add(coords, new Mark(player.Type, player.MarkTexture, realCoords, activeMarker));

            // Change active marker to the other player
            activeMarker = (activeMarker == 1) ? 0 : 1;

            // Determine if game is over
            checkGameStatus();

            return true;
        }

        /// <summary>
        /// Check if the game is over (lost, won, tie)
        /// </summary>
        private void checkGameStatus()
        {
            int winnerId = getWinner();

            if (winnerId != -1)
            {
                // set winner to "winnerId" variable
                // reset game
            }
            else if (gameIsTie())
            {
                // set tie
                // reset game
                Console.WriteLine("Game is tie");
            }
        }

        /// <summary>
        /// Check for a winner and return it's ID
        /// </summary>
        /// <returns>Array index of the winner</returns>
        private int getWinner()
        {
            // todo: check for three in a row
            // if winner, return the winner's playerId (mark.OwnerId)

            // No winner
            return -1;
        }

        /// <summary>
        /// Check if game is tie
        /// </summary>
        /// <returns></returns>
        private bool gameIsTie()
        {
            // Check if number of marks is equal to the number of available spots
            return marks.Count == 3 * 3;
        }

        /// <summary>
        /// Translate grid coords to real coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Vector2 translateToRealCoords(int x, int y)
        {
            int realX = x * ((int)size.X / 3) + 10;
            int realY = y * (((int)size.Y) / 3) + 10;

            return new Vector2(realX, realY);
        }

        /// <summary>
        /// Translate real coords to grid coords
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Vector2 translateCoords(int x, int y)
        {
            int clickX = x / ((int) size.X / 3);
            int clickY = y / (((int)size.Y) / 3);

            if (clickY > 2)
            {
                // Clicked outside of the game area
                return new Vector2(clickX, 2);
            }

            return new Vector2(clickX, clickY);
        }

        /// <summary>
        /// Check if position is empty of any mark
        /// </summary>
        /// <param name="x">The position in X, from the left horizontally</param>
        /// <param name="y">The position in Y, from the top vertecally</param>
        /// <returns>True if there is no mark, False if there is a mark</returns>
        private bool isEmpty(int x, int y)
        {
            return isEmpty(new Vector2(x, y));
        }

        private bool isEmpty(Vector2 vec)
        {
            if (marks[vec] == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Getter for the size
        /// </summary>
        public Vector2 Size { get { return size; } }

        /// <summary>
        /// Getter for the activeMarker
        /// </summary>
        public int ActiveMarker { get { return activeMarker; } }
    }
}
