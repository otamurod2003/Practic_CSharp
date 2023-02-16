namespace FindingSpaceBeetweenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matn kiriting: ");
            string words = Console.ReadLine();

            int space = 0;
            for (int i=0; i<words.Length; i++)
            {
                if (words[i] == ' ')
                {
                    space++;
                }
            }
            Console.WriteLine("Spaces: "+space);
         
            Console.ReadKey();
        }
    }
}