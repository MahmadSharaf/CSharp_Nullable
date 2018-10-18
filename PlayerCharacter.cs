using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Nullable
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }
        public int Health { get; set; } = 100;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
            DateOfBirth = null;         //null can now be used instead of magic numbers
            DaysSinceLastLogin = null;
        }

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //? replaced by NullDefence class
            //xif (_specialDefence != null)
            //x{
            //x    damageReduction = _specialDefence.CalculateDamageReduction(damage);
            //x}
            

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}");
        }
    }
}
