using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.Entity;

namespace ORM.Facad
{
    public class KategorilerORM
    {
        //Select
        public static DataTable KategoriSelect()
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_Kategoriler_Select", Tools.Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Insert
        public static bool KategorilerInsert(Kategoriler k)
        {
            SqlCommand cmd = new SqlCommand("prc_Kategoriler_Insert", Tools.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Adi", k.KategoriAdi);
            cmd.Parameters.AddWithValue("@Tanimi", k.Tanimi);
            return Tools.ExecuteNonQuery(cmd);
        }
        //Update
        //Delete

        
        
    }
}
