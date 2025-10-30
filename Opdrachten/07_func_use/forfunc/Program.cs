namespace forfunc;

class Program
{
    static void Main(string[] args)
    {
        double[] basis = { 1, 5, 7, 10 };

        for(int i =0; i< basis.Length; i++)
        {
            Console.WriteLine(basis[i] + " keer zichzelf " + Math.Pow(basis[i],basis[i]));
        }
    }
}
