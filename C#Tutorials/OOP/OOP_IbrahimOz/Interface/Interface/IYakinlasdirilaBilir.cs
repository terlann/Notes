using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IYakinlasdirilaBilir
    {
        /*
         * Interface icerisinde method, property,indec=xleyici ve eventler xariicinden bir sey olmaz.
         * Interface icerisindeki elemanlarin abstract siniflardaki kimi govdesi olmaz.
         * Abstractdan ferqi1: Abstract sinifleri diger siniflere yalniz bir defe implemente ede biliyoruz amma interfacelerde inteface'i istediyimiz qeder classlara impleement ede bilerik.
         * Abstractdan ferqi 2: Abstract siniflerde abstract olmayan bir methodun govdesi yazila bildiyi halda interfacelerde bu mumkun deyil.
         * Abstractda ferqi 3: Interfaceler daxilinde access modify olmaz default olaraq ozleri avtomatik publish goturur.
         * Interface siniflerden instance uretilemez.
         */

        string Yaxinlasdir();
    }
}
