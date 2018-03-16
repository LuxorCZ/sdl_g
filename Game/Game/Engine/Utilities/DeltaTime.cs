using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Engine.Utilities
{
    class DeltaTime
    {

        private DateTime last;

        public DeltaTime()
        {
            this.last = DateTime.Now;
        }

        public bool hasTimePassed(int ms)
        {
            return (DateTime.Now - last).TotalMilliseconds > ms;
        }

        public void updateTime()
        {
            this.last = DateTime.Now;
        }

        public double getDeltaTime()
        {
            double ms = (last - DateTime.Now).TotalMilliseconds;
            last = DateTime.Now;
            return ms;
        }

    }
}
