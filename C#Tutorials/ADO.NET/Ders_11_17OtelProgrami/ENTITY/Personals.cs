using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Personals:EntityBase
    {
        public int PersonalID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SHVN { get; set; }
        public string TelephoneNumber { get; set; }
        public string Adrress { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public decimal Salary { get; set; }
        public bool Status { get; set; }

        public override string PrimaryColumn => "PersonalID";
    }
}
