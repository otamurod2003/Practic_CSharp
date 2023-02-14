using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface
{
    class Teacher : Employee
    {
        private string _speciality;
        public string  Speciality { get; set; }

        public Teacher(int boyi, int vazni, decimal maosh, string speciality): base(boyi, vazni, maosh)
        {
            _speciality= speciality;
        }

        public Teacher()
        {

        }
    }
}
