using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface
{
    class Programmer : Employee
    {
       private string _level ;
       public string Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value; 
            }
        }

        public Programmer(int boyi, int vazni, decimal maosh, string level): base(boyi, vazni, maosh)
        {
            _level = level;
        }

        public Programmer()
        {

        }
    }
}
