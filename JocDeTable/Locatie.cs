using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocDeTable
{
    internal class Locatie
    {
        protected int loc;
        protected int x1;
        protected int y1;
        public Locatie(int loc, int x1, int y1)
        {
            this.loc = loc;
            this.x1 = x1;
            this.y1 = y1;
        }
        internal int getLoc()
        {
            return loc;
        }
        internal void setLoc(int loc)
        {
            this.loc = loc;
        }
        internal int getY1()
        {
            return y1;
        }
        internal int getX1()
        {
            return x1;
        }
    }
}

