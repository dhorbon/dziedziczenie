using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class KontoBankowe
    {
        public string Wlasciciel;
        public int Saldo;

        public KontoBankowe(string wlasciciel, int saldo)
        {
            Wlasciciel = wlasciciel;
            Saldo = saldo;
        }

        public void Wplata(int amount)
        {
            Saldo += amount;
        }

        public void Wyplata(int amount)
        {
            Saldo -= amount;
        }

        //wyswietlanie salda przy pomocy object.Saldo
    }
}
