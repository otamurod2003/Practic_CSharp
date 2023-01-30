using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Delegate
{
    class PulBoshqaruvchi
    {
        //So'mdan aqsh dollariga o'giradi...
        public void Usd2Uzs(Pul pul)
        {
            pul.Valuta = "USD";
            pul.Miqdor /= 11400;
        }

        //AQSH dollaridan so'mga o'giradi

        public void Uzs2Uzs(Pul pul)
        {
            pul.Valuta = "UZS";
            pul.Miqdor *= 11350;

        }

        public void pulYuborish(Pul pul, string bank, Pul.PulDelegati delegati)
        {
            if (delegati.Target != null)
                delegati(pul);
            Console.WriteLine(pul.Miqdor.ToString("0.0000") + " " + pul.Valuta + "  miqdordagi pul" + bank + " bankiga muvaffaqqiyatli o'tkazildi");


        }
    }
}
