using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm2
{
    class TekstilUrun:Urun
    {
        public string KumasTipi { get; set; }
        public string Reng { get; set; }
        public string KumasKalite { get; set; }

        public override decimal KDVLIFiyat()
        {
            return  Fiyat + (Fiyat * 0.5m);
        }
    }
}
