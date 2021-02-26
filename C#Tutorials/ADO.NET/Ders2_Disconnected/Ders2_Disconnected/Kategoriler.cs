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

namespace Ders2_Disconnected
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }

        private void KategoriAdd()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kategoriler", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            KategoriAdd();
        }

        

        private void btnKategoriElaveEt_Click(object sender, EventArgs e)
        {
            string KategoriAdi = txtKategoriAdi.Text;
            string KategoriTanimi = txtTanimi.Text;
            SqlCommand cmd = new SqlCommand(string.Format("Insert into Kategoriler(KategoriAdi,Tanimi) Values('{0}','{1}')", KategoriAdi, KategoriTanimi), con);
            con.Open();
            int etkilenen = cmd.ExecuteNonQuery() > 0 ? (int)MessageBox.Show("Kategoriler ugurla elave olundu") :(int) MessageBox.Show("Emeliyyat bas tutmadi");
            con.Close();
            KategoriAdd();

        }
    }
}
