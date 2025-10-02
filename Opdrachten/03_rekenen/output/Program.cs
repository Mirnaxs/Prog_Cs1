namespace output;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int a = 1;
        double b = 1.9;
        float vx = 9.87f;
        bool ja = true;
        int peren = 13;
        int appels = 25;

        Console.WriteLine($"Mijn int met de naam a heeft als waarde {a}");
        Console.WriteLine($"Mijn double met de naam b heeft als waarde {b}");
        Console.WriteLine($"Mijn float met de naam vx heeft als waarde {vx}");
        Console.WriteLine($"Mijn bool met de naam ja is {ja}");
        Console.WriteLine($"Ik heb {appels} appels en {peren} peren");
        
    }
}
