﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Nullable
{
    class DiamondSkinDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 2;
        }
    }
}