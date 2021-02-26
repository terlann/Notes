using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class UnityType:EntityBase
    {
        public int UnityTypeID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public override string PrimaryColumn => "UnityTypeID";
    }
}
