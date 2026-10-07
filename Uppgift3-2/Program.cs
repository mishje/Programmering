using System; 
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool student = false;
            bool valid = false;
            while (valid == false)
            {
            Console.WriteLine("Har du gått ut gymnasiet? (j/n)");
                string svar = Console.ReadLine().ToLower();
                switch (svar)
                {
                    case "j":
                        student = false;
                        valid = true;
                        break;
                    case "n":
                        student = true;
                        valid = true;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt svar, svara Ja(j) eller Nej(n)");
                        break;
                }
            }
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            if (age > 22 && student == false)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter anan personal just nu.");
            }
        }
    }
}