using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ders_19_XmlYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        XmlElement Filimler;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Filmler.xml"))
            {
                Filimler = doc.CreateElement("Filmler");
                doc.AppendChild(Filimler);
            }
            else
            {
                doc.Load("Filmler.xml");
                Filimler = (XmlElement)doc.SelectSingleNode("Filmler");

                XmlNodeList FilmList = Filimler.SelectNodes("Film");
                string oyuncular = "";
                foreach (XmlNode film in FilmList)
                {
                    ListViewItem lviAttr = new ListViewItem();
                    lviAttr.Text = film.Attributes["adi"].Value;
                    lviAttr.SubItems.Add(film.Attributes["kategori"].Value);
                    lviAttr.SubItems.Add(film.Attributes["ili"].Value);
                    lviAttr.SubItems.Add(film.Attributes["Yaradici"].Value);
                    lviAttr.SubItems.Add(film.Attributes["IBDMPuan"].Value);

                    XmlNodeList OyuncularList = film.SelectNodes("Oyuncular//oyuncu");//Diqqet bi isare(//)bir node asagi dusmet demeydi.
                    foreach (XmlNode oyuncu in OyuncularList)
                    {
                        oyuncular += oyuncu.InnerText + " , ";
                    }
                    oyuncular = oyuncular.Remove(oyuncular.Length - 2);
                    lviAttr.SubItems.Add(oyuncular);
                    listView1.Items.Add(lviAttr);
                    oyuncular = "";
                }
            }
        }

        private void btnFilmElaveEt_Click(object sender, EventArgs e)
        {
            XmlElement film = doc.CreateElement("Film");

            XmlAttribute adi = doc.CreateAttribute("adi");
            adi.Value = txtFilmAdi.Text;
            film.Attributes.Append(adi);

            XmlAttribute Kategori = doc.CreateAttribute("kategori");
            Kategori.Value = cmbFilmKategori.Text;
            film.Attributes.Append(Kategori);

            XmlAttribute ili = doc.CreateAttribute("ili");
            ili.Value = dtpFilmYaranmaIli.Text;
            film.Attributes.Append(ili);

            XmlAttribute Yaradici = doc.CreateAttribute("Yaradici");
            Yaradici.Value = txtYaradici.Text;
            film.Attributes.Append(Yaradici);

            XmlAttribute IBDMPuan = doc.CreateAttribute("IBDMPuan");
            IBDMPuan.Value = txtIMDBPuan.Text;
            film.Attributes.Append(IBDMPuan);

            XmlElement Oyuncular = doc.CreateElement("Oyuncular");

            foreach (string oyuncu in listBox1.Items)
            {
                XmlNode o = doc.CreateElement("oyuncu");
                o.InnerText = oyuncu;
                Oyuncular.AppendChild(o);
            }
            film.AppendChild(Oyuncular);
            Filimler.AppendChild(film);
            doc.Save("Filmler.xml");

        }

        private void btnOyuncuElaveEt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtOyuncuAdi.Text);
            txtOyuncuAdi.Text = "";
            
        }

        private void btnDBtoXML_Click(object sender, EventArgs e)
        {
            DBToXML dbtoxml = new DBToXML();
            dbtoxml.Show();
            this.Hide();
        }
    }
}
