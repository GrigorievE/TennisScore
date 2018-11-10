using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    class Set
    {
        public int WhoServe { get; }
        //public double Chance { get; private set; }
        public int WhoWin { get; private set; }

        public int G1 { get; private set; }
        public int G2 { get; private set; }

        List<Game> Game = new List<Game>();

        public bool End { get; private set; }

        public Set(int whoServe)
        {
            WhoServe = whoServe;
            G1 = 0;
            G2 = 0;
            End = false;
            Game.Add(new Game(whoServe));
        }

        public void AddGame(Game g)
        {
            if (g.WhoWin == 1)
                G1++;
            else G2++;

            Game.Add(g);

            EndSet();
        }

        private void EndSet()
        {
            if (G1 == 6 && G1 - G2 >= 2 || G1 == 7)
            {
                End = true;
                WhoWin = 1;
            }
            if (G2 == 6 && G2 - G1 >= 2 || G2 == 7)
            {
                End = true;
                WhoWin = 2;
            }
        }
    }
}
