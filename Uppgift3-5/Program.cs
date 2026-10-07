using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal:");
            Console.WriteLine("Tal 1:");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tal 2:");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            int val = int.Parse(Console.ReadLine());
            switch(val)
            {
                case 1:
                    Console.WriteLine(tal1 + tal2);
                    break;
                case 2:
                    Console.WriteLine(tal1 - tal2);
                    break;
                case 3:
                    Console.WriteLine(tal1 * tal2);
                    break;
                case 4:
                    if (tal2 == 0)
                    {
                        Console.WriteLine("Du kan inte dividera med 0");
                        return;
                    }
                    else
                    {
                        Console.WriteLine((double)tal1 / tal2);
                    }
                    break;
                default:
                    Console.WriteLine("Ogiltigt tal, välj 1-4");
                    break;
            }
        }
    }
}