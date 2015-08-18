using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeps.Bridge
{
    public class Creep
    {
        public sealed class Property
        {
            private readonly string name;
            private readonly string value;

            public static readonly Property WORK = new Property("WORK", "WORK");
            public static readonly Property CARRY = new Property("CARRY", "CARRY");
            public static readonly Property MOVE = new Property("CARRY", "CARRY");

            private Property(string name, string value)
            {
                this.name = name;
                this.value = value;
            }

            public override string ToString()
            {
                return name;
            }
        }

        public class Spec
        {
            public Property this[int i]
            {
                get { return spec[i]; }
                set { spec[i] = value; }
            }

            public Property[] ToArray()
            {
                return spec.ToArray<Property>();
            }

            public int Count()
            {
                return spec.Count;
            }

            public IEnumerator<Property> GetEnumerator()
            {
                return spec.GetEnumerator();
            }

            public List<Property> spec = new List<Property>();
        }
    }
}
