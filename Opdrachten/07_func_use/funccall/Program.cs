using System.Security.Cryptography.X509Certificates;

namespace _07_func_use;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Clear();
        Console.Write("....X....");
        Console.SetCursorPosition(4, 0);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("?");
        Console.ResetColor();
        Console.WriteLine("\nX was nothing");
    }
}