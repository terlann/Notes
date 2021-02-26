using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Isa : Futbolcu, ISavunaBilable
    {
        public string Savun()
        {
            return "Savundu";
        }
    }
}
