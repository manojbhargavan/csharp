using System;

namespace GameConsoleNullables
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter() { Name = "Manoj", DaySinceLastLogin = 42 };
            PlayerDisplayer.Write(player);

            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter() { Name = "manoj" },
                new PlayerCharacter(),
                null
            };

            var name1 = players?[0]?.Name;
            var name2 = players?[1]?.Name;
            var name3 = players?[2]?.Name;

            PlayerCharacter[] players1 = null;

            var name4 = players1?[0]?.Name;
            var name5 = players1?[1]?.Name;
            var name6 = players1?[2]?.Name;


            Console.ReadLine();

        }
    }
}
