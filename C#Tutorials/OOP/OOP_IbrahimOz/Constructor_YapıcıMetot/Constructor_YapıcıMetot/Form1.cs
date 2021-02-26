using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_YapıcıMetot
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
            Personallar p = new Personallar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personallar p = new Personallar();
            Personallar p2 = new Personallar("Terlan");
            Personallar p3 = new Personallar("Terlan", "Qurbanov", DateTime.Now);



            //Object Initializer
            Personallar p5 = new Personallar
            {
                Ad = "Isa",
                Soyad = "Qurbanov"
            };

           
        }
    }
}
