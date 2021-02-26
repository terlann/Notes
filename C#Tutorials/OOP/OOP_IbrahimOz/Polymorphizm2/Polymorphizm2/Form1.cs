using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekmek ek = new Ekmek();
            ek.Gramaj = 350;
            ek.Fiyat = 0.40m;
            Sebet s = new Sebet();
            s.UrunTopla(ek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elektronika el = new Elektronika();
            Sebet s = new Sebet();
            el.Adi = "Plataryuyan";
            el.Fiyat = 450;
            s.UrunTopla(el);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TekstilUrun ts = new TekstilUrun();
            Sebet s = new Sebet();
            ts.Fiyat = 10;
            s.UrunTopla(ts);
        }
    }
}
