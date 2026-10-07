using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            bool valid = false;
            Console.WriteLine("------Biluthyrning------");
            Console.WriteLine("80kr/h -- Max/dag = 950kr");
            Console.WriteLine("Hur länge vill du hyra en bil? (Timmar i heltal)");
            while (!valid)
            {
                time = int.Parse(Console.ReadLine());
                if (time <= 11)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Summan överskrider max. Ange ett nytt antal timmar " + "(" + (time * 80 - 950) + "kr över max)");
                }
            }
            int summa = time * 80;
            Console.WriteLine($"Ett lån i {time} timmar blir till {summa}kr.");

        }
    }
}