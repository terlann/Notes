using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Takim t = new Takim();
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Adi = "Qartal";
            t.QurlusTarixi = Convert.ToDateTime("21.04.1993");
            t.StadAdi = "Stad Adi";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Ad = textBox1.Text;
            o.Soyad = "Qurbanov";
            o.DogumTarixi = Convert.ToDateTime("25.05.2005");
            o.Mevkii = "Qapici";
            t.Oyuncular.Add(o);
            listBox1.Items.Add(o.Ad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Oyuncu item in t.Oyuncular)
            {
                listBox2.Items.Add(item.Ad);
            }
        }
    }
}
