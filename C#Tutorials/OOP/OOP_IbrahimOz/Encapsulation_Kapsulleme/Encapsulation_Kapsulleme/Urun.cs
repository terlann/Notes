using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Kapsulleme
{
    class Urun
    {
        //Field
        private string _UserName;

        //property
        public string UserName
        {
            get
            {
                if (_UserName=="admin")
                {
                    return "Xos geldiniz";
                }
                else
                {
                    return "User admin deyilsiniz zehmet olmasa qeydiyyatdan kecin";
                }
               
            }
            set
            {
                if (value=="admin")
                {
                    _UserName = value;
                }
                
            }
        }

        private decimal fiyat;
        
        public decimal Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                fiyat = value;
            }
        }

        public decimal KDVFiyat
        {
            get
            {
                return Fiyat + (Fiyat * 0.18m);
            }
        }

        public string FullName { get; set; }
    }
    /*Qisaca encapsulation set ve ya get emeliyyati zamani araya her hansi bir emeliyyat(filtirleme) elave etmeyimiz demekdir.
     */

    /*
     * Auto property
      -Auto property arxa plandaki filedini oz icinde tutar ve ayrica field tanimlanamaz.
      -get ve set metodlari deyisdirile bilmez, deyisdirilse auto property pozulur ve arxa plandaki fieldi ozumuz el ile tanitmali olariq.
     */
}
