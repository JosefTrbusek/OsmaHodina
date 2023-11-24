using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasicarna
{
    public class HasicLepsi : IUmiZapojitHadici, IMuzeRezatStromy
    {
        public void PorezStrom()
        {
            Console.WriteLine("Kacim strom");
        }

        public void ZapojHadici(int cisloHydrantu)
        {
            Console.WriteLine("Zapojuji chytre hadici do hydrantu cislo " + cisloHydrantu);
        }
    }
}
