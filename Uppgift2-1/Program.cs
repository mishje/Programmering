using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favoritbok?");
            string bok = Console.ReadLine();
            Console.WriteLine($"Är det sant. Din {bok} är min favoritbok med!");
        }
    }
}