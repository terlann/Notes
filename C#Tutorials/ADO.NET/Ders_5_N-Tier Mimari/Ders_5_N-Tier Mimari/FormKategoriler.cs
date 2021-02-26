using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM.Entity;
using ORM.Facad;

namespace Ders_5_N_Tier_Mimari
{
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        private void btnKategoriElaveEt_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.KategoriAdi = txtKategoriAdi.Text;
            k.Tanimi = txtKategoriTanimi.Text;
            bool CheckKateInsert = KategorilerORM.KategorilerInsert(k);
            if (CheckKateInsert)
                MessageBox.Show("Melumatlar Elave Olundu");
            else
                MessageBox.Show("Elave etmek mumkun olmadi");
            dtGridKategoriler.DataSource = KategorilerORM.KategoriSelect();

        }

        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            dtGridKategoriler.DataSource = KategorilerORM.KategoriSelect();
        }
    }
}
