using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter {Name = "Sarah"},
                new PlayerCharacter(),
                null
            };

            //Null-conditional with arrays
            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            //player.Name = "Sharaf";
            //player.DaysSinceLastLogin = 42;
            //player.DateOfBirth = new DateTime(2018, 10, 15);

            //PlayerDisplayer.Write(player);

            //Console.ReadLine();
        }
    }
}
