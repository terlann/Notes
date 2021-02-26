using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Ayxan : Futbolcu, ITopTutaBilable
    {
        public string Toptut()
        {
            return "Topu tutdu";
        }
    }
}
