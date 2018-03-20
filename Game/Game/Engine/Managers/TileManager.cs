using Game.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Engine.Managers
{
    class TileManager : Manager
    {
        
        private int width;
        private int height;

        private List<Tile[,]> layers = new List<Tile[,]>();

        public TileManager(int width, int height, int spriteSize)
        {
            this.width = width; this.height = height;
        }

        public Tile[,] getTiles(int layer)
        {
            return layers[layer];
        }

        public void fillArrayTemp(Sprite s, int layer)
        {

            layers.Add(new Tile[height, width]);

            Tile t = new Tile(s);

            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    layers[layer][y, x] = t;
                }
            }

        }

        public const int TILE_WIDTH = 32;
        public const int TILE_HEIGHT = 32;

    }
}
