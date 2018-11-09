using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    class Point
    {
        public int WhoServe { get; private set; }    //readonly int WhoServe;
        //public double Chance;
        public int WhoWin { get; private set; }

        public Point(int whoServe, int whoWin)
        {
            WhoServe = whoServe;
            WhoWin = whoWin;
        }
    }
}
