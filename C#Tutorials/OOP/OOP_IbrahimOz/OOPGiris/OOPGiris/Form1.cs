using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void PersonelEkle(PersonalSinifi p)
        {
            //Database'e elave et 
        }

        PersonalSinifi[] personelS = new PersonalSinifi[100];
        int count = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            PersonalSinifi ps = new PersonalSinifi();
            ps.adi = txtAd.Text;
            ps.soyadi = txtSoyad.Text;
            ps.dogumtarixi = dtDogumTarixi.Value;
            ps.shvn= txtSHVN.Text;
            PersonelEkle(ps);
            ps.PersonelleriEkle();
            personelS[count] = ps;
            count++;
           
            
        }
    }
}
