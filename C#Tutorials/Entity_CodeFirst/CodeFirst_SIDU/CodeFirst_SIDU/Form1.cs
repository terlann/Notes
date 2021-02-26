using CodeFirst_SIDU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_SIDU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KuzeyYeliContext ctx = new KuzeyYeliContext();

        void Select_Join()
        {
            var ResultTable = ctx.Urunlers.Join(
                ctx.Kategorilers,
                u => u.KategoriID,
                k => k.KategoriID,
                (urun, kategori) => new
                {
                    urun.UrunID,
                    urun.UrunAdi,
                    urun.TedarikciID,
                    kategori.KategoriAdi,
                    urun.Fiyat
                }).Join(
                ctx.Tedarikcilers,
                uk => uk.TedarikciID,
                t => t.TedarikciID,
                (UrunKategori, Tedarikci) => new
                {
                    UrunKategori.UrunID,
                    UrunKategori.UrunAdi,
                    UrunKategori.KategoriAdi,
                    Tedarikci.SirketAdi,
                    UrunKategori.Fiyat
                }).ToList();
            dataGridView1.DataSource = ResultTable;
            dataGridView1.Columns["UrunID"].Visible = false;
        }
        void Select_Join(string asc)
        {
            if (asc=="artan")
            {
               var ResultTable = ctx.Urunlers.Join(
               ctx.Kategorilers,
               u => u.KategoriID,
               k => k.KategoriID,
               (urun, kategori) => new
               {
                   urun.UrunAdi,
                   urun.TedarikciID,
                   kategori.KategoriAdi,
                   urun.Fiyat
               }).Join(
               ctx.Tedarikcilers,
               uk => uk.TedarikciID,
               t => t.TedarikciID,
               (UrunKategori, Tedarikci) => new
               {
                   UrunKategori.UrunAdi,
                   UrunKategori.KategoriAdi,
                   Tedarikci.SirketAdi,
                   UrunKategori.Fiyat
               }).OrderBy(x => x.Fiyat).ToList();
                dataGridView1.DataSource = ResultTable;
            }
            else
            {
                var ResultTable = ctx.Urunlers.Join(
               ctx.Kategorilers,
               u => u.KategoriID,
               k => k.KategoriID,
               (urun, kategori) => new
               {
                   urun.UrunAdi,
                   urun.TedarikciID,
                   kategori.KategoriAdi,
                   urun.Fiyat
               }).Join(
               ctx.Tedarikcilers,
               uk => uk.TedarikciID,
               t => t.TedarikciID,
               (UrunKategori, Tedarikci) => new
               {
                   UrunKategori.UrunAdi,
                   UrunKategori.KategoriAdi,
                   Tedarikci.SirketAdi,
                   UrunKategori.Fiyat
               }).OrderByDescending(x => x.Fiyat).ToList();
                dataGridView1.DataSource = ResultTable;
            }
           
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ctx.Urunlers.ToList();
            //dataGridView1.Columns["UrunID"].Visible = false;
            //dataGridView1.Columns["Kategoriler"].Visible = false;
            //dataGridView1.Columns["Tedarikciler"].Visible = false;
            Select_Join();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = ctx.Kategorilers.ToList();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";

            cmbTedarikci.DataSource = ctx.Tedarikcilers.ToList();
            cmbTedarikci.DisplayMember = "SirketAdi";
            cmbTedarikci.ValueMember = "TedarikciID";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = txtMehsulAdi.Text;
            u.TedarikciID = (int)cmbTedarikci.SelectedValue;
            u.KategoriID = (int)cmbKategori.SelectedValue;
            u.Fiyat = Convert.ToDecimal(txtQiymet.Text);
            ctx.Urunlers.Add(u);
            ctx.SaveChanges();
            Select_Join();
        }

        private void txt_MehsulAdinaGoreAxtar_TextChanged(object sender, EventArgs e)
        {
            string searchWord = txt_MehsulAdinaGoreAxtar.Text;
            dataGridView1.DataSource = ctx.Urunlers.Where(u => u.UrunAdi.Contains(searchWord)).ToList();
        }

        private void rdbArtan_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ctx.Urunlers.OrderBy(u => u.Fiyat).ToList();
            if (rdbArtan.Checked)
            {
                Select_Join("artan");
            }
        }

        private void rdbAzalan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAzalan.Checked)
            {
                Select_Join("azalan");
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value!=0)
            {
                dataGridView1.DataSource = ctx.Urunlers.Take((int)numericUpDown1.Value).ToList();//Take sql de qarsiligi top 10 kimidir.
            }
            else
            {
                dataGridView1.DataSource = ctx.Urunlers.Take(dataGridView1.Rows.Count).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] words = { "apple", "strawberry", "grape", "peach", "banana", "Student" };
            //var wordQuery = from word in words
            //                //where word[0] == 's'
            //                select word;

            ////    Because each element in the sequence is a string,
            ////    not an anonymous type, var is optional here also.
            //foreach (string s in wordQuery)
            //{
            //    listBox1.Items.Add(s);
            //}


            var mehsullar = ctx.Urunlers.ToList();
            

            var custQuery = from mehsul in mehsullar
                            where mehsul.Fiyat < 100 && mehsul.Fiyat>50
                            select new { mehsul.UrunAdi, mehsul.Fiyat };
            MessageBox.Show(custQuery.Count().ToString());
            // var must be used because each item
            // in the sequence is an anonymous type2

            foreach (var item in custQuery)
            {
               //  listBox1.Items.Add(string.Format("Mehsul Adi={0}, Qiymet={1}", item.UrunAdi, item.Fiyat));
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FormRapor frmRapor = new FormRapor();
            frmRapor.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            Urunler u = new Urunler();
            int id = (int)row.Cells["UrunID"].Value;
            u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
            u.UrunAdi = txtMehsulAdi.Text;
            ctx.SaveChanges();
            Select_Join();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value;
            Urunler u = new Urunler();
            u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
            ctx.Urunlers.Remove(u);
            ctx.SaveChanges();
            Select_Join();
        }
    }
}
