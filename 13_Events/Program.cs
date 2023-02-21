using _13_Events;

class Program
{
    
    public static void Tugma_Click()
    {
        Console.WriteLine("Tugma bosildi:");

    }
    static void Main(string[] args)
    {
        Tugma tugma = new Tugma();
        tugma.Click += new TugmaDelegati(Tugma_Click);
        tugma.Simulation();

        tugma.Click -= new TugmaDelegati(Tugma_Click);

        Console.ReadLine();
    }
}