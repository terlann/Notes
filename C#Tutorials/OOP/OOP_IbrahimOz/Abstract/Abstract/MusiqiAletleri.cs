using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
     abstract class  MusiqiAletleri
    {
       
        /*
         * Abstract- Abstract sinifler diger siniflere miras(inhritanse) verilmek ucun hazirlanmis siniflerdir.
         * Abstract siniflere ozel deyil, her hansi porperty, metot ve diger elemanlara ozel ola biler.
         * Bir metodun abstract olmasi o metodun miras verildiyini siniflerde deyisdirlmey mecburiyyetinde olmasi demekdir.
         * Abstract metodun govdesi olmaz:   public abstract string cal()
         * Abstract metodlar abstract olmayan sinifde ola bilmez.Yeni method abstract-dirsa sinifide abstract olmalidir.
         * Abstract metodlar miras verildiyini sinifde deyisdirilmey mecburiyyetindedir.
         * Abstract sinifler icerisinde abstract olan metod ve ya propertlerin govdesi olmagigi ucun bu siniflerden instance uretilemez.
         * sinif abstract olsada icerisinde abstract olmayan property ve method ola biler.
         */

        public abstract string cal();
        public string Menseyi { get; set; }
        public DateTime IstehsalTarixi { get; set; }
        public  CalmaTurleri Calma_Turu { get; set; }
        public abstract CalmaTurleri calmaturleri { get; set; }

    }
}
