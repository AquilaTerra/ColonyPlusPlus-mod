﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Onion : classes.Type
    {
        public Onion(string name) : base(name)
        {
            this.Register();
        }
    }
}
