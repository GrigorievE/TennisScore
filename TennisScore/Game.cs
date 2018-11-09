using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    class Game
    {
        public int WhoServe { get; }
        //public double Chance { get; private set; }
        public int WhoWin { get; private set; }

        public int P1 { get; private set; }
        public int P2 { get; private set; }

        List<Point> Point = new List<Point>();

        public bool End { get; private set; }

        public Game(int whoServe)
        {
            WhoServe = whoServe;
            P1 = 0;
            P2 = 0;
            End = false;
        }

        public void AddPoint(Point p)
        {
            if (p.WhoWin == 1)
                P1++;
            else P2++;

            Point.Add(p);

            EndGame();
        }

        private void EndGame()
        {
            if (P1 >= 4 && P1 - P2 >= 2)
            {
                End = true;
                WhoWin = 1;
                Serve.Change();
            }
            if (P2 >= 4 && P2 - P1 >= 2)
            {
                End = true;
                WhoWin = 2;
                Serve.Change();
            }
        }
    }
}
