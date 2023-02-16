int max, min, numberOfDigits;
int[] numbers;
Console.Write("Nechta son kiritmoqchisiz: ");
numberOfDigits = Convert.ToInt32(Console.ReadLine());
numbers = new int[numberOfDigits];
try
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{i + 1} sonni kiriting: ");

        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    max = numbers[0];
    min = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];

        if (numbers[i] > max)
            max = numbers[i];

    }

    Console.WriteLine($"Max= {max}, Min={min}");
}
catch (Exception ex)
{

    Console.WriteLine("Xatolik: " + ex.Message);
}
