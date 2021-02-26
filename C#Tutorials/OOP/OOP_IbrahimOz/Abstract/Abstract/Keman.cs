using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Keman : MusiqiAletleri
    {
        public override CalmaTurleri calmaturleri { get => CalmaTurleri.tellicalma; set => Calma_Turu = value; }

        public override string cal()
        {
          return  "Keman calinir";
        }
    }
}
