using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ORMBase<TT> : IORM<TT>
    {
        Type TipGetir 
        {
            get
            {
                return typeof(TT);
            }
        }
        public bool Delete(int id)
        {
            TT ent = Activator.CreateInstance<TT>();
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Delete", TipGetir.Name), Tools.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo propInfo = TipGetir.GetProperty("PrimaryColumn");
            string prmAdi = "@" + propInfo.GetValue(ent);
            cmd.Parameters.AddWithValue(prmAdi, id);
            return Tools.ExecuteNonQuery(cmd);

        }

        public bool Insert(TT ent)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", TipGetir.Name), Tools.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] propertys = TipGetir.GetProperties();
            foreach (PropertyInfo pi in propertys)
            {
                if (pi.Name == "PrimaryColumn")
                    continue;
                string prmAdi = "@" + pi.Name;
                object prmValue = pi.GetValue(ent);
                cmd.Parameters.AddWithValue(prmAdi, prmValue);
            }
            return Tools.ExecuteNonQuery(cmd);
        }

        public DataTable Select()
        {
            SqlDataAdapter da = new SqlDataAdapter(string.Format("prc_{0}_Select", TipGetir.Name), Tools.Con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Update(TT ent)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Update", TipGetir.Name), Tools.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] properties = TipGetir.GetProperties();
            foreach (PropertyInfo pi in properties)
            {
                if (pi.Name == "PrimaryColumn")
                    continue;
                string prmAdi = "@"+pi.Name;
                object prmValue = pi.GetValue(ent);
                cmd.Parameters.AddWithValue(prmAdi, prmValue);
            }
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
