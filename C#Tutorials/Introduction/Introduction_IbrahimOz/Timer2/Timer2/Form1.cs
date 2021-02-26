using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0, deqiqe = 0, saat = 0, count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSaniye.Text = saniye < 10 ? string.Format("0{0}", saniye) : saniye.ToString();
            if (saniye>59)
            {
                saniye = 0;
                deqiqe++;
                lblDeqiqe.Text = saniye < 10 ? string.Format("0{0}", deqiqe) : deqiqe.ToString();
                
            }
            else if (deqiqe>59)
            {
                deqiqe = 0;
                saniye = 0;
                saat++;
                lblSaat.Text = deqiqe < 10 ? string.Format("0{0}", saat) : saat.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
