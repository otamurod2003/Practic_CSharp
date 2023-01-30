using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Delegate
{
    class Pul
    {
        public double Miqdor { get; set; } //pul miqdori    
        public string Valuta { get; set; } // Valuta
        public Pul(double miqdor)
        {
            Miqdor = miqdor;
            Valuta = "UZS";
        }
        public delegate void PulDelegati(Pul pul);  
            

    }
}
