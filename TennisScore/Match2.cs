using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    static class Match2
    {
        //public double Chance { get; private set; }
        static int WhoWin { get; set; }

        private static int S1 { get; set; } = 0;
        private static int S2 { get; set; } = 0;

        static List<Set> Set = new List<Set>();

        private static bool End { get; set; } = false;

        static void AddSet(Set s)
        {
            if (s.WhoWin == 1)
                S1++;
            else S2++;

            Set.Add(s);

            EndMatch();
        }

        static void EndMatch()
        {
            if (S1 == 2)
            {
                End = true;
                WhoWin = 1;
            }
            if (S2 == 2)
            {
                End = true;
                WhoWin = 2;
            }
        }
    }
}
