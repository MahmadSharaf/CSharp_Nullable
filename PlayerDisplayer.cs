using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if(player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }
            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No Date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
        }
    }
}
