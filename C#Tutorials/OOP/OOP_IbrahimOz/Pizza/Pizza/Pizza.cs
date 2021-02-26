using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        public string Adi { get; set; }
        public decimal Qiymeti { get; set; }
        public Olculer Olcusu { get; set; }
        public KenarTip KenarTipi { get; set; }
        public List<string> Mazemeler { get; set; }
        public decimal Summa
        {
            get
            {
                decimal Sum = Qiymeti * (decimal)Olcusu.Carpan;
                Sum += KenarTipi.ElaveQiymet;
                return Sum;
            }
        }
        public override string ToString()
        {
            return Adi;
        }
    }
}
