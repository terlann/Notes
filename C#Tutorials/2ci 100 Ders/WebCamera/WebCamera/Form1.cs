using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection fic;  //FilterInfoCollection komputere bagli olan kameralari tutur.
        VideoCaptureDevice vcd; //Videodan sekil tutmaq ucun lazimdi
        private void Form1_Load(object sender, EventArgs e)
        {
            //ilk olaraq NuGetden Aforge.Video'nu ve Aforge.Video.DirectShow bunlari elave edib usinge elave etmey lazimdir.
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                cmbCameras.Items.Add(camera.Name);
            }
            cmbCameras.SelectedIndex = 0;
        }

        private void btnBaslad_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[cmbCameras.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnSekilCek_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Jpg|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName);
                }
            }

        }
    }
}
