using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ORM
{
    class Tools
    {
        private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        public static  SqlConnection Con
        {
            get { return con; }
        }

        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            //try
            //{
            //    if (cmd.Connection.State == ConnectionState.Closed)
            //        cmd.Connection.Open();
            //    int etk = cmd.ExecuteNonQuery();
            //    if (cmd.Connection.State == ConnectionState.Open)
            //        cmd.Connection.Close();
            //    return etk > 0 ? true : false;
            //}
            //catch (Exception ex)
            //{

            //    return false;
            //}
            //finally
            //{
            //    cmd.Connection.Close();
            //}
            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();
            int etk = cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();
            return etk > 0 ? true : false;
        }

    }
}
