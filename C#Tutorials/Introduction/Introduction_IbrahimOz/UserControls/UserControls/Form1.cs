using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlAdi.label1.Text = "Adi:";
            ctrlSoyadi.label1.Text = "Soyadi";
            ctrlAdress.label1.Text = "Adress";
            ctrlTelefon.label1.Text = "Telefon";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = ctrlAdi.textBox1.Text;
            lvi.SubItems.Add(ctrlSoyadi.textBox1.Text);
            lvi.SubItems.Add(ctrlAdress.textBox1.Text);
            lvi.SubItems.Add(ctrlTelefon.textBox1.Text);
            listView1.Items.Add(lvi);
        }
    }
}
