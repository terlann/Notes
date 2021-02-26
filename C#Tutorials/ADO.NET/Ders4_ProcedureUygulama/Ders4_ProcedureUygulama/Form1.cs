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

namespace Ders4_ProcedureUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");
        private void MehsullarSelect()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Urunler", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MehsullarSelect();
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("prc_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Adi", txtMehsulAdi.Text).SqlDbType = SqlDbType.NVarChar;  Burdanda Sqldeki melumatin tipini gostermek olur
            cmd.Parameters.AddWithValue("@Adi", txtMehsulAdi.Text);
            cmd.Parameters.AddWithValue("@Qiymeti", nudQiymet.Value);
            cmd.Parameters.AddWithValue("@Stok", NudStok.Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MehsullarSelect();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                SqlCommand cmd = new SqlCommand("prc_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["UrunID"].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MehsullarSelect();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtMehsulAdi.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            SqlCommand cmd = new SqlCommand("prc_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", row.Cells["UrunID"].Value);
            cmd.Parameters.AddWithValue("@Adi", row.Cells["UrunAdi"].Value);
            cmd.Parameters.AddWithValue("@Qiymeti", row.Cells["Fiyat"].Value);
            cmd.Parameters.AddWithValue("@Stok", row.Cells["Stok"].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
