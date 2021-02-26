using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public int YasamDeyeri { get; set; }
        public Silah Silahi { get; set; }
        public void NisanAl()
        {
            //Nisan Alma islemleri yapilacak
        }
        public void Saldir()
        {
            //Saldirma islemleri yapilacaq
        }
    }
}
