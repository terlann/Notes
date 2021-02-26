using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Olculer Kicik = new Olculer { Adi = "Kicik", Carpan = 1 };
            Olculer Orta = new Olculer { Adi = "Orta", Carpan = 1.25 };
            Olculer Boyuk = new Olculer { Adi = "Boyuk", Carpan = 1.75 };
            Olculer Maxi = new Olculer { Adi = "Maxi", Carpan = 2 };
            cmbOlculer.Items.Add(Kicik);
            cmbOlculer.Items.Add(Orta);
            cmbOlculer.Items.Add(Boyuk);
            cmbOlculer.Items.Add(Maxi);

            Pizza Klassik = new Pizza { Adi = "Klassik", Qiymeti = 5 };
            Pizza Qarisiq = new Pizza { Adi = "Qarisiq", Qiymeti = 7.50m };
            Pizza Turkish = new Pizza { Adi = "Turkish", Qiymeti = 8 };
            Pizza Tuna = new Pizza { Adi = "Tuna", Qiymeti = 9.50m };
            ListbPizzalar.Items.Add(Klassik);
            ListbPizzalar.Items.Add(Qarisiq);
            ListbPizzalar.Items.Add(Turkish);
            ListbPizzalar.Items.Add(Tuna);

            KenarTip NazikKenar = new KenarTip { Adi = "Nazik Kenar", ElaveQiymet = 1 };
            rdbNazik.Tag = NazikKenar;
            KenarTip QalinKenar = new KenarTip { Adi = "Qalin Kenar", ElaveQiymet = 2 };
            rdbQalin.Tag = QalinKenar;

        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)ListbPizzalar.SelectedItem;
            p.Olcusu = (Olculer)cmbOlculer.SelectedItem;
            p.KenarTipi = rdbNazik.Checked ? (KenarTip)rdbNazik.Tag : (KenarTip)rdbQalin.Tag;
            p.Mazemeler = new List<string>();
            foreach (CheckBox ctrl in groupBox2.Controls)
            {
                if (ctrl.Checked)
                {
                    p.Mazemeler.Add(ctrl.Text);
                }
            }
            decimal FinishSum = p.Summa * nudEded.Value;
            txtQiymet.Text = FinishSum.ToString();

            s = new Sifaris();
            s.Sifarisler = p;
            s.Eded = (int)nudEded.Value;
            
        }

        Sifaris s;
        decimal sum = 0;
        private void btnSebeteElaveEt_Click(object sender, EventArgs e)
        {
            if (s!=null)
            {
                ListbSebet.Items.Add(s);
            }

            sum += s.ButunSifarislerinMeblegi;
            lblToplamQiymet.Text = sum.ToString();
        }

        private void btnSifarisVer_Click(object sender, EventArgs e)
        {

            MessageBox.Show(string.Format("Sifarislerin Sayi: {0}\n Odenilecey Mebleg: {1}", ListbSebet.Items.Count, sum));
        }
    }
}
