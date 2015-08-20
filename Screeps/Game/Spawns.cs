using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace Screeps.Bridge
{
    public class Spawns
    {
        private string basePrefix = "";

        public Spawns(string basePrefix)
        {
            this.basePrefix = basePrefix;

            spawns.Add("Spawn1", new Spawn(prefix(), "Spawn1"));
        }
        
        public string prefix()
        {
            return basePrefix + ".spawns";
        }

        public new Spawn this[string name]
        {
            get {
                return spawns[name];
            }
            set {
                spawns[name] = value;
            }
        }

        public IEnumerator<Spawn> GetEnumerator()
        {
            return spawns.Values.GetEnumerator();
        }

        // internally represent by a dictionary
        private Dictionary<string, Spawn> spawns = new Dictionary<string, Spawn>();

        // #todo external api definition here
    }
}
