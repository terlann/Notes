using System;
using System.Collections.Generic;

namespace CodeFirst_SIDU.Models
{
    public partial class UrunlerTest
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<short> Stok { get; set; }
        public Nullable<short> YeniSatis { get; set; }
        public Nullable<short> EnAzYenidenSatisMikatari { get; set; }
        public Nullable<bool> Sonlandi { get; set; }
    }
}
