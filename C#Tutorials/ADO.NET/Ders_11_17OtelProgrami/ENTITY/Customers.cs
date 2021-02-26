using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Customers:EntityBase
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string SHVN { get; set; }
        public string TelephoneNumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public MaritalStatusType MaritalStatus { get; set; }
        public GenderType Gender { get; set; }
        public bool Status { get; set; }

        public override string PrimaryColumn => "CustomerID";
    }
    public enum MaritalStatusType
    {
       Single=1,
       Married=2
    }
    public enum GenderType
    {
        Man = 1,
        Woman = 2
    }

}
