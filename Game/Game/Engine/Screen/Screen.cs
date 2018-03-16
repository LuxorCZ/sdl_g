using Game.Engine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;
using Game.Engine.Managers;
using Game.Engine.Entities;

namespace Game.Engine.Screen
{
    class Screen : AbstractScreen
    {

        private DeltaTime dt;

        public Screen(DeltaTime dt)
        {
            this.init();
            this.dt = dt;
        }

        public new bool needsUpdating()
        {
            return dt.hasTimePassed(deltaMs);
        }

        public void drawTestingSprite()
        {
            //sprite, src_rect, screen, screenrect
            IntPtr srf = SDL.SDL_LoadBMP("01_wall.bmp");
            SDL.SDL_Rect rect_orig; rect_orig.x = 0; rect_orig.y = 0; rect_orig.w = 16; rect_orig.h = 16;
            SDL.SDL_Rect rect; rect.x = 10; rect.y = 10; rect.w = 16; rect.h = 16;

            SDL.SDL_RenderCopy(screenRenderer, SDL.SDL_CreateTextureFromSurface(screenRenderer, srf), ref rect_orig, ref rect);
        }

        //přejmenovat na draw tiles
        public override void drawSprites(Tile[,] tiles)
        {
            int y_width = tiles.GetLength(0);
            int x_width = tiles.GetLength(1);

            SDL.SDL_Rect rectSprite = tiles[0,0].Sprite.Rect;

            IntPtr texture = SDL.SDL_CreateTextureFromSurface(screenRenderer, tiles[0,0].Sprite.SDLSurface);

            for (int y = 0; y < y_width; y++)
            {

                for(var x = 0; x < x_width; x++)
                {

                    SDL.SDL_Rect rect;
                    rect.x = x * 16; rect.y = y * 16; rect.w = tiles[y, x].Sprite.Width; rect.h = tiles[y, x].Sprite.Height;

                    SDL.SDL_RenderCopy(screenRenderer, texture, ref rectSprite, ref rect);
                }

            }

            //SDL2.SDL.SDL_CreateRGBSurfaceFrom()

        }

    }
}
