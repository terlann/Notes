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

namespace ListView_1._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtFirstName.Text;
            lvi.SubItems.Add(txtLastname.Text);
            lvi.SubItems.Add(mtxtPin.Text);
            string fullmobNom = string.Format("{0} {1}", cmbPrefix.Text, mtxtTelephoneNumber.Text);
            lvi.SubItems.Add(fullmobNom);
            lvi.SubItems.Add(dtBirthDay.Value.ToShortDateString());
            listView1.Items.Add(lvi);
            txtFirstName.Text = "";
            txtLastname.Text = "";
            mtxtPin.Text = "";
            mtxtTelephoneNumber.Text = "";
            dtBirthDay.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPrefix.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbPrefix.Items.Add(textBox1.Text);
        }
    }
}
