using System;

namespace ExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Numbers: ");
            var generator = new OddNumberGenerator();
            foreach(var odd in generator)
            {
                if (odd > 50)
                    break;
                Console.Write(odd + " ");
            }
        }
    }
}
