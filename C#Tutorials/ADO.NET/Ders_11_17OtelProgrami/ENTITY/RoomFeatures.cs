using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class RoomFeatures:EntityBase
    {
        public int Roomid { get; set; }
        public int Featuresid { get; set; }
        public short Value { get; set; }

        public override string PrimaryColumn => "Roomid";
    }
}
