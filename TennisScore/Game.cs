using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    class Game
    {
        public int WhoServe;
        public double Chance;
        public int WhoWin;

        public int P1;
        public int P2;

        List<Point> PointGame = new List<Point>();

        private bool End;

        public Game(int ws)
        {
            WhoServe = ws;
            P1 = 0;
            P2 = 0;
            End = false;
        }

        public void AddPoint(Point p)
        {
            if (p.WhoWin == 1)
                P1++;
            else P2++;

            PointGame.Add(p);

            EndMetod();
        }

        private void EndMetod()
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
