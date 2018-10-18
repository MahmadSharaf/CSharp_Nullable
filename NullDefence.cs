﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Nullable
{
    class NullDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 0; //Null reference
        }
    }
}
