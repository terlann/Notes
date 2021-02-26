using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefaultParametreliMetodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public int Hesabla(int a,int b,int c)
        {
            return a + b + c;
        }

        public int Hesabla2(int a,int b,int c=50) // c parametri default deyer olaraq 50 verdik yeniii c parametrine deyer vermese avtomatik 50 qebul edecey. Default parametrler axirda yazilir.
        {
            return a + b + c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Hesabla(5, 6, 7).ToString();
            textBox2.Text = Hesabla2(5, 6).ToString();
        }
    }
}
