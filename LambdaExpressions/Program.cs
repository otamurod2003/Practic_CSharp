namespace LambdaExpressions
{
    public class Progam
    {
        public static void Main(string[] args)
        {
            int[] sonlar = { 15, 25, 16, 12, 18, 20, 19, 21, 22, 23, 24, };

            var sonlarKvadrati = sonlar.Select(x => x * x);
            Console.WriteLine(string.Join(",", sonlarKvadrati));


            List<string> towers = new List<string> { "Tokio", "Kuala Lumpur", "Buenos-Ayres", "Tashkent", "Jakarta", "Moskva" };

            var sortedTowersByLength = towers.Where(text=> text.Length>8); // sorted by length
            sortedTowersByLength = towers.Where(text => text.StartsWith('B'));

            Console.WriteLine(string.Join(",", sortedTowersByLength));

            var orderedTowers = towers.OrderBy(o=> o);
            Console.WriteLine(string.Join("  ", orderedTowers));
        }
    }
}