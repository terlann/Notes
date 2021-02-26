using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Futbolcu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Boy { get; set; }
        public string Cheki { get; set; }
        public DateTime DogumTarixi { get; set; }

        //Diqqet bu method deyil propertidir
        public int yas { get=>DateTime.Now.Year-DogumTarixi.Year;}//asagidaki kodla eyni seydi)))
        //public int Yas
        //{
        //    get
        //    {
        //        int yas= DateTime.Now.Year - DogumTarixi.Year;
        //        return yas;
        //    }
        //}

    }
}
