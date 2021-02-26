using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphizmTostring
{
    class Oyrenci
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string shvn { get; set; }
        public DateTime dogumtarixi { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", ad, soyad, shvn, dogumtarixi);
        }
    }
}
