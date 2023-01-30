using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _11_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Pul pul = new Pul(3450000);
            PulBoshqaruvchi pulboshqaruvchi = new PulBoshqaruvchi();
            Pul.PulDelegati pulDelegati = new Pul.PulDelegati(pulboshqaruvchi.Usd2Uzs);
            pulboshqaruvchi.pulYuborish(pul, "Agrobank", pulDelegati);

            Console.WriteLine(Environment.NewLine);
            Pul dollar = new Pul(310);
            PulBoshqaruvchi pulBoshqaruvchi =  new PulBoshqaruvchi();
            Pul.PulDelegati dollarDelegat = new Pul.PulDelegati(pulBoshqaruvchi.Uzs2Uzs);
            pulboshqaruvchi.pulYuborish(dollar, "Infinbank", dollarDelegat);
          
        }
    }
}
