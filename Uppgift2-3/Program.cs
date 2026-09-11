using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in lönen på dina 3 anställda utan mellanslag, skiljda med ett kommatecken.");
            string q = Console.ReadLine();
            int index = q.IndexOf(",");
            int index0 = q.IndexOf(",", index + 1);
            int lön1 = int.Parse(q[..index]);
            int lön2 = int.Parse(q[(index + 1)..index0]);
            int lön3 = int.Parse(q[(index0 + 1)..]);
            Console.WriteLine("Medelvärdet på dina anställdas löner är " + (lön1 + lön2 + lön3) / 3 + "kr.");
            Console.ReadKey(); 
        }
    }
}