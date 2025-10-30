namespace of;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("je wilt je huisdier voeren, kies welk fruit je wilt geven:");
        Console.WriteLine("0. Granaatappel");
        Console.WriteLine("1. Banaan");
        Console.WriteLine("2. Druiven");
        Console.WriteLine("3. Kiwi");
        Console.WriteLine("4. Ananas");
        Console.WriteLine("0, 1, 2, 3 of 4?");
        int keuze = int.Parse(Console.ReadLine());
        int favoriet1 = 1;
        int oke1 = 0;
        int favoriet2 = 2;
        int oke2 = 3;
        int ieuw = 4;
        if (keuze == favoriet1 || keuze == favoriet2)
        {
            Console.WriteLine("JUMJUM!");
        }
        else if (keuze == oke1 || oke2)
        {
            Console.WriteLine("CHOMP");
        }
        else
        {
            Console.WriteLine("BLEH!");
        }
    }
}
