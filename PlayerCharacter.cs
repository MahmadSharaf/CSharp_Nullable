using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Nullable
{
    class PlayerCharacter
    {   
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = null;         //null can now be used instead of magic numbers
            DaysSinceLastLogin = null;
        }
    }
}
