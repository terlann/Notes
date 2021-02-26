using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonalForm PF = new PersonalForm();
        Musteriler m = new Musteriler();
        private void personallarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PF.IsDisposed)
            {
                PF = new PersonalForm();
            }
            PF.MdiParent = this;
            PF.Show();
        }

        private void musterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (m.IsDisposed)
            {
                m = new Musteriler();
            }
            m.MdiParent = this;
            m.Show();
        }
    }
}
