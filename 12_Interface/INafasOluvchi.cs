using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interface
{
    interface INafasOluvchi
    {
        string NafasOlishAzosi
        {
            get
            {
                return "Burun";
            }
           
        }
       public void NafasOlish()
        {
            Console.WriteLine("Nafas olindi");
        }
    }
}
