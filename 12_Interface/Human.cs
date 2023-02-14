using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface
{
    class Human : INafasOluvchi
    {
        private int _boyi;
        private int _vazni;
        public int Boyi  { get; set; }
        public int Vazni { get; set; }
        public string Ismi { get; set; }

        public Human(int boyi, int vazni )
        {
            _boyi = boyi;
            _vazni = vazni;
        }
        public Human()
        {

        }



        public void NafasOlish()
        {
            throw new NotImplementedException();
        }
    }
}
