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

namespace listde_axtarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                string strFormat = string.Format("Listedeki shexslerin sayi = {0} ;", listBox1.Items.Count);
                MessageBox.Show(strFormat);
            }
            else
            {
                MessageBox.Show("List bosdur");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox2.Text))
            {
                MessageBox.Show("Movcuddur");
            }
            else
            {
                MessageBox.Show("Movcud deyil");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    arr.Add(listBox1.Items[i].ToString());
                }
                foreach (string item in arr)
                {
                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }

        }
    }
}
