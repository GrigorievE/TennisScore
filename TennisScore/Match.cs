﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    class Match
    {
        //public double Chance { get; private set; }
        public int WhoWin { get; private set; }

        public int S1 { get; private set; }
        public int S2 { get; private set; }

        List<Set> Set = new List<Set>();

        public bool End { get; private set; }

        public Match()
        {
            S1 = 0;
            S2 = 0;
            End = false;
        }

        public void AddSet(Set s)
        {
            if (s.WhoWin == 1)
                S1++;
            else S2++;

            Set.Add(s);

            EndMatch();
        }

        private void EndMatch()
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
