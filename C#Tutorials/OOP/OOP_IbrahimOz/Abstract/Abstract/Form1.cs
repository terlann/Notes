using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MusiqiAletleriCal(MusiqiAletleri ms)
        {
            MessageBox.Show(string.Format("Aletin adi: {0}\nIsleme terzi: {1}",ms.cal(),ms.calmaturleri));
        }
        void CalmaTuru(MusiqiAletleri ct)
        {
            MessageBox.Show(ct.calmaturleri.ToString());
        }
        private void btnMusiqiAletleri_Click(object sender, EventArgs e)
        {

        }

        private void btnGitara_Click(object sender, EventArgs e)
        {
            Gitara g = new Gitara();
            MusiqiAletleriCal(g);
        }

        private void btnKeman_Click(object sender, EventArgs e)
        {
            Keman k = new Keman();
            MusiqiAletleriCal(k);
        }

        private void btnTruba_Click(object sender, EventArgs e)
        {
            Truba t = new Truba();
            MusiqiAletleriCal(t);
        }
    }
}
