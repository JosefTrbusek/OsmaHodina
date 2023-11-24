using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasicarna
{
    public class HasicBezny : IUmiZapojitHadici
    {
        public void ZapojHadici(int cisloHydrantu)
        {
            Console.WriteLine("Zapojuji tupe hadici k hydrantu cislo " + cisloHydrantu);
        }
    }
}
