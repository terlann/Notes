using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Categories : EntityBase
    {
        public int CategoriesID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public override string PrimaryColumn => "CategoriesID";
    }
}
