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
    public partial class FormPictures : Form
    {
        public FormPictures()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DB_PictureSetGet;Integrated Security=True");
        public int ProductID { get; set; }
       
        private void FormPictures_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter("Select Picture from ProductPictures where Productid='" + ProductID + "'", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    byte[] picture = (byte[])row.ItemArray[0];
            //    MemoryStream ms = new MemoryStream(picture, 0, picture.Length);
            //    ms.Write(picture, 0, picture.Length);
            //    Image img = Image.FromStream(ms);
            //    pictureBox1.Image = img;
            //    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            //    pictureBox1.Tag = row.ItemArray[0];
            //    return;
            //}
            SqlCommand cmd = new SqlCommand("Select * from ProductPictures where Productid='" + ProductID + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                byte[] picture = (byte[])(dr[2]);
                MemoryStream ms = new MemoryStream(picture);
                pictureBox2.Image = Image.FromStream(ms);
                con.Close();
            }
            
        }
    }
}
