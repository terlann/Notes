using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Rooms:EntityBase
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RoomTypeid { get; set; }
        public bool Status { get; set; }

        public override string PrimaryColumn => "RoomID";
    }
}
