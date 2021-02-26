using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeUyqulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex=0;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 0; i < adet; i++)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        Button btn = new Button();
                        btn.Text = string.Format("Button{0}", i+1);
                        flowLayoutPanel1.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case 1:
                        TextBox txt = new TextBox();
                        txt.Text = string.Format("Textbox{0}", i+1);
                        flowLayoutPanel1.Controls.Add(txt);
                        break;
                    case 2:
                        ComboBox cmb = new ComboBox();
                        cmb.Text = string.Format("Combobox{0}", i + 1);
                        flowLayoutPanel1.Controls.Add(cmb);
                        break;
                    case 3:
                        PictureBox px = new PictureBox();
                        flowLayoutPanel1.Controls.Add(px);
                        break;
                    case 4:
                        ListBox lb = new ListBox();
                        lb.Text = string.Format("Listbox{0}", i + 1);
                        flowLayoutPanel1.Controls.Add(lb);
                        break;
                    default:
                        MessageBox.Show("Secim yanlisdir");
                        return;
                        break;
                       
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }
    }
}
