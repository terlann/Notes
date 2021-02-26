using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ref_Out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ref keywordu deyer tiplerinin referans tipki istifade olunmasini saglar.
        public int Hesabla(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = 20;
            int number2 = 100;
            textBox1.Text = Hesabla(ref number1, number2).ToString()+"///"+number1.ToString();
        }
    }
}
