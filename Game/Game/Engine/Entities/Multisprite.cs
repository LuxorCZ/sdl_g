using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Engine.Entities
{
    /// <summary>
    /// Class that holds up to nine sprites.
    /// Possible combinations: 1x3, 2x3, 3x3.
    /// It assumes that sprites will be provided from top to bottom, left to right.
    /// </summary>
    class Multisprite
    {

        private Sprite[,] sprites;

        public Multisprite(Sprite[] sprites)
        {
            if (!(sprites.Length == 9 || sprites.Length == 6 || sprites.Length == 3))
            {
                throw new Exception("Multisprite can hold only nine sprites.");
            }

            for(int i = 0; i < sprites.Length; i++)
            {

            }

            //this.sprites = sprites;
        }

        public Sprite getNortWest()
        {
            return null;
        }

        public Sprite getNortEast()
        {
            return null;
        }

        public Sprite getSouthEast()
        {
            return null;
        }

        public Sprite getSouthWest()
        {
            return null;
        }

    }
}
