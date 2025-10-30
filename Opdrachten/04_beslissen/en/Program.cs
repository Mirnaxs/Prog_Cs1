using System.Formats.Asn1;

namespace en;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Heeft de deur een sleutel nodig? (y/n)");
        bool doorNeedsKey = Console.ReadLine() == "y";
        Console.WriteLine("Heb je een sleutel? (y/n)");
        bool hasKey = Console.ReadLine() == "y";
        Console.WriteLine("je staat voor een deur!");
        if (doorNeedsKey == true) 
        {
            Console.WriteLine("de deur is op slot!");
        }
        if (doorNeedsKey && hasKey)
        {
            Console.WriteLine("je gebruikt de sleutel om de deur te openen!");
        }
        
    }
}
