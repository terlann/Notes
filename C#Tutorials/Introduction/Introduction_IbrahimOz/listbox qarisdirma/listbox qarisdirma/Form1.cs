using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_qarisdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void mtdDelete()
        {
            string[] arr = new string[listBox1.SelectedItems.Count];
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                arr[i] = (string)listBox1.SelectedItems[i];
            }
            foreach (string item in arr)
            {
                listBox1.Items.Remove(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("{0}-{1}", listBox1.Items.Count, textBox1.Text);
            if (!listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Insert(0, textBox1.Text);
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mtdDelete();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                mtdDelete();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] crossname = new string[listBox1.Items.Count];
            Random rdm = new Random();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int ind = rdm.Next(0, listBox1.Items.Count);
                string name = listBox1.Items[ind].ToString();
                if (!crossname.Contains(name))
                {
                    crossname[i] = name;
                }
                else
                {
                    i--;
                }
            }
            listBox1.Items.Clear();
            foreach (string item in crossname)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
