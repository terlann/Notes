using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Hucum(IHucumaBilable hcm, float suret,float mesafe)
        {
            return hcm.Hucum(suret,mesafe);
        }
        Terlan t = new Terlan();
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Hucum(t,23.63f,45.2f));

        }

    }
}
