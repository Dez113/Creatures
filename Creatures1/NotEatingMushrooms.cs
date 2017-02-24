using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures1
{
    class NotEatingMushrooms : Mushrooms
    {
        public NotEatingMushrooms (string name) : base (name)
        {
            this.name = name;
        }
    }
}
