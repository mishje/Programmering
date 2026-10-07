using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 16 && age <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            else if (age > 19)
            {
                Console.WriteLine("Du är för gammal");
            }
            else
            {
                Console.WriteLine("Du är för ung");
            }
        }
    }
}