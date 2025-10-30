namespace math;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        double kleiner = 9;
        double groter = 19;

        double welkeIsKleiner = Math.Min(kleiner, groter);
        double welkeIsGroter = Math.Max(kleiner, groter);
        double squareRoot1 = Math.Sqrt(kleiner);
        double squareRoot2 = Math.Sqrt(groter);
        double afgerond = Math.Round(squareRoot2);
        double welkePastBeter = Math.Clamp(value, min, max);

        Console.WriteLine($"\nDe kleinste waarde van {kleiner} en {groter} is {welkeIsKleiner}");
        Console.WriteLine($"{welkeIsGroter} is groter dan {welkeIsKleiner}");
        Console.WriteLine($"De wortel van {kleiner} is {squareRoot1}");
        Console.WriteLine($"Als je de wortel van {groter} afrond is het {afgerond}");
        Console.WriteLine($"Het clamp resultaat van {value} met min {min} en max {max} is {welkePastBeter}");
    }
}
