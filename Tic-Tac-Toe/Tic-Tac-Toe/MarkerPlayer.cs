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

        public MarkerPlayer(String name, Mark.Type type, Texture2D markTexture): base(name, type, markTexture) {
            
        }

        public override void update(GameWindow window) {
            MouseState mouse = Mouse.GetState();

            if (mouse.LeftButton.Equals(ButtonState.Pressed) && !isMousePressed && ID == Game1.playBoard.ActiveMarker) {
                isMousePressed = true;
                tryToMark(mouse.X, mouse.Y);
            }
            
            if (mouse.LeftButton.Equals(ButtonState.Released) && isMousePressed) {
                isMousePressed = false;
            }

        }


    }
}
