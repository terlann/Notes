using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM;
using ENTİTY;
using System.Collections;

namespace Ders6_UstDuzeyKatmansalMimari
{
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }
        UrunlerORM uo = new UrunlerORM();
        KategorilerORM ko = new KategorilerORM();
        TedarikcilerORM to = new TedarikcilerORM();
        private void FormUrunler_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = uo.Select();

            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.ValueMember = "KategoriID";
            cmbKategoriler.DataSource = ko.Select();

            cmbTedarikciler.DisplayMember = "SirketAdi";
            cmbTedarikciler.ValueMember = "TedarikciID";
            cmbTedarikciler.DataSource = to.Select();
        }

        private void brnElaveEt_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = txtMehsulAdi.Text;
            u.Fiyat = nudQiymeti.Value;
            u.Stok = (short)nudStok.Value;
            u.KategoriID = (int)cmbKategoriler.SelectedValue;
            u.TedarikciID = (int)cmbTedarikciler.SelectedValue;
            u.BirimdekiMiktar = " ";

            bool checkUrunler = uo.Insert(u);
            if (checkUrunler)
            {
                MessageBox.Show("Melumatlar Elave edildi");
                dataGridView1.DataSource = uo.Select();
            }
            else
            {
                MessageBox.Show("Emeliyyat bas tutmadi");
            }
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunID = (int)txtMehsulAdi.Tag;
            u.UrunAdi = txtMehsulAdi.Text;
            u.Fiyat = nudQiymeti.Value;
            u.Stok = (short)nudStok.Value;
            u.KategoriID = (int)cmbKategoriler.SelectedValue;
            u.TedarikciID = (int)cmbTedarikciler.SelectedValue;
            u.BirimdekiMiktar = " ";

            bool checkUrunler = uo.Update(u);
            if (checkUrunler)
            {
                MessageBox.Show("Melumatlar Deyisdirildi");
                dataGridView1.DataSource = uo.Select();
            }
            else
            {
                MessageBox.Show("Emeliyyat bas tutmadi");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtMehsulAdi.Tag = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value;
            txtMehsulAdi.Text = row.Cells["UrunAdi"].Value.ToString();
            nudQiymeti.Value = (decimal)row.Cells["Fiyat"].Value;
            nudStok.Value = (short)row.Cells["Stok"].Value;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunID = (int)txtMehsulAdi.Tag;
            bool CheckDelete = uo.Delete(u.UrunID);
            if (CheckDelete)
            {
                MessageBox.Show("Melumatlar Silindi");
            }
            else
            {
                MessageBox.Show("Emeliyyat bas tutmadi");
            }
        }
    }
}