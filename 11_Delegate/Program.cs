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
            //UZS to USD
            Pul uzs = new Pul(3450000);
            PulBoshqaruvchi pulboshqaruvchi = new PulBoshqaruvchi();
            Pul.PulDelegati pulDelegati = new Pul.PulDelegati(pulboshqaruvchi.UZStoUSD);
            pulboshqaruvchi.pulYuborish(uzs, "Agrobank", pulDelegati);

            //USD to UZS

            Pul Usd = new Pul(305);
            PulBoshqaruvchi pulboshqaruvchi1 = new PulBoshqaruvchi();
            Pul.PulDelegati pulDelegati1 = new Pul.PulDelegati(pulboshqaruvchi1.USDtoUZS);
            pulboshqaruvchi1.pulYuborish(Usd, "SQB", pulDelegati1);
            //Uzs to Rubl
            Pul Rubl = new Pul(15000);
            PulBoshqaruvchi pulboshqaruvchi2 = new PulBoshqaruvchi();
            Pul.PulDelegati pulDelegati2 = new Pul.PulDelegati(pulboshqaruvchi2.UZStoRUBL);
            pulboshqaruvchi2.pulYuborish(Rubl, "KapitalBank", pulDelegati2);

           

        }
    }
}
