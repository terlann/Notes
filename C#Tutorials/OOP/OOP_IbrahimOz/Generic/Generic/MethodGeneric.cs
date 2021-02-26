using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class MethodGeneric
    {
        //Metodun generic olunmasi
        public void MyGenericMetod<T>(T prm)
        {

        }

        public void MyGenericMetod2<T>(T prm) where T:class
        {

        }
    }
}
