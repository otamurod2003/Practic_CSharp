using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Immutable;

namespace Generals
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList metodlari...
            //add metodi
            //ArrayList alist = new ArrayList();
            //alist.Add("Bir");
            //alist.Add("Ikki");
            //alist.Add("To'rt");
            //Console.WriteLine("Alistdagi elementlar soni" + alist.Count);
            ////insert metodi
            //alist.Insert(2, "Uch");
            //foreach (string item in alist)
            //{
            //    Console.WriteLine("List elements: " + item);
            //}
            ////RemoveAt metodi
            //alist.RemoveAt(1);
            //Console.WriteLine(alist.ToString());

            ////Cear() metodi
            //alist.Clear();
            //foreach (string item in alist)
            //{
            //    Console.WriteLine(item);
            //}


            //Ro'yxatlar List<Type>
            List<int> list =new List<int> (10);
            list.Add(1);    
            list.Add(3);    
            list.Add(5);
            list.Add(7);
            list.Add(11);
            foreach(int itemList in list)
            {
                Console.WriteLine(itemList);

            }
            Console.WriteLine("//for loop ");
            for(int i=0; i<list.Count; i++)
            {
                Console.Write(list[i] + " " + "\n");
            }
            list.Insert(1, 8);
            list.Insert(3, 78);
            list.Insert(5, 9);
            list.Insert(7, 4);
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i] + " \n");
            }
            list.Remove(8);
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }

            //Listni tartiblash
            list.Sort();
            for(int k=0;k<list.Count;k++)
            {
                Console.WriteLine(list[k]);
            }
            Console.Write("Ro'yxat ichidan izlash uchun son kiriting: ");
            int son = int.Parse(Console.ReadLine());

            if (list.Contains(son))
            {
                Console.WriteLine($"{son} elementi ro'yxatda bor");
            }
            else
            {
                Console.WriteLine($"{son} elementi ro'yxatda yo'q");
            }
            list.Remove(5);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            //Listd string bilan ishlash
            List<string> shaharlar = new List<string>();
            shaharlar.Add("Tashkent");
            shaharlar.Add("Moskva");
            shaharlar.Add("Kuala Lumpur");
            shaharlar.Add("Texron");
            shaharlar.Add("Ostona");
            shaharlar.Add("Mehiko");
            shaharlar.Add("Keyptaun");
            //shaharlar.Sort();
            

            string withArray = string.Join(",", shaharlar.ToArray());
            Console.WriteLine("Shaharlar: " + withArray);

            int indeks = shaharlar.IndexOf("Ostona");
            Console.WriteLine("Shahar indeksi: " + indeks);

            //agar listdagi elementlar soni 100 tadan ko'p bo'lsa bu metoddan foydalanish tavsiya etiladi...
            int index2 = shaharlar.BinarySearch("Texron");
            Console.WriteLine("Shahar indeksi: " + index2);

            //Dictionary Lugatlar bilan ishlash
            Dictionary<int, string> lugat = new Dictionary<int, string>();
            lugat.Add(1, "Olma");
            lugat.Add(2, "Nok");
            lugat.Add(3, "Shaftoli");
            lugat.Add(4, "Gilos");
            lugat.Add(15, "Anor");
            lugat.Add(45, "Olcha");
            foreach(var mevalar in lugat)
            {
                Console.WriteLine("{0},{1}" , mevalar.Key, mevalar.Value);
            }
        }

    }
}
