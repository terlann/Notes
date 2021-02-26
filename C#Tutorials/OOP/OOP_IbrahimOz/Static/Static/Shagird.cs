using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Shagird
    {
        public Shagird()
        {
            ShagirdSayi++;
        }
        public string adi { get; set; }
        public string soyad { get; set; }
        public string mekteb { get; set; }
        public string sinif { get; set; }
        public static int ShagirdSayi { get; set; }

        /*
         * Static yazdigimiz zaman sinifdan property almadan noqte(.) qoyaraq ulasa bilerik.
         */

        public static void Save()
        {
            // Statik metod icerisinde yalniz statik olan propertilere uzalisa biler. static olmayanlara ulasila bilmez
        }
    }
}
