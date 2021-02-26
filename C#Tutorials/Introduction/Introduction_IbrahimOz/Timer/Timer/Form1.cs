using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //int initiator = 0;
            //while (true)
            //{
            //    initiator++;
            //    label1.Text = initiator.ToString();
            //    Application.DoEvents();
            //    Thread.Sleep(100);

            //}
            timer1.Start();
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = count++.ToString();
        }
    }
}
