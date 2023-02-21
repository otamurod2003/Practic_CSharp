using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12_Interface
{
    public class Fish : INafasOluvchi
    {
        #region INafasOluvchi members
        public string NafasOlishAzosi
        {
            get
            {
                return "Jabra";
            }
        }
        public void NafasOlish()
        {
            Console.WriteLine("nafas olindi");
        }
        #endregion
    }

}