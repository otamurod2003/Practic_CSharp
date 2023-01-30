using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_OOP1
{
    
    public class Hodim : Inson
    {
        private decimal _maosh;
        public int Maosh
        {
            get => default;
           
            set
            {
               
            }
        }
        public Hodim(int boy, int ogirlik, decimal maosh)
            : base(boy, ogirlik)
        {
            _maosh = maosh;
        }
    }
}