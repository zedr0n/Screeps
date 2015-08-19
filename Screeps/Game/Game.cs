using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace Screeps.Bridge
{
    [Ignore]
    class Game
    {
        public Spawns spawns = new Spawns(prefix);

        public static string prefix = "Game";
    }
}
