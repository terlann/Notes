using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_YapıcıMetot
{
    class Personallar
    {
        //Bu constructor metodudur.
        public Personallar()
        {
            DateTime saveDate = DateTime.Now;
        }
        //Parametre alan Constructor
        public Personallar(string ad)
        {
            Ad = ad;
        }
        public Personallar(string ad, string soyad, DateTime dogumtarixi)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarixi = dogumtarixi;
        }
        internal string Ad;
        internal string Soyad;
        internal DateTime DogumTarixi;
        internal string SHVN;

        /*Constuctor - yapici metotdur
            * -Nesnenin RAM-da yaradilmasini saglar
            * -Constructor metodu tanimlanmazsa varsayilan (default) constructor gecerlidir
            * -Ozumuz class icerisinde Constructor metodu yaza bilerik.
            * -Geriye donus tipi olmayan tek metotdur.
            * -Sinife ozumuz constructor tanimlarsak var sayilan constructor legv edilir.
            * -Sinif icerisinde imzalari ferqli olmaq serti ile birden cox constructor tanimlaya bilerik veee bu sinifden hansi contructora deyer oturduysek yalniz o constructor calisir. 
            * -Constructor metod ve ya metotlarinin adlari sinif adi ile eyni olmagi shertdir.
            */
    }
}
