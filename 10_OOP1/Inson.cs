using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_OOP1
{
    class Inson : INafasOluvchi
    {
        private int _boy;
        private int _ogirlik;
        public int Boy
        {
            get
            {
                return _boy;
            }
            set
            {
                _boy = value;
            }


        }
        public int Ogirlik
        {
            get
            {
                return _ogirlik;
            }
            set
            {
                _ogirlik = value;
            }


        }

        public string Ism
        {
            get => default;

            set
            {

            }
        }

        public Inson() { }
        public Inson(int boy, int ogirlik)
        {
            boy = _boy;
            ogirlik = _ogirlik;
        }

        #region INafasOluvchi Members
        public string NafasOlish
        {
            get
            {
                return "Burun";
            }

        }
        public void NafasOlishAzosi()
        {
            Console.WriteLine("Nafas olindi...");
        }
        #endregion
    }
}
