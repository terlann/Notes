using Polymorphizm_CokBicimlilik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm_CokBicimlilik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SunumSekliniGoster(Yemekler ymk)
        {
            MessageBox.Show(ymk.SunumSekli());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtYemekleri ey = new EtYemekleri();
            SunumSekliniGoster(ey);
            //MessageBox.Show(ey.SunumSekli());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sb = new SebzeYemekleri();
            SunumSekliniGoster(sb);
            //MessageBox.Show(sb.SunumSekli());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraSicaklar ar = new AraSicaklar();
            SunumSekliniGoster(ar);
           // MessageBox.Show(ar.SunumSekli());
        }

    }
}
