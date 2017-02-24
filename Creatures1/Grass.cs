using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures1
{
    class Grass : Plants
    {
        public Grass(string name) : base (name)
        {
            this.name = name;
        }
    }
}
