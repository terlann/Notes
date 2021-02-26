using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deyer_ve_ReferansTiplerSuper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] city1 = new string[] { "Quba", "Sumqayit", "Baki" };
            string[] city2 = new string[] { "Gence", "Oguz", "Balaken" };//Heap alaninda tutulan bu referans tipli deyer Stack de qarsiligi olmadigi ucun avtomatik silinecey ve bunada Garbage Collection deyilir{ "Gence", "Oguz", "Balaken" };
            city2 = city1;
            city1[1] = "Sheki";
            textBox1.Text = city2[0];//?
            
        }
    }
}
