using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Events
{
    public delegate void TugmaDelegati();
    class Tugma
    {
        public event TugmaDelegati Click;
        public void Simulation()
        {
            if (Click != null)
                Click();
        }
    }

}
