using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Facad
{
    public class TedarikcilerORM
    {
        public static DataTable TedarikciSelect()
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_Tedarikciler_Select", Tools.Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
