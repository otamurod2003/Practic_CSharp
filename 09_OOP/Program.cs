using _09_OOP;
using System;
using System.Text;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Abituriyent abit = new Abituriyent();/*yangi abit obyekti elon qilindi.*/
            abit.Bal = 40;
            Console.WriteLine(abit.Bal);
            abit.Bal = 15;
            Console.WriteLine(abit.Bal);

            //Statik metod shu korinishda chaqiriladi
            Abituriyent.RoyxatdanOtish();

            //Dinamik metod shu ko'rinishda chaqiriladi
            abit.ImtihonTopshirish();          
        }
    }
}