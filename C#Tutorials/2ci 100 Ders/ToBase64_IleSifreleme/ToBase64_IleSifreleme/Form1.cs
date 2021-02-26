using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToBase64_IleSifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            //Encoding sifreleme menasini verir
            //Qeyd: Base64'lerin sriftlerinin lenght'i 4e bolunen olunmalidir. Eger 4'e bolunmurse ozumuz 4e bolunene qeder base64un sonuna =(beraber) atmaliyiq
            byte[] Sifrele = ASCIIEncoding.ASCII.GetBytes(txtNormalHal.Text);
            txtSifreliHal.Text = Convert.ToBase64String(Sifrele);
        }

        private void btnSifredenCixar_Click(object sender, EventArgs e)
        {
            byte[] sifredenCixar = Convert.FromBase64String(txtSifreliHal.Text);
            txtNormalHal.Text = ASCIIEncoding.ASCII.GetString(sifredenCixar).ToString();
        }
    }
}
