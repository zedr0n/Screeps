using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace Screeps.Bridge
{
    public class Spawn
    {
        private string name = "";
        private string basePrefix = "";

        public void createCreep(Creep.Spec spec, string name)
        {
            _createCreep(spec.ToArray(),name);
        }


        [Template("{this.prefix : raw}[{this.name}].createCreep({props : raw}, {name})")]
        private void _createCreep(Creep.Property[] props, string name)
        {

        }

        public Spawn(string basePrefix,string name)
        {
            this.name = name;
            this.basePrefix = basePrefix;
        }

    }
}
