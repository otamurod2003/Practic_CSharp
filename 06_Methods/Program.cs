using System;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-method
            //writeString("Hello world");
            //string a = returnString("Salom", " dunyo");
            //Console.WriteLine(a);
            //2-method
            //Boshla();
            //Console.WriteLine("Oynadan chiqish uchun istalgan tugmani bosing...");
          

            int ozgaruvchi = 10;
            Console.WriteLine(ozgaruvchi);
            IkkiBarobar(ref ozgaruvchi);
            Console.WriteLine(ozgaruvchi);
            Console.ReadKey();

        }
        static void writeString(string name)
        {
            Console.WriteLine(name + "!!!");
        }
        static string returnString(string a, string b)
        {
            return a + b;
        }
        static void Boshla()
        {
            Console.WriteLine("so'z kiriting: ");
           string soz =  Console.ReadLine();
            Console.WriteLine("Siz {0} deb yozdingiz!", soz);
        }
        static void IkkiBarobar( ref int ozgaruvchi)
        {
          
            ozgaruvchi = ozgaruvchi * 2;
        }
    }
}