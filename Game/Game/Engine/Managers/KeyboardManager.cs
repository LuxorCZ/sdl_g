using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SDL2;
using Game.Engine.Events;

namespace Game.Engine.Managers
{
    class KeyboardManager
    {

        private Dictionary<SDL.SDL_Keycode, bool> keyStates = new Dictionary<SDL.SDL_Keycode, bool>();

        public KeyboardManager(EventManager em)
        {

            em.SDL_Keydown += handleKeyPress;
            em.SDL_Keydown += handleKeyUp;

            foreach (SDL.SDL_Keycode kc in Enum.GetValues(typeof(SDL.SDL_Keycode)))
            {
                keyStates.Add(kc, false);
            }

        }


        public void update()
        {
           
        }

        public void handleKeyPress(object sender, EventArgs e)
        {
            KeyEventArgs f = (KeyEventArgs)e;
            if (keyStates.ContainsKey(f.KeyCode)) keyStates[f.KeyCode] = true;
        }

        public void handleKeyUp(object sender, EventArgs e)
        {
            KeyEventArgs f = (KeyEventArgs)e;
            if (keyStates.ContainsKey(f.KeyCode)) keyStates[f.KeyCode] = false;
        }

        public bool isKeyPressed(SDL.SDL_Keycode keyCode)
        {
            if(keyStates.ContainsKey(keyCode)) return keyStates[keyCode];
            return false;
        }

    }
}