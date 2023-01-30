using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace conditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            Console.Write("Ismingizni kiriting: ");
            name = Console.ReadLine();
            if (name == "Otamurod")
            {
                Console.WriteLine("Xush kelibsiz xo'jayin");

            }
            else
            {
                Console.WriteLine("Tizimga xush kelibsiz " + name);

            }



            int son = 0;
            Console.Write("1 dan 5 gacha bo'lgan son kiriting:");
            char kiritilganSon = Console.ReadKey().KeyChar;
            int.TryParse(kiritilganSon.ToString(), out son);
            Console.WriteLine(Environment.NewLine);
            switch (son)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("Ikki");
                    break;
                case 3:
                    Console.WriteLine("Uch");
                    break;
                case 4:
                    Console.WriteLine("To'rt");
                    break;
                case 5:
                    Console.WriteLine("Besh");
                    break;
                default:
                    Console.WriteLine("Bunday son tizimda yo'q!!!");
                    break;

            }



        }
    }
}
