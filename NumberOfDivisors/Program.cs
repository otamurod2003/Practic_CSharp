//Kiritilgan sonning bo'luvchilarini topuvchi dastur
long number;
Console.WriteLine("Son kiriting: ");
number = Convert.ToInt64(Console.ReadLine());
long[] divisors = new long[number];
divisors[0] = 1;
Console.WriteLine("Sonning 1 dan tashqari bo'luvchilari");
try
{
    for (int i = 1; i < divisors.Length; i++)
    {
        divisors[i] = i + 1;
        if (number % divisors[i] == 0)
            Console.Write(divisors[i] + " ");
    }

}
catch (Exception ex)
{

    Console.Write("Error:" + ex.Message);
}

