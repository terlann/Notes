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
    public class UrunlerORM
    {
        //Select
        public static  DataTable UrunlerSelect()
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_Urunler_Select", Tools.Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Insert
        public static bool UrunlerInsert(Urunler u)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunler_Insert", Tools.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Adi", u.UrunAdi);
            cmd.Parameters.AddWithValue("@Qiymeti", u.Fiyat);
            cmd.Parameters.AddWithValue("@Stok", u.Stok);
            cmd.Parameters.AddWithValue("@KID", u.KategoriID);
            cmd.Parameters.AddWithValue("@TID", u.TedarikciID);
            return Tools.ExecuteNonQuery(cmd);
        }
        //Update
        public static bool UrunlerUpdate(Urunler u)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunler_Update", Tools.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", u.UrunID);
            cmd.Parameters.AddWithValue("@Adi", u.UrunAdi);
            cmd.Parameters.AddWithValue("@Qiymeti", u.Fiyat);
            cmd.Parameters.AddWithValue("@Stok", u.Stok);
            return Tools.ExecuteNonQuery(cmd);
        }
        //Delete
        public static bool UrunlerDelete(Urunler u)
        {
            SqlCommand cmd = new SqlCommand("prc_Urunler_Delete", Tools.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", u.UrunID);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
