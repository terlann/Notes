using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Terlan : Futbolcu, IHucumaBilable, ISavunaBilable
    {
        public string Hucum(float suret, float mesafe)
        {
            return string.Format("Terlan {0} Mesafeden {1} suretle topu atdi", mesafe, suret);
        }

        public string OyunuKur()
        {
            return "Terlan oyunu kurdu";
        }

        public string Savun()
        {
            return "Terlan Savundu";
        }
    }
}
