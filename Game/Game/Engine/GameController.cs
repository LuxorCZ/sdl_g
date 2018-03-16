using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Engine.Screen;
using Game.Engine.Managers;

namespace Game.Engine
{
    class GameController
    {

        Game.Engine.Screen.Screen screen;
        Utilities.DeltaTime dt = new Utilities.DeltaTime();

        private TileManager tileManager;

        public GameController()
        {

            AssetManager.Init();

            tileManager = new TileManager(20, 20, 16);

            tileManager.fillArrayTemp(AssetManager.GetAsset("01_wall"));

            screen = new Screen.Screen(dt);
            screen.setBackColour(new Utilities.Color(255, 255, 255));

        }

        public void gameLoop()
        {
            screen.handleEvents();

            if (screen.needsUpdating())
            {
                screen.update(tileManager.Tiles);
                dt.updateTime();
            }

        }

        public bool doLoop()
        {
            return !this.screen.doClose();
        }

    }
}
