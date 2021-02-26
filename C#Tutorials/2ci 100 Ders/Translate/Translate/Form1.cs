using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Translate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string adrress = "https://www.google.com/";
        bool ConnectedTest()
        {
            try
            {
                WebRequest rq = WebRequest.Create(adrress);
                WebResponse rs = rq.GetResponse();
               
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            if (ConnectedTest())
                this.Text = "Connected";
            else
                this.Text = "Disconnected";
        }

        private void radiobtnAZ_EN_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/");
        }

        private void radiobtnEn_Az_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/?sl=en&tl=az&op=translate");
        }

        private void richtxtAz_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richtxtAz.Text;
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            if (radiobtnAZ_EN.Checked==true)
                richtxtEng.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;

            if (radiobtnEn_Az.Checked == true)
                richtxtAz.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
        }

        private void richtxtEng_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richtxtEng.Text;
        }
    }
}
