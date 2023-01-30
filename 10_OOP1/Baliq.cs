using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_OOP1
{
    public class Baliq : INafasOluvchi
    {
        
        #region INafasOluvchi Members
        public  string INafasOlishAzosi
        {
            get
            {
                return "Jabra";
            }
        }
        public void NafasOlish() { }
        #endregion
    }
}