using System.Collections.Generic;
using System.Collections;
namespace _12_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //tashqi klasslardan obyektni elon qilish
            Human inson = new Human();  
            Employee xodim = new Employee(); 
            Doctor shifokor = new Doctor();
            shifokor.Ismi = "Nematilla";
            shifokor.Maosh = 12221;
            shifokor.Vazni = 155;
            shifokor.Tajriba = 0;
            shifokor.Boyi = 180;
            Programmer dasturchi = new Programmer();
            Teacher oqituvchi = new Teacher
            {
                Ismi = "Otamurod",
                Speciality = "Matematika va informatika",
                Maosh = 5600000m,
                Boyi = 168,
                Vazni = 64
            };

            string generals = string.Join(",", oqituvchi.Ismi.ToString(), oqituvchi.Speciality.ToString(), oqituvchi.Maosh.ToString(), oqituvchi.Boyi.ToString(), oqituvchi.Vazni.ToString());
            foreach(char q in generals)
            {
                Console.Write(q);
            }
             
            Console.WriteLine(Environment.NewLine +  "Uzunligi:" + generals.Length);
            Fish fish1 = new Fish();
            Console.WriteLine(fish1.NafasOlishAzosi);

            Doctor shifokor2 = (Doctor)shifokor.Clone();
            
            shifokor2.Ismi = "Hayot ";
           
            Console.WriteLine(shifokor.Ismi);
            Console.WriteLine(shifokor2.Ismi);

        }
    }
}