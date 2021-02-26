using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class RoomTypes:EntityBase
    {
        public int RoomTypesID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public override string PrimaryColumn => "RoomTypesID";
    }
}
