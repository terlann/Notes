using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackGroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        int sayac1 = 0, sayac2 = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.CancelAsync();
            //lblStart1.Text = sayac1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.CancelAsync();
            //lblStart2.Text = sayac2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.IsBusy==false)
            {
                backgroundWorker2.RunWorkerAsync();
            }
            
            //while (sayac2 < 100000)
            //{
            //    lblStart2.Text = sayac2++.ToString();
            //    Application.DoEvents();
            //}
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac1 < 100000)
            {
                lblStart1.Text = sayac1++.ToString();
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                //Application.DoEvents();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac2 < 100000)
            {
                lblStart2.Text = sayac2++.ToString();
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
               //Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy==false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
           
            //while (sayac1<100000)
            //{
            //    lblStart1.Text = sayac1++.ToString();
            //    Application.DoEvents();
            //}
        }
    }
}
