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

        private Tile[,] tiles;

        public Tile[,] Tiles { get { return this.tiles; } }

        public TileManager(int width, int height, int spriteSize)
        {
            tiles = new Tile[width, height];
            this.width = width; this.height = height;
        }

        public void fillArrayTemp(Sprite s)
        {

            Tile t = new Tile(s);

            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    tiles[y, x] = t;
                }
            }
            

        }

    }
}
