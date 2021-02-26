using System;
using System.Collections.Generic;

namespace CodeFirst_SIDU.Models
{
    public partial class Nakliyeciler
    {
        public Nakliyeciler()
        {
            this.Satislars = new List<Satislar>();
        }

        public int NakliyeciID { get; set; }
        public string SirketAdi { get; set; }
        public string Telefon { get; set; }
        public virtual ICollection<Satislar> Satislars { get; set; }
    }
}
