//Kiritgan sonni tub yoki tub emasligini aniqlab beruvchi dastur
//int number;
//Console.WriteLine("Butun son kiriting: ");
//number = Convert.ToInt32(Console.ReadLine());

//for(int i = 2; i < number; i++)
//{
//    if((number % 1 == 0)&&(number % number == 0))
//        Console.WriteLine("Tub son");
//    else
//        Console.WriteLine("Tub son emas");break;
//}
//int son = 1;
//do
//{
//    if (number % son == 0)
//        Console.WriteLine("Tub emas");
//    else
//        Console.WriteLine("Tub");
//    son++;
//}
//while (son >= number);

bool isPrime(int number)
{
    if (number == 1) return false;
    if (number == 2) return true;

    var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

    for (int i = 2; i <= limit; ++i)
        if (number % i == 0)
            return false;
    return true;

}

Console.WriteLine(isPrime(17));

Console.WriteLine(Math.Pow(3.872983346207417,2));
