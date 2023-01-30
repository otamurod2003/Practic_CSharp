using System;
namespace Loops
{
    class loop
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("For sikli dasturi \n \a");
            For_loop();
            
            Console.WriteLine("While sikli dastur natijasi:  \n");
            while_loop();
            Console.WriteLine("While sikl 2 dastur natijasi: \n");
            while_loop2();
            Console.WriteLine("Do while sikli  dastur natijasi:\n ");
            do_while_loop();
            Console.WriteLine("Foreach sikli dastur natijasi: \n");
            foreach_loop();

        }

        static void For_loop()
        {
          
            string[] a = { "salom", "yaxshimisiz", "helloWorld" };
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }
        }
        static void while_loop()
        {
            Console.WriteLine("While_1 sikli dasturi");
            int[] massive = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int x = 0;
            while (x < 8)
            {
                Console.WriteLine(massive[x]);
                x++;
            }
        }
        static void while_loop2()
        {
            string parol = string.Empty;
            

            while (parol != "parol")
            {
                {
                    Console.WriteLine("Kalit so'zni kiriting:");
                    parol = Console.ReadLine();

                    if (parol != "parol")
                    {
                        Console.WriteLine("Parol xato qaytadan kiriting !!!");
                    }
                    else
                    {
                        Console.WriteLine("Tizimga xush kelibsiz");
                    }
                }
            }

        }
        static void do_while_loop()
        {
            int[] array = { 1, 5, 6, 8, 9, 15, 45, 65, 78 };
            int elem = 0;
            do
            {
                Console.Write(array[elem]+  " ");
                elem++;

            } while (elem < 8);
        }
        static void foreach_loop()
        {
            string[] sedan = new string[5];
            sedan[0] = "Mers";
            sedan[2] = "Cobalt";
            sedan[4] = "Lada Largus";
            Array.Sort(sedan);
            foreach(string brands in sedan)
            {
                Console.WriteLine(brands + "\a");
            }
        }
    }
}