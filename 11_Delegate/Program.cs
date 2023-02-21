using System.Security.Principal;

namespace _11_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Pul pul = new Pul(232232);
            PulBoshqaruvchi pulBoshqaruvchi = new PulBoshqaruvchi();
            Pul.PulDelegati pulDelegati = new Pul.PulDelegati(pulBoshqaruvchi.UzsToUsd);
            pulBoshqaruvchi.Yuborish(pul, "AGRO", pulDelegati);
            Console.WriteLine(pulDelegati.Method.Name);

            
        }
    }
}
