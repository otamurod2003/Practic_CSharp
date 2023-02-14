using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Doctor : Person
    { 
        
        public decimal  Salary { get; set; }

        

        public Doctor(int _salary )
        {
            Salary = _salary;

        }
    }
}
