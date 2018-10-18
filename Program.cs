using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Sharaf";
            //player.DaysSinceLastLogin = 42;
            //player.DateOfBirth = new DateTime(2018, 10, 15);

            PlayerDisplayer.Write(player);

            //Console.ReadLine();
        }
    }
}
