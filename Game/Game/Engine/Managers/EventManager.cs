using Game.Engine.Events;
using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Engine.Managers
{
    class EventManager
    {

        public EventHandler SDL_Quit;
        public EventHandler SDL_Keydown;
        public EventHandler SDL_Keyup;

        public void update()
        {
            SDL.SDL_Event e;
            if (SDL.SDL_WaitEvent(out e) > 0)
            {
                switch (e.type)
                {
                    case SDL.SDL_EventType.SDL_QUIT:
                    {
                        if (SDL_Quit != null) SDL_Quit(this, EventArgs.Empty);
                        break;
                    }

                    case SDL.SDL_EventType.SDL_KEYDOWN:
                    {
                        KeyEventArgs l = new KeyEventArgs(e.key.keysym.sym);
                        if (SDL_Keydown != null) SDL_Keydown(this, l);
                        break;
                    }

                    case SDL.SDL_EventType.SDL_KEYUP:
                    {
                        KeyEventArgs l = new KeyEventArgs(e.key.keysym.sym);
                        if (SDL_Keyup != null) SDL_Keyup(this, l);
                        break;
                    }

                    default:
                    {
                        break;
                    }

                }
            }
        }

    }
}
