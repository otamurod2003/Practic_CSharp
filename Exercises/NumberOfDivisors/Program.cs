int number,divisors,i;
int[] numbers;

try
{
    //Console.Write("Son kiriting:");
    //number = Convert.ToInt32(Console.ReadLine());
    //numbers = new int[number];
    //for (i = 1; i < numbers.Length; i++)
    //{
    //    numbers[i] = number / i;
    //}

    //Console.WriteLine(numbers[i]);

    number = 15 % 5;
    if (number == 0)
        Console.WriteLine("Zo'r");
    else Console.WriteLine("Rasvo");
}
catch (Exception ex)
{

	Console.Write("Xatolik: " + ex.Message);
}
