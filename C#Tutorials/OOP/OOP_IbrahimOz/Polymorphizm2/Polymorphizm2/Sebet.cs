using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm2
{
    class Sebet
    {
        public decimal ToplamFiyat { get; set; }
        public void UrunTopla(Urun urn)
        {
            ToplamFiyat += urn.KDVLIFiyat();
        }
    }
}
