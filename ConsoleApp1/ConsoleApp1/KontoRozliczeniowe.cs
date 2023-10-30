using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class KontoRozliczeniowe : KontoBankowe
    {
        public KontoRozliczeniowe(string wlasciciel, int saldo) : base(wlasciciel, saldo)
        {
            Wlasciciel = wlasciciel;
            Saldo = saldo;
        }
    }
}
