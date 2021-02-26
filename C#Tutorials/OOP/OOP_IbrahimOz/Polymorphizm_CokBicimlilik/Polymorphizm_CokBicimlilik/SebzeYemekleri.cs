using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm_CokBicimlilik
{
    class SebzeYemekleri:Yemekler
    {
        public string SebzeTipi { get; set; }
        public string SuluSusuz { get; set; }

        public override string SunumSekli()
        {
            return "Yaninda qatiq";
        }
        //Override metodu ezmek menasini verir yani calisdirigi metodun seklini deyisdirmek ucun istifade olunur.
    }
}
