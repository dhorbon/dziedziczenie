using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kolo : Figura
    {
        public decimal r;
        public Kolo(decimal r)
        {
            this.r = r;
        }

        public override decimal Pole()
        {
            return (decimal)3.14*r*r;
        }
    }
}
