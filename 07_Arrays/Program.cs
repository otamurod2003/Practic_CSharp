using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //massiv 2 ta static va dinamik turlarga bo'linadi

            //1-misol static massiv
            int[] massiv1 = new int[5];
            Console.WriteLine(massiv1[0].ToString());

            //2-misol static massiv
            string[] massiv2 = { "Hp", "Lenovo", "Dell", "Asus", "Mac", "Toshiba" };
            string[] massiv3 = new string[] { "Lenovo", "Mac", "Toshiba", "Lenovo" };
            Console.WriteLine(massiv2[2]);
            Console.WriteLine(massiv3[3]);

            //3-misol dinamik massiv
            Console.Write("Massiv elementlari sonini kiriting:");
            int[] massiv4;

            int i = int.Parse(Console.ReadLine());
            massiv4 = new int[i];
            massiv4[0] = 4;
            foreach (int son in massiv4)
            {
                Console.WriteLine(son + " ");
            }
            //4-misol 
            int[] massiv5 = { 3, 2, 1, 0, 9 };
            int[] massiv6;
            massiv6 = massiv5;
            massiv6[0] = 15;

            for (int k = 0; k < 4; k++)
            {
                Console.Write(massiv5[k].ToString() + " ");
                Console.Write(massiv6[k].ToString() + " ");

            }
            //5-misol
            int[,] massiv7 = new int[9, 9];
            for (int j = 0; j < 9; j++)
            {
                for (int l = 0; l < 9; l++)
                {
                    massiv7[j, l] = j * l;
                    Console.WriteLine(massiv7[j, l].ToString());
                }

            }
            //6-misol
            string[] massiv8 = { "Televizor", "Noutbuk", "Planshet", "Smartfon", "Plesteshn" };
            foreach (string matn in massiv8)
                Console.WriteLine(matn);
            
            Array.Sort(massiv8);
            foreach (string matn in massiv8)
                Console.WriteLine(matn);

            //7-misol
            string sozlar = "Bu sozlar split metodi orqali ajratiladi";
            char text_split = Convert.ToChar(" ");
            string[] text = sozlar.Split(text_split);
            foreach (string splitMetod in text)
            {
                Console.WriteLine(splitMetod);
            }
                
        }
    }
}