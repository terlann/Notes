using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void mtdDelete()
        {
            string[] silinecekler = new string[listBox1.SelectedItems.Count];
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                silinecekler[i] = (string)listBox1.SelectedItems[i];
            }
            foreach (string item in silinecekler)
            {
                listBox1.Items.Remove(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(textBox1.Text);
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string str = string.Format("{0}-{1}", listBox1.Items.Count + 1, textBox1.Text.Trim());
                listBox1.Items.Insert(0, str);
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mtdDelete();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            mtdDelete();
        }
    }
}
