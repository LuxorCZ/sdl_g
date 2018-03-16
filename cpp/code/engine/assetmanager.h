#include <string>
#include <SDL.h>
#include <map>

class AssetManager
{

    public: 
        void init();
        SDL_Surface* requestSprite(std::string name);

    private:
        void load();
        void loadSprites();
        std::string folder = "data/assets/";
        std::string spritesFolder = "data\\assets\\sprites\\";
        const std::array<std::string, 1> textures = {"01_wall"};
        std::map <std::string, SDL_Surface*> sprites;
};