using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otabus_Otomosyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBiletSifarisEt_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.fullname = txtFullname.Text;
            fm1.mobilenumber = mtxtMobileNumber.Text;
            if (rdbKisi.Checked)
            {
                fm1.cinsiyyet = "Kisi";
            }
            else
            {
                fm1.cinsiyyet = "Qadin";
            }
            this.Hide();
            fm1.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtFullname.Text);
        }
    }
}
