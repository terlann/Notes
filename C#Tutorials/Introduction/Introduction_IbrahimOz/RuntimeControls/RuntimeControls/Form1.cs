using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewButton_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Width = 50;
            btn.Height = 50;
            Random rastgele = new Random();
            //int x = rastgele.Next(0, this.ClientSize.Width - btn.Width);
            btn.Left = 180;
            btn.Top = 170;
            btn.Text = "Button2";
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            //MessageBox.Show(tiklanan.Text);
            //this.Controls.Remove(tiklanan);
            tiklanan.BringToFront();  //tiklanan kontrolu en one getirir
            tiklanan.SendToBack(); //tiklanan controlu en arxaya gonderir

        }
    }
}
