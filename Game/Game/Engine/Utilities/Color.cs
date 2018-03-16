using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Engine.Utilities
{
    class Color
    {

        private byte r, g, b, a;

        public byte R { get { return this.r; } }
        public byte G { get { return this.g; } }
        public byte B { get { return this.b; } }
        public byte Alpha { get { return this.b; } }

        public Color(byte r, byte g, byte b)
        {
            this.r = r; this.g = g; this.b = b;
            this.a = 0xff;
        }

        public Color(byte r, byte g, byte b, byte a)
        {
            this.r = r; this.g = g; this.b = b;
            this.a = a;
        }

        //todo parsování z ostatních formátů barev!

    }
}
