using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Metodlar:
             * Icerisine parametr alan ve ya almayan,Geriye deyer donderen ve ya dondermeyen olaraq metodlar bir birinden ferqlenir.
             */



        //Void sozu bu metodun geriye hec bir sey dondermiyeceyi anlamina gelir.Metodun geriye deyer dondermiyen halii icerisindeki kodlar calisir sonra biter.
        void UyariVer()
        {
            MessageBox.Show("Uyari ver");
        }



        //Geriye deyer dondermeyen ve icine iki eded parametre alan metotdur
        void topla(int a, int b, int c)
        {
            int topla = a + b + c;
            MessageBox.Show(topla.ToString());
        }




        //icerisine parametre alan ve geriye deyer donduren metotdur
        decimal kdvHesablar(decimal fiyat)
        {
            decimal tutar = fiyat + (fiyat * (decimal)0.18);
            return tutar;
            //metot icerisinde geriye deyer dondurme emeliyyatini return komutu yerine ytirir.
        }




        //Icerisine parametre almayan  ver geriye int tipinde deyer donderen metotdur.
        int Toplam()
        {
            return 24 + 63;
        }

        decimal kdvHesablar(decimal fiyat,decimal kdvOran)
        {
            decimal tutar = fiyat + (fiyat * kdvOran);
            return tutar;
        }

        //Metodlarin imzasi var(Overload).Her metodun imzasi olur. Metodun imzasini icerisine aldigi parametre sayisi ve tipi ile bilinir.Eyn adli metodlari calisdirdigimiz zaman izin verilmediyi teqdirde, eyni adli ve ferqli imzalarda metodlar calisdirmaga icaze verir. Bir sozle metodun imzasi: aldigi parametre sayisi ve tipidir

        private void Form1_Load(object sender, EventArgs e)
        {
            UyariVer();
            topla(5, 6, 7);
            //topla(a:5,b:6,c:7);
            decimal ttr = kdvHesablar((decimal)6.65);
            decimal ttr2 = kdvHesablar((decimal)3.56, 10);
        }


        
    }
}
