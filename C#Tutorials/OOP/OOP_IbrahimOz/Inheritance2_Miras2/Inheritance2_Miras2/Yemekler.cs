using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2_Miras2
{
    class Yemekler
    {
        public string PismeSuresi { get; set; }
        public string Malzemeler { get; set; }
        public string AciTipi { get; set; }
        public string Asci { get; set; }
        public string PismeSekli { get; set; }
        public string PismeYeri { get; set; }

        public string SunumSekli()
        {
            return "Yaninda az pilav ve salata ile";
        }
    }
}
