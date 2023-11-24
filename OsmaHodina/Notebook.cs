using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsmaHodina
{
    public class Notebook : Zbozi
    {
        public double Vaha;
        public double Velikost;
        public bool MaMechaniku;

        public override void NactiParametry()
        {
            Console.WriteLine("Zadej vahu");
            Vaha=Convert.ToDouble(Console.ReadLine());
        }
    }
}
