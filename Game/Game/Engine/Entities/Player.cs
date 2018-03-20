using Game.Engine.Managers;
using Game.Engine.Utilities.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Engine.Entities
{
    class Player : Entity
    {

        private bool isLocal;

        private Sprite sprite;

        public Sprite Sprite { get { return this.sprite; } }
        public Vector2 Position { get { return this.position; } }

        public Player(Vector2 position)
        {
            isLocal = true;
            this.position = position;

            sprite = AssetManager.GetAsset("01_player");

        }

        


    }
}
