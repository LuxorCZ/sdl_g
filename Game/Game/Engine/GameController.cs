using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Engine.Screen;
using Game.Engine.Managers;
using Game.Engine.Entities;

namespace Game.Engine
{
    class GameController
    {

        Game.Engine.Screen.Screen screen;
        Utilities.DeltaTime dt = new Utilities.DeltaTime();

        private TileManager tileManager;
        private EventManager eventManager;
        private KeyboardManager keyManager;

        private Player player;

        public GameController()
        {

            AssetManager.Init();

            eventManager = new EventManager();

            keyManager = new KeyboardManager(eventManager);

            screen = new Screen.Screen(dt, eventManager);

            tileManager = new TileManager(screen.Width / TileManager.TILE_WIDTH, screen.Height / TileManager.TILE_HEIGHT, TileManager.TILE_WIDTH);

            tileManager.fillArrayTemp(AssetManager.GetAsset("01_ground"), 0);

            screen.setBackColour(new Utilities.Color(255, 255, 255));

            player = new Player(new Utilities.Math.Vector2(600, 600));

        }

        public void gameLoop()
        {

            eventManager.update();

            //screen.handleEvents();

            if (screen.needsUpdating())
            {
                screen.update(tileManager.getTiles(0));
                screen.drawSprite(player.Sprite, player.Position);
                dt.updateTime();
            }

        }

        public bool doLoop()
        {
            return !this.screen.doClose();
        }

    }
}
