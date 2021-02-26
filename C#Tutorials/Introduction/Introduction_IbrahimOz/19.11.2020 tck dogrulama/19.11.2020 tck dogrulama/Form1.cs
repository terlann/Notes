using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._11._2020_tck_dogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                string EndDigit = maskedTextBox1.Text[7].ToString();
                int EndDigitNum = Convert.ToInt32(EndDigit);
                MessageBox.Show(EndDigitNum.ToString());
                if (EndDigitNum % 2 != 0)
                {
                    MessageBox.Show("tek");
                }
                else
                {
                    MessageBox.Show("cut");
                }
            }
            else
            {
                MessageBox.Show("zehmet olmasa xanani tam doldurun");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
