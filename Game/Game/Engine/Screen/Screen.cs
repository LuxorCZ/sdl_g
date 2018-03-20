using Game.Engine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;
using Game.Engine.Managers;
using Game.Engine.Entities;
using Game.Engine.Utilities.Math;

namespace Game.Engine.Screen
{
    class Screen : AbstractScreen
    {

        private DeltaTime dt;

        public Screen(DeltaTime dt, EventManager em)
        {
            this.init(em);
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

            //IntPtr texture = SDL.SDL_CreateTextureFromSurface(screenRenderer, tiles[0, 0].Sprite.SDLSurface);


            for (int y = 0; y < y_width; y++)
            {

                for(var x = 0; x < x_width; x++)
                {
                    if (tiles[y, x] == null) continue;
                    IntPtr texture = tiles[y, x].Sprite.SDLTexture;
                    SDL.SDL_Rect rect;
                    SDL.SDL_Rect rectSprite = tiles[y, x].Sprite.Rect;
                    rect.x = x * TileManager.TILE_WIDTH; rect.y = y * TileManager.TILE_WIDTH; rect.w = tiles[y, x].Sprite.Width; rect.h = tiles[y, x].Sprite.Height;
                    SDL.SDL_RenderCopy(screenRenderer, texture, ref rectSprite, ref rect);
                }

            }

            //SDL2.SDL.SDL_CreateRGBSurfaceFrom()

        }

        public override void drawSprite(Sprite s, Vector2 position)
        {
            SDL.SDL_Rect rect;
            SDL.SDL_Rect rectSprite = s.Rect;
            rect.x = position.X; rect.y = position.Y; rect.w = s.Width; rect.h = s.Height;
            SDL.SDL_RenderCopy(screenRenderer, s.SDLTexture, ref rectSprite, ref rect);
        }

        public override void drawEntities(List<Entity> entities)
        {
            foreach(Entity e in entities)
            {
            }
        }

    }
}
