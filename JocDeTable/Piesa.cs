using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocDeTable
{
    internal class Piesa : Locatie
    {
        private Rectangle corp;
        Brush culoare;
        public Piesa(int loc, int x1, int y1, Rectangle r, Brush culoare) : base(loc, x1, y1)
        {
            this.culoare = culoare;
            this.corp = r;
            corp.X = x1;
            corp.Y = y1;
            corp.Width = 35;
            corp.Height = 35;

        }

        internal Brush getCuloare()
        {
            return culoare;
        }
        internal void mutariPlayer1(int loc, int nr)
        { 
            for (int i = this.loc; i < this.loc + loc; i++)
            {

                if (i < 6)
                {
                    corp.X -= 61;
                }
                if (i == 6)
                {
                    corp.X -= 100;
                    continue;
                }
                if (6 < i && i < 12)
                {
                    corp.X -= 61;
                }
                if (i == 12)
                {
                    corp.X = 80;
                    corp.Y = 500;
                    continue;
                }
                if (12 < i && i < 18)
                {
                    corp.X += 61;
                }
                if (i == 18)
                {
                    corp.X += 100;
                    continue;
                }
                if (18 < i && i <= 24)
                {
                    corp.X += 61;
                }
            }
            this.loc += loc;
            if (nr == 0 && this.loc <= 12)
            { corp.Y = 25;
                this.y1 = corp.Y;
            }
            if (nr == 0 && this.loc > 12)
            { corp.Y = 500; this.y1 = corp.Y; }
            if (nr != 0 && this.loc <= 12)
            { corp.Y = 25 + nr * 35; this.y1 = corp.Y; }
            if (nr != 0 && this.loc > 12)
            { corp.Y = 500 - nr * 35; this.y1 = corp.Y; }
        }
        internal void mutariPlayer2(int loc, int nr)
        {
            for (int i = this.loc; i > this.loc - loc; i--)
            {
                if (i <= 6)
                {
                    corp.X += 61;
                    continue;

                }
                if (i == 7)
                {
                    corp.X += 100;

                }
                if (7 < i && i <= 12)
                {
                    corp.X += 61;
                    continue;

                }
                if (i == 13)
                {
                    corp.X = 80;
                    continue;
                }
                if (13 < i && i < 19)
                {
                    corp.X -= 61;
                    continue;

                }
                if (i == 19)
                {
                    corp.X -= 100;
                    continue;
                }
                if (19 < i && i <= 24)
                {
                    corp.X -= 61;
                    continue;

                }
            }
            this.loc -= loc;
            if (nr == 0 && this.loc <= 12)
            { corp.Y = 25; this.y1 = corp.Y; }
            if (nr == 0 && this.loc > 12)
            { corp.Y = 500; this.y1 = corp.Y; }
            if (nr != 0 && this.loc <= 12)
            { corp.Y = 25 + nr * 35; this.y1 = corp.Y; }
            if (nr != 0 && this.loc > 12)
            { corp.Y = 500 - nr * 35; this.y1 = corp.Y; }

        }
        public Rectangle getForma()
        {
            return corp;
        }
        internal void setX(int x)
        {
            this.x1 = x;
            corp.X = x;
        }
        internal void setY(int y)
        {
            this.y1 = y;
            corp.Y = y;
        }
    }
}
