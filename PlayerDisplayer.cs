using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Nullable
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name)) //IsNullOrWhiteSpace returns true if string is empty, null, or all whitespace
                Console.WriteLine("Player name is null or all whitespace");            
            else
                Console.WriteLine(player.Name);

            //?Null-checking Operators:
            //!Conditional operator
            //        Checks if it is null                  if false                        if true
            //x int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            //!Null-Coalescing operator
            //        Checks if it is null          if true
            //x int days = player.DaysSinceLastLogin ?? -1;
            //!Null-conditional operator
            // Checks if player is null, if true return null, if not checks if DaysSinceLastLogin is null, if true returns null 
            int? days = player?.DaysSinceLastLogin;

            //x int days = player.DaysSinceLastLogin.GetValueOrDefault(); //GetValueOrDefault return the default value or it can be overridden by an input value to the method
            Console.WriteLine($"{days} days since last login");

            //x if(player.DaysSinceLastLogin.HasValue)      //HasValue is a boolean check which returns whether it has a value or not
            //x     Console.WriteLine(player.DaysSinceLastLogin);                        
            //x else
            //x     Console.WriteLine("No value for DaysSinceLastLogin");

            if (player.DateOfBirth == null)
                Console.WriteLine("No Date of birth specified");            
            else
                Console.WriteLine(player.DateOfBirth);
            

            if (player.IsNoob == null)
                Console.WriteLine("Player newbie status is  unknown");
            
            else if (player.IsNoob == true)
                Console.WriteLine("Player is a newbie");
            
            else
                 Console.WriteLine("Player is experienced");
            
        }
    }
}
