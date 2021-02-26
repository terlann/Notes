using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class SafeMovement:EntityBase
    {
        public int SafeMovementID { get; set; }
        public int Safeid { get; set; }
        public int SafeMovementTypeid { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public override string PrimaryColumn => "SafeMovementID";
    }
}
