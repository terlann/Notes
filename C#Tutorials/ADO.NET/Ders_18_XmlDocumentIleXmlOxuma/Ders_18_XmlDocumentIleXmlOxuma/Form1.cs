using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ders_18_XmlDocumentIleXmlOxuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // doc.Load("XML_Xeberler.xml");  //doc.Load("XML_Xeberler.xml");\\ isaresi // doc.Load("XML_Xeberler");//Eger Xml fayli ile proyektin exe file bir yerdedirse sadece Xml faylinin adini yazmaq kifayet eder.
        XmlDocument doc = new XmlDocument();
        XmlNodeList XeberList;
        private void Form1_Load(object sender, EventArgs e)
        {
            doc.Load("..\\..\\XML_Xeberler.xml");
            XmlNode node = doc.SelectSingleNode("Xeberler");
            this.Text = node.SelectSingleNode("Basliq").InnerText;
            lblAciqlama.Text = string.Format("{0} - {1}\n{2}", node.SelectSingleNode("Aciqlama").InnerText, node.SelectSingleNode("Tarix").InnerText, node.SelectSingleNode("Link").InnerText);
            XeberList = node.SelectNodes("Xeber");
            foreach (XmlNode xeber in XeberList)
            {
                LBoxBasliqlar.Items.Add(xeber.SelectSingleNode("Basliq").InnerText);
            }
           
        }

        private void LBoxBasliqlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBoxAciqlama.Items.Clear();
            string SeciliBasliq = LBoxBasliqlar.SelectedItem.ToString();
            foreach (XmlNode xeber in XeberList)
            {
                string GelenBasliq = xeber.SelectSingleNode("Basliq").InnerText;
                if (SeciliBasliq==GelenBasliq)
                {
                    LBoxAciqlama.Items.Add(xeber.SelectSingleNode("Aciqlama").InnerText);
                }
            }
        }
    }
}
