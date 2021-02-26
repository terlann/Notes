using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chart_Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            //chart1.Series["Satilan Mehsullar"].Points.AddXY(5,10);

            SqlCommand cmd = new SqlCommand("Select * from KategoriUzreSatisMiqdari", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Satilan Mehsullar"].Points.AddXY(dr[0], dr[1]);
            }
            con.Close();
        }
    }
}
