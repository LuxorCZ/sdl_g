#include <assetmanager.h>
#include <SDL.h>
#include <stdio.h>
#include <SDL_image.h>
#include <errno.h>

void AssetManager::init()
{
    //this->spritesFolder = ".";

    //SDL_RWFromFile("", "r");    
    IMG_Init(IMG_INIT_PNG);
    this->loadSprites();

}

void AssetManager::loadSprites()
{
    //int size = sizeof(this->textures);

    //this->sprites = new std::map<std::string, SDL_Surface>;

    for(int i = 0; i < 1/*sprites.size()*/; i++)
    {
        std::string path = SDL_GetBasePath() + (this->spritesFolder + this->textures[i] + ".png");

        //sprites[this->textures[i]] = IMG_Load(path.c_str());

        SDL_Surface* test = IMG_Load(path.c_str()); 

        sprites.insert(
            std::make_pair(this->textures[i], 
                           test)
            );        
    }
}

SDL_Surface* AssetManager::requestSprite(std::string name)
{
    return sprites[name];
}