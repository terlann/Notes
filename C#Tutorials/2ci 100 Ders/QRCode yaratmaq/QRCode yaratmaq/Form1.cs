using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace QRCode_yaratmaq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //ilk once nuget'den MessagingToolkit QRCode elave etmey yuklemey lazimdi daha sonra using blokuna elave etmey lazimdir;
            QRCodeEncoder qr = new QRCodeEncoder();
            pictureBox1.Image = qr.Encode(textBox1.Text);
        }
    }
}
