using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prostokat : Figura
    {
        public decimal a, b;

        public Prostokat(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }

        public override decimal Pole()
        {
            return a*b;
        }
    }
}
