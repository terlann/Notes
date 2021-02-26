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
    public class Tools
    {
        private static SqlConnection con;

        public static SqlConnection Con
        {
            get {
                if (con==null)
                {
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                }
                return con;
                //return con ==null ? new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString) : con;
            }
           
        }

        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            //try
            //{
            //    if (cmd.Connection.State == ConnectionState.Closed)
            //        cmd.Connection.Open();
            //     int etk =cmd.ExecuteNonQuery();
            //    return etk > 0 ? true : false;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
            //finally
            //{
            //    if (cmd.Connection.State == ConnectionState.Open)
            //        cmd.Connection.Close();
            //}

           
           
            cmd.Connection.Open();
            int etk = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            
            return etk > 0 ? true : false;
        }
    }
}
