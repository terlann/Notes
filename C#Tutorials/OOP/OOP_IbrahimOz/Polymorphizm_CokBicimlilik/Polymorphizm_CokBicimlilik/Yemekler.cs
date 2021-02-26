using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm_CokBicimlilik
{
    class Yemekler
    {
        public string PismeSuresi { get; set; }
        public string Malzemeler { get; set; }
        public string AciTipi { get; set; }
        public string Asci { get; set; }
        public string PismeSekli { get; set; }
        public string PismeYeri { get; set; }

        public virtual string SunumSekli()
        {
            return "Yaninda az pilav ve salata ile";
        }
        /*
         * Virtual: Virtual ile isaretlenmis metot deyisdirile bilir anlamina gelir yani vitrtual ile isaretlememiz hemin metodun ezile bilmesini gostermemiz demekdedir ammmaaaa ezile bilme mecburiyyetinde deyil.
         */
    }
}
