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
            for (int i=0; i< generals.Length; i++)
            {
                Console.Write(generals[i]);


               
            }
             
            Console.WriteLine(Environment.NewLine +  "Uzunligi:" + generals.Length);
        }
    }
}