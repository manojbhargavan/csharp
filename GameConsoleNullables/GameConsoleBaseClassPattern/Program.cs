using System;

namespace GameConsoleBaseClassPattern
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

            PlayerCharacter manoj = new PlayerCharacter(SpecialDefence.Null)
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
