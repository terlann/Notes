using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Shagird<T,M,S> where T:class where M:struct
    {
        /*Generic tipler: Disharidan bir tip alaraq calismayi saglayan bir yapidir, Yeni propertini tanimladigimiz zaman yox isletdiyimiz zaman tipini gosterin istifade ede bilerik.
         * Bir ve birden cox tip ala biler.
         * Generic tiplerin yerine class, struct ve ya interface'de gondermey mumkundur
         */
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public S Sinifi { get; set; }
        public M Mektebi { get; set; }
        public T AnonimProperty { get; set; }

        public void Save(T prm)
        {
            //Save emeliiyati gorulecey
        }
    }
}
