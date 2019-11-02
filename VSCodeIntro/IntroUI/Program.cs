using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel() { FirstName = "Manoj", LastName = "Bhargavan" };
            Console.WriteLine($"{person.FirstName} {person.LastName} is my name");
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a test"); 
        }
    }
}
