using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm2
{
    class Ekmek:Urun
    {
        public decimal Gramaj { get; set; }
        public string EkmekTipi { get; set; }

        public override decimal KDVLIFiyat()
        {
            return Fiyat + (Fiyat * 0.1m);
        }
    }
}
