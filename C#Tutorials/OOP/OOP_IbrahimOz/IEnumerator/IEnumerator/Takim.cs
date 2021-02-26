using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator
{
    class Takim
    {
        public Takim()
        {
            Oyuncular = new List<Oyuncu>();
        }
        public string Adi { get; set; }
        public DateTime QurlusTarixi { get; set; }
        public string StadAdi { get; set; }
        public List<Oyuncu> Oyuncular { get; set; }
    }
}
