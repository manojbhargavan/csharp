using System;

namespace GameConsoleNullables
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter nandan = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Nandan"
            };

            PlayerCharacter saranya = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Saranya"
            };

            PlayerCharacter manoj = new PlayerCharacter(new NullDefence())
            {
                Name = "Manoj"
            };

            nandan.Hit(10);
            saranya.Hit(10);
            manoj.Hit(10);

            Console.ReadLine();

        }
    }
}
