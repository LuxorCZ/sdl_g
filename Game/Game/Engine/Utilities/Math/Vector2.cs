using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Engine.Utilities.Math
{
    class Vector2 : Vector
    {

        private int x;
        private int y;

        public int X { get { return this.x; } }
        public int Y { get { return this.y; } }

        public Vector2(int x, int y)
        {
            this.x = x; this.y = y;
        }

    }
}
