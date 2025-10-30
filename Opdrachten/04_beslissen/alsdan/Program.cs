using System.Runtime.CompilerServices;

namespace alsdan;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("beweegt de speler?");
        bool moving = Console.ReadLine() == "y";
        Console.WriteLine("springt de speler?");
        bool jumping = Console.ReadLine() == "y";
        if (moving && jumping)
        {
            Console.WriteLine("loop en spring");
        }
        else if (moving && !jumping)
        {
            Console.WriteLine("loop");
        }
        else if (!moving && jumping)
        {
            Console.WriteLine("spring");
        }
        else
        {
            Console.WriteLine("idle");
        }
    }
}
