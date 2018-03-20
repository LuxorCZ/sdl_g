using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDL2;
using System.Runtime.InteropServices;
using Game.Engine.Screen;

namespace Game.Engine.Entities
{
    class Sprite : Entity
    {

        /// <summary>
        /// Sprite height derived from the Image instance. Used for creation of the bounding box.
        /// </summary>
        private int width;

        /// <summary>
        /// Gets the sprite's width.
        /// </summary>
        public int Width { get { return this.width; } }

        /// <summary>
        /// Sprite width derived from the Image instance. Used for creation of the bounding box.
        /// </summary>
        private int height;

        /// <summary>
        /// Gets the sprite's height.
        /// </summary>
        public int Height { get { return this.height; } }

        /// <summary>
        /// Contains the SDL surface bytes.
        /// TODO verify if needed
        /// </summary>
        private UInt32[] bytes;

        /// <summary>
        /// 
        /// </summary>
        private IntPtr sdlSurface;

        /// <summary>
        /// Gets the SDL surface.
        /// </summary>
        public IntPtr SDLSurface { get { return this.sdlSurface; } }

        /// <summary>
        /// SDL texture pointer.
        /// </summary>
        private IntPtr sdlTexture;

        /// <summary>
        /// Gets the SDL texture. 
        /// TODO create at initialisation!!!
        /// </summary>
        public IntPtr SDLTexture { get {
                if(sdlTexture == IntPtr.Zero) sdlTexture = SDL.SDL_CreateTextureFromSurface(AbstractScreen.screenRenderer, sdlSurface);
                return this.sdlTexture;
            } }

        /// <summary>
        /// Bounding box of the sprite.
        /// </summary>
        private SDL.SDL_Rect rect;

        public SDL.SDL_Rect Rect { get { return this.rect; } }

        /// <summary>
        /// Předpokládá 24 bitový obrázek! 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Sprite(UInt32[] bytes, int width, int height)
        {
            this.width = width; this.height = height;
            this.bytes = bytes;

            GCHandle pinnedArray = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            IntPtr pointer = pinnedArray.AddrOfPinnedObject();

            //this.sdlSurface = SDL.SDL_CreateRGBSurfaceWithFormatFrom(pointer, width, height, 32, 4 * width, SDL.SDL_PIXELFORMAT_RGBA8888);

            this.sdlSurface = SDL.SDL_CreateRGBSurfaceFrom(pointer, width, height, 32, width * 4, 0xff000000, 0x00ff0000, 0x0000ff00, 0x000000ff);
            pinnedArray.Free();

            //this.sdlTexture = SDL.SDL_CreateTextureFromSurface(AbstractScreen.screenRenderer, sdlSurface);

            this.rect.h = height; this.rect.w = width; this.rect.x = 0; this.rect.y = 0;

        }



    }
}
