using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumaration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shagird s = new Shagird();
            s.adi = "Terlan";
            s.soyad = "Qurbanov";
            s.sinif = "11c";
            s.dersleri = DersleriEnum.Riyaziyyat;
            s.cins = cinsiyyet.kisi;
            int indexi = (int)s.cins;
            MessageBox.Show(Enum.GetName(typeof(DersleriEnum), s.dersleri));



            /*
             * Enum iceriisinde GetName ve GetNames adinda metotlar vardir.
            -GetName -verilen enum seceninin deyeriini donderir: MessageBox.Show(Enum.GetName(typeof(DersleriEnum), s.dersleri));
            -GetNames ise geriye string dizi tipinde deyer donderir, ve geriye belirtilen enum icerisindeki deyerleri string olaraq qaytarir:  string[] fenler = Enum.GetNames(typeof(DersleriEnum));
             */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fenler = Enum.GetNames(typeof(DersleriEnum));
            foreach (string element in fenler)
            {
                listBox1.Items.Add(element);
            }
        }
    }
}
