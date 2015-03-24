using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Tic_Tac_Toe
{
    class MarkerPlayer: Marker
    {
        private bool isMousePressed;

        /// <summary>
        /// Initialize the player marker
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="markTexture"></param>
        public MarkerPlayer(String name, Mark.Type type, Texture2D markTexture): base(name, type, markTexture)
        {
            
        }

        /// <summary>
        /// Handle click events
        /// </summary>
        /// <param name="window"></param>
        public override void update(GameWindow window)
        {
            MouseState mouse = Mouse.GetState();

            if (mouse.LeftButton.Equals(ButtonState.Pressed) && !isMousePressed && this.PlayerID == Game1.playBoard.ActiveMarker) {
                isMousePressed = true;
                tryToMark(mouse.X, mouse.Y);
            }
            
            if (mouse.LeftButton.Equals(ButtonState.Released) && isMousePressed) {
                isMousePressed = false;
            }
        }
    }
}
