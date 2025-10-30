namespace staticfunc;

class Program
{
    static void Main(string[] args)
    {
        SayHelloWorld(3);
    }

    static void SayHelloWorld()
    {
        Console.WriteLine("hello world!");
    }
}