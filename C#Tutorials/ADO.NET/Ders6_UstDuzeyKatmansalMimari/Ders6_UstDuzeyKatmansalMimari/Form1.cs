using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6_UstDuzeyKatmansalMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormUrunler fu = new FormUrunler();
        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fu.IsDisposed)  //IsDisposed  Yeni RAM'dan qaldirilmishsa demekdir
            {
                fu = new FormUrunler();
            }
            fu.MdiParent = this;
            fu.Show();
        }

        FormKategoriler fk = new FormKategoriler();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fk.IsDisposed)
            {
                fk = new FormKategoriler();
            }
            fk.MdiParent = this;
            fk.Show();
        }

        FormTedarikciler ft = new FormTedarikciler();
        private void tedarikcilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ft.IsDisposed)
            {
                ft = new FormTedarikciler();
            }
            ft.MdiParent = this;
            ft.Show();
        }
    }
}
