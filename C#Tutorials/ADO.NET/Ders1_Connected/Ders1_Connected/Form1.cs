using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1_Connected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");
            // con.ConnectionString = @"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("Select * from Urunler", con);
            //cmd.CommandText = "Select * from Urunler";
            //cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string MehsulunAdi = dr["UrunAdi"].ToString();
                string Qiymet = dr["Fiyat"].ToString();
                string Stok = dr["Stok"].ToString();
                listBox1.Items.Add(string.Format("{0} - {1} - {2}", MehsulunAdi, Qiymet, Stok));
            }
            con.Close();
        }
    }
}
