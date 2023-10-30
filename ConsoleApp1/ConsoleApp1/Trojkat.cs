using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Trojkat : Figura
    {
        public decimal a, h;

        public Trojkat(decimal a, decimal h)
        {
            this.a = a;
            this.h = h;
        }

        public override decimal Pole()
        {
            return a*h/2;
        }
    }
}
