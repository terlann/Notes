using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm2
{
    class Elektronika:Urun
    {
        public string Marka { get; set; }
        public string BataryaTipi { get; set; }

        public override decimal KDVLIFiyat()
        {
            return  Fiyat + (Fiyat * 0.25m);
        }
    }
}
