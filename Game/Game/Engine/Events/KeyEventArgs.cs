using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;

namespace Game.Engine.Events
{


    /// <summary>
    /// Key event.
    /// </summary>
    class KeyEventArgs : EventArgs
    {

        private SDL.SDL_Keycode keycode;

        public SDL.SDL_Keycode KeyCode { get { return keycode; } }

        public KeyEventArgs(SDL.SDL_Keycode keycode)
        {
            this.keycode = keycode;
        }
    }
}
