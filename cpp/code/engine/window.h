#include <SDL.h>

class Window
{
    public:
        void init(int width, int height, bool fullscreen);
        void setBackColor(Uint8 r, Uint8 g, Uint8 b);
        void clear();
        void delay(Uint32 ms);
        void handleEvents();
        void render();
        void clean();
        bool doClose();
        void drawSpriteTest(SDL_Surface* sprite);

    private:
        SDL_Window *sdl_window;
        SDL_Renderer *sdl_renderer;
        SDL_Surface *screenSurface;
        int width = 800;
        int height = 600;
        bool isInitialized = false;
        bool isFullscreen = false;
        int flags = 0;
        bool isClosed = true;
        SDL_Texture* testTexture;
};