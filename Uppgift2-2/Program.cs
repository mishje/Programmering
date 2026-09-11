using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur högt hoppade Elin i cm?");
            int elin = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur högt hoppade Alma i cm?");
            int alma = int.Parse(Console.ReadLine());
            int skillnad = elin - alma;
            Console.WriteLine($"Elin hoppade {skillnad}cm högre än Alma.");
        }
    }
}