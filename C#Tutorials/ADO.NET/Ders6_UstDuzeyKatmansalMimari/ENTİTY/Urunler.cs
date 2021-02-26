﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTY
{
    public class Urunler:EntityBase
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public decimal Fiyat { get; set; }
        public short Stok { get; set; }
        public short YeniSatis { get; set; }
        public short EnAzYenidenSatisMiktari { get; set; }
        public bool Sonlandi { get; set; }

         public override string PrimaryColumn => "UrunID";
       
    }
   
}
