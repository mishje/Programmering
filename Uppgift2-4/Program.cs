using System;
    namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du låna bilen?");
            int dag = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt i km planerar du att köra bilen?");
            int dist = int.Parse(Console.ReadLine());
            int total = 300 + dist + 500 * (dag - 1);
            Console.WriteLine($"Du kommer att få betala totalt {total}kr vid lån av denna bil.");
            Console.ReadKey();
        }
    }
}
