using System;
namespace Program
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Välkommen till låt-kravs portalen.");
            Console.WriteLine("Du kommer få skriva in hur många minuter och sekunder lång låten du föreslår är. \nUtifrån det ser vi om låten får plats i sändningen. ");
            Console.WriteLine("Hur många minuter lång? (Heltal)");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sekunder lång? (0-59)");
            int sek = int.Parse(Console.ReadLine());
            int tot = min * 60 + sek;
            int minimum = 165;
            int maximum = 260;
            if(tot < minimum) {
            Console.WriteLine("Din låt är för kort");
            return;
            }
            if(tot > maximum)
            {
                Console.WriteLine("Din låt är för lång");
                return;
            }
            Console.WriteLine($"Din låt som är {tot}sekunder lång passar in i intervallet.");
        }
    }
}