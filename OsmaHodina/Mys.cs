using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsmaHodina
{
    public class Mys:Zbozi
    {
        public int PocetTlacitek;
        public bool JeBezdratova;
        public string Barva;

        public override void NactiParametry()
        {
            Console.WriteLine("Nacitani parametru mysi");
        }
    }
}
