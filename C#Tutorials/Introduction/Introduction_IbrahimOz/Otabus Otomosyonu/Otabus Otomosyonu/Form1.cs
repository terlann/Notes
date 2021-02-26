using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otabus_Otomosyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string ClickOlunan { get; set; }
        public string fullname { get; set; }
        public string mobilenumber { get; set; }
        public string cinsiyyet { get; set; }

        void btnClear()
        {
            yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    if (btn.Text!= "Sifariş et")
                    {
                        this.Controls.Remove(btn);
                        goto yavaslat;
                    }
                }
            }
        }
        void KoltukDoldur(int koltukSayi, bool arxaKoltuklar)//Arxa koltuklar 4 durse false, 5dirse true
        {
            btnClear();
            int nomreleme = 1;
            int sirasayi = koltukSayi / 4;
            int qaliqKoltuk = koltukSayi % 4;
            int birsiradakikoltuqsayi = 5;
            
            for (int i = 0; i < sirasayi; i++)
            {
                for (int j = 0; j < birsiradakikoltuqsayi; j++)
                {
                    if (j==2 && i==sirasayi-1)
                    {
                        Button btn = new Button();
                        btn.Text = nomreleme++.ToString();
                        btn.Width = 40;
                        btn.Height = 30;
                        btn.Left = 20 + (j * 40);
                        btn.Top = 20 + (i * 30);
                        this.Controls.Add(btn);
                    }
                    if (j!=2)
                    {
                        Button btn = new Button();
                        btn.Text = nomreleme++.ToString();
                        btn.Width = 40;
                        btn.Height = 30;
                        btn.Left = 20 + (j * 40);
                        btn.Top = 20 + (i * 30);
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                    }
                }               
            }
           
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickolunan = (Button)sender;
            clickolunan.BackColor = Color.Red;
            clickolunan.BringToFront();
            ClickOlunan += clickolunan.Text+"  ";
            
        }

        void Clear()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {

                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.Text = "";

                }
                if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 1;
                }
                if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.Value = DateTime.Now;
                }
               
            }
        }
        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            if (cmbAvtobusNovu.SelectedIndex==-1 || cmbHardan.SelectedIndex==-1 || cmbHaraya.SelectedIndex==-1)
            {
                errorProvider1.SetError(cmbAvtobusNovu, "Zehmet olmasa gosterilen xanalari doldurun.");
                errorProvider1.SetError(cmbHardan, "Zehmet olmasa gosterilen xanalari doldurun.");
                errorProvider1.SetError(cmbHaraya, "Zehmet olmasa gosterilen xanalari doldurun.");
                return;
            }
                ListViewItem lvi = new ListViewItem();
                lvi.Text = cmbAvtobusNovu.Text;
                lvi.SubItems.Add(cmbHardan.Text);
                lvi.SubItems.Add(cmbHaraya.Text);
                lvi.SubItems.Add(dtVaxt.Value.ToShortDateString());
                lvi.SubItems.Add(numQiymet.Value.ToString());
                lvi.SubItems.Add(fullname);
                lvi.SubItems.Add(mobilenumber);                
                lvi.SubItems.Add(cinsiyyet);                
                lvi.SubItems.Add(ClickOlunan);
                LVAvtobusQeyd.Items.Add(lvi);
                Clear();
        }

        private void cmbAvtobusNovu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAvtobusNovu.Text)
            {
                case "Hundai":
                    KoltukDoldur(45, false);
                    break;
                case "Kia":
                    KoltukDoldur(10, true);
                    break;
                case "Qazel":
                    KoltukDoldur(15, false);
                    break;
                case "Mercedes":
                    KoltukDoldur(31, false);
                    break;
                default:
                    break;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Button btm = new Button();
            Controls.Add(btm);
            btm.BackColor = Color.Red;
           btm.Top = btm.Top+10;
        }


    }
}
