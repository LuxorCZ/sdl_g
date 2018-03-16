#include "window.h"

void Window::init(int width, int height, bool isFullscreen)
{

    this->width = width; this->height = height; this->isFullscreen = isFullscreen;

    if(SDL_Init(SDL_INIT_EVERYTHING) == 0)
    {
        if(isFullscreen) flags = SDL_WINDOW_FULLSCREEN; else flags = SDL_WINDOW_SHOWN;

        sdl_window = SDL_CreateWindow("window", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, width, height, flags);

        sdl_renderer = SDL_CreateRenderer(sdl_window, -1, 0);
    
        SDL_RenderPresent(sdl_renderer);

        screenSurface = SDL_GetWindowSurface(sdl_window);

        isInitialized = true;
        isClosed = false;

    }

}

void Window::setBackColor(Uint8 r, Uint8 g, Uint8 b)
{
    SDL_SetRenderDrawColor(sdl_renderer, r, g, b, 255);
}

void Window::clear()
{
    SDL_RenderClear(sdl_renderer);
}

void Window::delay(Uint32 ms)
{
    SDL_Delay(ms);
}

void Window::handleEvents()
{
    SDL_Event event;
    SDL_PollEvent(&event);

    switch(event.type)
    {
        case SDL_QUIT:
            isClosed = true;
            break;
        default: 
            break;
    }

}

bool Window::doClose()
{
    return this->isClosed;
}

void Window::drawSpriteTest(SDL_Surface* sprite)
{
    //this->testTexture = SDL_CreateTextureFromSurface(sdl_renderer, sprite);
    SDL_BlitSurface( sprite, NULL, this->screenSurface, NULL );
}

void Window::render()
{
    SDL_RenderClear(sdl_renderer);

    /*if(this->testTexture != NULL)
    {
      SDL_RenderCopy(sdl_renderer, this->testTexture, NULL, NULL);  
    }*/

    SDL_UpdateWindowSurface(sdl_window);

    SDL_RenderPresent(sdl_renderer);
}

void Window::clean()
{
    SDL_DestroyWindow(sdl_window);
    SDL_DestroyRenderer(sdl_renderer);
    SDL_Quit();
}