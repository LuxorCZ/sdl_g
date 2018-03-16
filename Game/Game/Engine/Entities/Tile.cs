using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Engine.Entities
{
    class Tile : Entity
    {

        private Sprite sprite;

        public Sprite Sprite { get { return this.sprite; } }

        public Tile(Sprite s)
        {
            this.sprite = s;
        }

    }
}
