using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialoqPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFontDialoq_Click(object sender, EventArgs e)
        {
           DialogResult dr= fontDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {

                label1.Text = "Hello World";
                label1.Font = fontDialog1.Font;
                label2.Font = fontDialog1.Font;
            }
        }

        private void btnOpenFileDialoq_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpeg) | * .jpeg | Jpg Dosyası (*.jpg) | *.jpg | Png Dosyası (*.Png) | *.png";
            openFileDialog1.Title = "Sekil secin";
            DialogResult dr = openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
            label2.Text = openFileDialog1.SafeFileName;
           
        }

        private void btnSaveFileDialoq_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {
                label2.Text = saveFileDialog1.FileName;
            }
        }

        private void btnFolderBrowserDialoq_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {
                label2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {
                label2.ForeColor = colorDialog1.Color;
            }
        }
    }
}
