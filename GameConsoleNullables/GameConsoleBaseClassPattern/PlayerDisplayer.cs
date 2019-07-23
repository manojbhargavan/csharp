using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBaseClassPattern
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter playerCharacter)
        {
            Console.WriteLine(playerCharacter.DaySinceLastLogin ?? -1);

            //Console.WriteLine((playerCharacter.DaySinceLastLogin.HasValue
            //    ? playerCharacter.DaySinceLastLogin.ToString() : "No value for DaySinceLastLogin"));

            if (!playerCharacter.DateOfBirth.HasValue)
            {
                Console.WriteLine("No Value for DateOfBirth");
            }
            else
            {
                Console.WriteLine(playerCharacter.DateOfBirth);
            }

            if (!playerCharacter.IsNoob.HasValue)
            {
                Console.WriteLine("Unknown --> Is New Player");
            }
            else
            {
                Console.WriteLine((bool)playerCharacter.IsNoob ? "Player is Newbie" : "Player is Experienced");
            }
        }
    }
}
