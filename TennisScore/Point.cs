using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    class Point
    {
        public int WhoServe { get; }    //readonly int WhoServe;
        //public double Chance;
        public int WhoWin { get; }

        public Point(int ws, int ww)
        {
            WhoServe = ws;
            WhoWin = ww;
        }
    }
}
