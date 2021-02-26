using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shagird<Ders, int, string> shg = new Shagird<Ders, int, string>();
            shg.Adi = "Terlan";
            shg.Soyadi = "Qurbanov";
            shg.Sinifi = "11b";
            shg.Mektebi = 6;


            MethodGeneric mg = new MethodGeneric();
            mg.MyGenericMetod<int>(120);
            mg.MyGenericMetod<string>("Terlan");

            mg.MyGenericMetod2<string>("Isa");
           
        }
    }
}
