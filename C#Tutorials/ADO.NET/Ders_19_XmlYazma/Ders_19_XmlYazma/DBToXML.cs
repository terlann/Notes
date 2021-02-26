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

namespace Ders_19_XmlYazma
{
    public partial class DBToXML : Form
    {
        public DBToXML()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");
        private void btnUrunlerToXml_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_Urunler_Select",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Urunler");
            ds.WriteXml("Urunler.xml");
        }

        private void btnUrunlerXmlDosyasiniListele_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Urunler.xml");
            dataGridView1.DataSource = ds.Tables["Urunler"];
        }
    }
}
