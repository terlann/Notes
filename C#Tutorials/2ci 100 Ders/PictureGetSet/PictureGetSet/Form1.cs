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
using AForge.Video;
using AForge.Video.DirectShow;

namespace PictureGetSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string imageurl = "";
        int ProductID = 0;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DB_PictureSetGet;Integrated Security=True");
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        private void btnOpenFD_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Sekil Sec";
                ofd.Filter = "Jpg|*.jpg|Png|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into ProductName Values(@Name,@Picture)", con);
            cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
            cmd.Parameters.AddWithValue("@Picture", arr);
            int checkSave = cmd.ExecuteNonQuery();
            con.Close();
            if (checkSave > 0)
            {
                MessageBox.Show("Succeffuly Saved");
                this.productNameTableAdapter.Fill(this.dB_PictureSetGetDataSet.ProductName);
            }
            else
            {
                MessageBox.Show("Don't Save");
            }
            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PictureSetGetDataSet.ProductName' table. You can move, or remove it, as needed.
             this.productNameTableAdapter.Fill(this.dB_PictureSetGetDataSet.ProductName);
            // SqlDataAdapter da = new SqlDataAdapter("Select * from ProductName", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView2.DataSource = dt;
            //dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                cmbCameras.Items.Add(camera.Name);
            }
            cmbCameras.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vcd != null)
                vcd.Stop();
            ProductID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            txtProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            byte[] image = (byte[])dataGridView1.CurrentRow.Cells[2].Value;
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            con.Open();
            SqlCommand cmd = new SqlCommand("Update ProductName Set Name=@Name,Picture=@Picture where ProductID=@ProductID", con);
            cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
            cmd.Parameters.AddWithValue("@Picture", arr);
            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            int checkSave = cmd.ExecuteNonQuery();
            con.Close();
            if (checkSave > 0)
            {
                MessageBox.Show("Succeffuly Update");
                this.productNameTableAdapter.Fill(this.dB_PictureSetGetDataSet.ProductName);
            }
            else
            {
                MessageBox.Show("Don't Update");
            }
        }

        private void btnSekilCek_Click(object sender, EventArgs e)
        {
            vcd.Stop();
        }

        private void btnCameraniAc_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[cmbCameras.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

    }
}
