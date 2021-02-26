using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm_CokBicimlilik
{
    class AraSicaklar:Yemekler
    {
        public override string SunumSekli()
        {
            return "Kartosqa qizartmasi ve ayran";
        }
        //Override metodu ezmek menasini verir yani calisdirigi metodun seklini deyisdirmek ucun istifade olunur.
    }
}
