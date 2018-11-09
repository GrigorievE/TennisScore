using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    static class Serve
    {
        public static int Who;

        public static void Change()
        {
            Who = Who % 2 + 1;
        }
    }
}
