using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Suppliers:EntityBase
    {
        public int Supplier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Adrress { get; set; }
        public string Mail { get; set; }
        public bool Status { get; set; }

        public override string PrimaryColumn => "Supplier";
    }
}
