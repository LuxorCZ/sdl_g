#include <window.h>
#include <assetmanager.h>

class Game
{
    public:
        void init();
        void update();
        bool doRun();
    
    private:
        Window *window;
        AssetManager *assetmanager;
        void initWindow();
        void cleanWindow();
        void initAssetManager();
        bool continueRunning = true;

};