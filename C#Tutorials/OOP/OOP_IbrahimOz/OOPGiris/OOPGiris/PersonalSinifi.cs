using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGiris
{
    class PersonalSinifi
    {
       internal string adi;
       protected internal string soyadi;
       protected internal DateTime dogumtarixi;
       public  string shvn;
        /*
         * Access modifiers-Erisim belirleyicisi
         Varsayilan Private-dir
         * 1-Private: Kisisel anlamdadir. Yalniz bulundugu yapi icerisinde elcatan olur.
         * 2-Internal:Bulundugu proje icerisinde her yerden erisimi saglar. Fakat farkli proje icerisinde erisimi saglanamaz.
         * Protected: Miras alinan sinifler icerisinde erisime izin verir.
         * Protected Internal: Hem miras alinan sinifler icerisinde hemde bulundugu proje icerisinde her yerden erisime icaze verir.
         * Public -Her yerden erisim salana biler.
         */

        public void PersonelleriEkle()
        {
            
        }
    }
}
