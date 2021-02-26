using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_Kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            //u.UserName = textBox1.Text;
            u.Fiyat = 10;
            MessageBox.Show(u.KDVFiyat.ToString());
        }
    }
}
