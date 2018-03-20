using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;
using Game.Engine.Utilities;
using Game.Engine.Entities;
using Game.Engine.Managers;
using Game.Engine.Utilities.Math;

namespace Game.Engine.Screen
{
    abstract class AbstractScreen
    {

        protected IntPtr window;
        public static IntPtr screenRenderer;
        protected static IntPtr screenSurface;

        protected int width = 1024;
        protected int height = 768;

        public int Width { get { return width; } }
        public int Height { get { return height; } }

        protected bool doRun = true;

        protected int refreshRate = 60;
        protected int deltaMs = 0;

        public abstract void drawSprites(Tile[,] tiles);
        public abstract void drawSprite(Sprite s, Vector2 position);
        public abstract void drawEntities(List<Entity> entities);

        public void init(EventManager eventManager)
        {
            window = SDL.SDL_CreateWindow("test", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED, width, height, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

            if(window == null)
            {
                throw new Exception("SDL window could not be initialized.");
            }

            screenRenderer = SDL.SDL_CreateRenderer(window, -1, 0);

            if (screenRenderer == null)
            {
                throw new Exception("SDL renderer could not be initialized.");
            }

            screenSurface = SDL.SDL_GetWindowSurface(window);

            if (screenSurface == null)
            {
                throw new Exception("SDL screen surface could not be initialized.");
            }

            deltaMs = 1000 / refreshRate;

            eventManager.SDL_Quit += OnQuit;

        }

        public void OnQuit(object sender, EventArgs e)
        {
            doRun = false;
        }

        public void setBackColour(Color color)
        {
            SDL.SDL_SetRenderDrawColor(screenSurface, color.R, color.G, color.B, color.Alpha);
        }

        

        /*public void handleEvents()
        {
            SDL.SDL_Event e;
            if(SDL.SDL_WaitEvent(out e) > 0)
            {
                switch (e.type)
                {
                    case SDL.SDL_EventType.SDL_QUIT:
                    {
                        doRun = false;
                        break;
                    }
                    default:
                    {
                        SDL.SDL_Delay(0);
                        break;
                    }
                }
            }
        }*/

        public bool doClose()
        {
            return !doRun;
        }


        public void update(Tile[,] tiles)
        {
            SDL.SDL_RenderClear(screenRenderer);
            this.drawSprites(tiles);
            SDL.SDL_UpdateWindowSurface(this.window);
            SDL.SDL_RenderPresent(screenRenderer);
        }

        public bool needsUpdating()
        {
            return false;
        }

    }
}
