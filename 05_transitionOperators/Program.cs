// transition operators : goto, throw, return,break, continue.
using System;
namespace transition_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //break operatori

            for(int j=1; j<=15;j++)
            {
                if (j == 5)
                    {
                    break; 
                    
                    }
                Console.Write(j+" "); 
            }
            //continue operatori
            for (int j = 1; j <= 15; j++)
            {
                if (j <= 5)
                {
                    continue;

                }
                Console.WriteLine(j + " ");
            }
            //goto operatori
            int k = 1;
            while(k<15)
            {
                if(k<5)
                {
                    goto otkaz;
                }
                
            }
        otkaz:Console.WriteLine("Goto operatori orqali UZATILDI!!!");

            //return metodi
           static double return_method(double a, double b)
            {
                return (Math.Pow(a, 2) - Math.Pow(b, 2));
            }
            Console.Write("a sonni kiriting:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b sonni kiriting:");
            double b = Convert.ToInt32(Console.ReadLine());
            double result = return_method(a, b);
            Console.WriteLine("Natija:" + result);

            //throw metodi

        static void throw_metod()
            {
                throw new Exception("Xato yaratildi!!!"); 
            }

            try
            {
                throw_metod();
            }
            catch(Exception xato)
            {
                Console.WriteLine("Catch bloki ishga tushdi" + Environment.NewLine + xato.Message);
            }
        }

    }
}