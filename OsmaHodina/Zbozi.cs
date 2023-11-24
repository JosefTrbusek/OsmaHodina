using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsmaHodina
{
    public abstract class Zbozi
    {
        public double Cena;
        public string Nazev;
        public string Vyrobce;
        public int MnozstviSkladem;

        public void Naskladni(int pocet)
        {
            MnozstviSkladem += pocet;
        }
        public double Prodej(int pocet)
        {
            MnozstviSkladem -= pocet;
            return pocet * Cena;
        }

        public abstract void NactiParametry();
    }
}
