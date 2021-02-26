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

namespace Ders2_Disconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");
        void SelectUrunler()
        {
            //Disconnectid memari usulu ile datalari lsiteleme usuludur.
            SqlDataAdapter da = new SqlDataAdapter("Select * from Urunler", con);//Sql DataAdapter ozu baglantini acir(con.Open()) icerisindeki select sorgusunu icra edir ve baglantini baglayir(con.Close()); Ve SqlDataAdapterin icerisine yanliz Select sorgusu yazdigimiz zaman ozu baglantini acib baglayir. Misal ucun Insert,Delete,Update sorgulari yazsaq baglantini acib baglamiyacaq.
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectUrunler();
            dataGridView1.Columns["UrunId"].Visible = false;
            dataGridView1.Columns["KategoriId"].Visible = false;
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            //string mehsuladi = txtMehsulunAdi.Text;
            //decimal qiymeti = txtQiymeti.Text;
            //decimal sayi = nudSayi.Value;

            SqlCommand cmd = new SqlCommand(string.Format("Insert into Urunler(UrunAdi,Fiyat,Stok) Values('{0}',{1},{2})", txtMehsulunAdi.Text, txtQiymeti.Text, nudSayi.Value), con);
            con.Open();
           
            int etkilenen = cmd.ExecuteNonQuery() > 0 ? (int)MessageBox.Show("Datalar ugurla elave olundu.") : (int)MessageBox.Show("Emeliyyat bas tutmadi");
            con.Close();
            SelectUrunler();
            
        }

        private void btnKategiler_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.Show();
            this.Hide();
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridviewnun klik olunan setirini textboxlara yazdirmaq
            txtMehsulunAdi.Tag = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value;
            txtMehsulunAdi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            txtQiymeti.Text = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();
            nudSayi.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Stok"].Value);
        }

        private void btnDeyis_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(string.Format("Update Urunler set UrunAdi='{0}',Fiyat={1},Stok={2} where UrunID={3}", txtMehsulunAdi.Text, txtQiymeti.Text, nudSayi.Value, txtMehsulunAdi.Tag), con);
                con.Open();
                int etk = cmd.ExecuteNonQuery();
                SelectUrunler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Melumatlar yenilenerken xeta bas verdi.\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    SqlCommand cmd = new SqlCommand(string.Format("Delete from Urunler where UrunID={0}", txtMehsulunAdi.Tag), con);
                   
                    DialogResult dr=  MessageBox.Show("Melumatlari silmeye eminsiniz?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr==DialogResult.Yes)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        SelectUrunler();
                        MessageBox.Show("Melumatlar Silindi");
                    }
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Silinme Zamani xeta bas verdi\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
