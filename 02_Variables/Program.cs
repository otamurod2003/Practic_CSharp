using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace variables
{
    class program
    {
        static void Main(string[] args)
        {
            //o'zgaruvchilarni kengaytirish va toraytirish
            Int32 int32Ozgaruvchi = 65000;
            Int64 int64Ozgaruvchi;
            int64Ozgaruvchi = int32Ozgaruvchi;
            Console.WriteLine("Int32 = Int64 ga keltirildi" + int64Ozgaruvchi);


            int intOzgaruvchi = 50;
            short shortOzgaruvchi = 10;
            shortOzgaruvchi = (short)(intOzgaruvchi + shortOzgaruvchi);
            Console.WriteLine("o'zlashtirilgan qiymat:" + shortOzgaruvchi);

            //o'zgaruvchilarni bir turdan boshqa turga konvertatsiya qilish
            string strOzgaruvchi = string.Empty;
            int intozgaruvchi = 15;
            strOzgaruvchi = Convert.ToString(intozgaruvchi);
            Console.WriteLine("o'zlashtirilgan qiymat:" + strOzgaruvchi);

            //ma'lumot stringdan int turiga o'zgartirildi
            string stringozgaruvchi = "65";
            int intOzgaruvchi3 = 0;
            intOzgaruvchi3 = int.Parse(stringozgaruvchi);
            Console.WriteLine(intOzgaruvchi3);

            //malumotlarni kiritib so'ng konvertatsiya qilish    
            bool sonKiritildi = false;
            float son = 0;
            string text = string.Empty;
            Console.WriteLine("Olmoqchi bo'lgan pul miqdorini kiriting:");
            text = Console.ReadLine();
            sonKiritildi = float.TryParse(text, out son);
            Console.WriteLine("Kiritgan soningiz:" + sonKiritildi);
            if (sonKiritildi)
            {
                Console.WriteLine(String.Format("{0} - pul miqdori hisobingizdan yechhib olindi", text));

            }
            else
            {
                Console.WriteLine("Pul miqdori noto'g'ri kiritildi");
                sonKiritildi = false;
            }

            //C# da o'zgarmaslar
            const string about = "Dastur haqida";
            const int oylar = 12, haftalar = 36, kunlar = 365;
            Console.WriteLine(about + Environment.NewLine + oylar + " " + haftalar + " " + kunlar);
            Console.ReadKey();



        }
    }
}