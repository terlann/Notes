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
    public partial class FormRapor : Form
    {
        public FormRapor()
        {
            InitializeComponent();
        }

        KuzeyYeliContext ctx = new KuzeyYeliContext();
        private void btnShowRapor_Click(object sender, EventArgs e)
        {
            //SQL de qarsiligi
            /*
               Select UrunAdi, 
               SUM(sd.Adet*sd.Fiyat*(1-sd.Indirim))'Toplam Satis(AZN)',
               SUM(Adet)'Satis Miqdari(Eded)' 
               from  SatisDetay sd left join
               Urunler u
               on u.UrunID=sd.UrunID
               group by UrunAdi
             */
            var ShowRapor = ctx.SatisDetays.Join
                (
                ctx.Urunlers,
                sd => sd.UrunID,
                u => u.UrunID,
                (SatisD, Urun) => new
                {
                    Urun.UrunAdi,
                    SatisD.Fiyat,
                    SatisD.Adet,
                    SatisD.Indirim
                }).GroupBy(x => x.UrunAdi).Select(x => new //Select yeni column yaratmaq menasina verir
                {
                    x.Key, //x.Key bize qrupladigimiz columnu verir yeni UrunAdi'ni
                    ToplamSatisMeblegi = x.Sum(c => (float)c.Adet * (float)c.Fiyat * (1 - (float)c.Indirim)),
                    ToplamSatisMiqdari = x.Sum(v => v.Adet)

                }).ToList();
            dataGridView1.DataSource = ShowRapor;
        }

        private void btnShowRapor2_Click(object sender, EventArgs e)
        {
            /*
                Select t.SirketAdi,k.KategoriAdi,
                SUM(sd.Adet*sd.Fiyat*(1-sd.Indirim))'Tedarik olunan mebleg AZN',
                SUM(Adet)'Satis sayi'
                from Tedarikciler t
                left join Urunler u
                on t.TedarikciID=u.UrunID
                left join Kategoriler k
                on k.KategoriID=u.KategoriID
                left join SatisDetay sd
                on sd.UrunID=u.UrunID
                group by t.SirketAdi,k.KategoriAdi
             */

            var ShowRapor2 = ctx.Urunlers.Join(
                ctx.SatisDetays,
                u => u.UrunID,
                sd => sd.UrunID,
                (urun, satiD) => new
                {
                    urun.Tedarikciler,
                    urun.Kategoriler,
                    satiD.Fiyat,
                    satiD.Adet,
                    satiD.Indirim
                }).GroupBy(x => new { x.Tedarikciler.SirketAdi, x.Kategoriler.KategoriAdi }).Select(x => new
                {
                    x.Key.SirketAdi,
                    x.Key.KategoriAdi,
                    ToplamTutarAZN = x.Sum(y => (float)y.Fiyat * y.Adet * (1 - y.Indirim)),
                    ToplamMiqdar = x.Sum(z => z.Adet)
                }).ToList();
            dataGridView1.DataSource = ShowRapor2;
        }
    }
}
