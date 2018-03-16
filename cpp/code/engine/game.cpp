#include <game.h>

void Game::init()
{
    this->initWindow();  
    this->initAssetManager();  
    window->drawSpriteTest(assetmanager->requestSprite("01_wall"));
}

void Game::initWindow()
{
    window = new Window();
    window->init(800, 600, false);
}

void Game::initAssetManager()
{
    assetmanager = new AssetManager();
    assetmanager->init();
}

void Game::cleanWindow()
{
    window->clean();
}

void Game::update()
{
    window->handleEvents();
    window->render();
    
    this->continueRunning = !window->doClose();
}

bool Game::doRun()
{
    return this->continueRunning;
}