using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Sifaris
    {
        public Pizza Sifarisler { get; set; }
        public int Eded { get; set; }
        public decimal ButunSifarislerinMeblegi { get; set; }

        public override string ToString()
        {
            string str = "";
            str += Sifarisler.Olcusu.Adi + " ";
            str += Sifarisler.Adi + " ";
            str += Sifarisler.KenarTipi.Adi;
            foreach (string element in Sifarisler.Mazemeler)
            {
                str += element+" , ";
            }
            str = str.Remove(str.Length - 2);
            str += string.Format("\n{0} * {1} = {2}", Eded, Sifarisler.Summa, Eded * Sifarisler.Summa);
            ButunSifarislerinMeblegi = Eded * Sifarisler.Summa;
            return str;
        }
    }
}
