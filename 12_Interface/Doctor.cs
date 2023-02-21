using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface
{
    class Doctor : Employee,ICloneable
    {
        private int _tajriba;
        public int Tajriba { get; set; }

        public Doctor(int boyi, int vazni, decimal maosh, int tajriba): base(boyi,vazni, maosh)
        {
            _tajriba = tajriba;
        }

        public Doctor()
        {

        }

        public object Clone()
        {
            return new Doctor();
        }
    }   
}
