using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_OOP1
{
    public class Shifokor : Hodim,ICloneable
    {
        private int _tajriba;
        public int Tajriba
        {
            get => default;
            set
            {

            }
        }
        public Shifokor(int boy,int ogirlik,decimal maosh,int tajriba)
            :base(boy,ogirlik,maosh)
        {
            _tajriba = tajriba;
        }

        public object Clone()
        {
            return new Shifokor ();
        }
    }
   
}