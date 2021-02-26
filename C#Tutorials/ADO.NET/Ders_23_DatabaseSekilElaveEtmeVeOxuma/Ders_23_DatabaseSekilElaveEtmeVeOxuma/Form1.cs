using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_23_DatabaseSekilElaveEtmeVeOxuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DB_PictureSetGet;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from ProductName", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void sekilElaveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;
            openFileDialog1.Title = "Sekil Sec";
            openFileDialog1.Filter = "Jpg |*.jpg| Png|*.png";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);//BinaryRead oxunan fayli(fs'i) bayt dizisine(byte[]) cevirmek ucundur;
                byte[] sekil = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                SqlCommand cmd = new SqlCommand("Insert into ProductPictures Values('" + id + "','" + sekil + "')", con);
                cmd.Connection.Open();
                int etk = cmd.ExecuteNonQuery();
                if (etk>0)
                {
                    MessageBox.Show("Sekil Elave Olundu");
                }
                else
                {
                    MessageBox.Show("Emeliyyat bas tutmadi");
                }
                cmd.Connection.Close();
            }
        }

        private void sekiliGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;
            FormPictures fp = new FormPictures();
            fp.ProductID = id;
            fp.Hide();
            fp.Show();
        }
    }
}
