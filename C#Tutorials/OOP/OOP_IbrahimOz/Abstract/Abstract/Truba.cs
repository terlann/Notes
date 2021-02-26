using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Truba : MusiqiAletleri
    {
        public override CalmaTurleri calmaturleri { get => CalmaTurleri.Ufluyerek; set => Calma_Turu = value; }

        public override string cal()
        {
            return "Truba calinir";
        }
    }
}
