using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw br = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = br.Draw(textBox1.Text, 50);
        }
    }
}
