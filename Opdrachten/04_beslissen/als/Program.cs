namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("heb je de sleutel gevonden? (y/n)");
        bool sleutelkwijt = Console.ReadLine() == "n";
        if (sleutelkwijt)
        {
            Console.WriteLine("je bent de sluitel kwijt!");
            Console.WriteLine("de deur blijft dicht");
        }
        else
        {
            Console.WriteLine("de deur gaat open en je kan naar binnen");
        }
        
    }
}
