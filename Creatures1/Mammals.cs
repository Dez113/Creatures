﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures1
{
    class Mammals : Animals// млекопитающие
    {
        public Mammals(string name) : base (name)
        {
            this.name = name;
        }
    }
}
