using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Products:EntityBase
    {
        public Products()
        {
            Status= true;
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public int Categoryid { get; set; }
        public int UnitTypeid { get; set; }
        public bool Status { get; set; }

        public override string PrimaryColumn => "ProductID";
    }
}
