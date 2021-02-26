using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM.Facad;
using ORM.Entity;

namespace Ders_5_N_Tier_Mimari
{
    public partial class Form_Urunler : Form
    {
        public Form_Urunler()
        {
            InitializeComponent();
        }

        private void Form_Urunler_Load(object sender, EventArgs e)
        {
            dtgridUrunler.DataSource = UrunlerORM.UrunlerSelect();

            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.ValueMember = "KategoriID";
            cmbKategoriler.DataSource = KategorilerORM.KategoriSelect();

            cmbTedarikciler.DisplayMember = "SirketAdi";
            cmbTedarikciler.ValueMember = "TedarikciID";
            cmbTedarikciler.DataSource = TedarikcilerORM.TedarikciSelect();
        }

        private void brnElaveEt_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = txtMehsulAdi.Text;
            u.Fiyat = nudQiymeti.Value;
            u.Stok = (short)nudStok.Value;
            u.KategoriID = (int)cmbKategoriler.SelectedValue;
            u.TedarikciID = (int)cmbTedarikciler.SelectedValue;
                
            bool check = UrunlerORM.UrunlerInsert(u);
            if (check)
                MessageBox.Show("Melumatlar Elave Olundu");
            else
                MessageBox.Show("Melumatlar Elave Oluna Bilmedi", "Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtgridUrunler.DataSource = UrunlerORM.UrunlerSelect();
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();

            u.UrunID = (int)txtMehsulAdi.Tag;
            u.UrunAdi = txtMehsulAdi.Text;
            u.Fiyat = nudQiymeti.Value;
            u.Stok = (short)nudStok.Value;
            bool checkUpdate = UrunlerORM.UrunlerUpdate(u);
            if (checkUpdate)
                MessageBox.Show("Melumatlar Yenilendi");
            else
                MessageBox.Show("Yenilenme bas tutmadi","Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtgridUrunler.DataSource = UrunlerORM.UrunlerSelect();
        }

        private void dtgridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgridUrunler.CurrentRow;
            txtMehsulAdi.Tag = row.Cells["UrunID"].Value;
            txtMehsulAdi.Text = row.Cells["UrunAdi"].Value.ToString();
            nudQiymeti.Value = (decimal)row.Cells["Fiyat"].Value;
            nudStok.Value = (short)row.Cells["Stok"].Value;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunID = (int)txtMehsulAdi.Tag;
            bool checkDelete = UrunlerORM.UrunlerDelete(u);
            if(checkDelete)
                MessageBox.Show("Melumatlar Silindi");
            else
                MessageBox.Show("Silme Emeliyyati bas tutmadi","Xeberdarliq",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            dtgridUrunler.DataSource = UrunlerORM.UrunlerSelect();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FormKategoriler fk = new FormKategoriler();
            fk.Show();
            this.Hide();
        }
    }
}
