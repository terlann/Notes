using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataAyiklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void test()
        {

        }
        //Hata tipleri:
        // 1-Derleme hatalari(Build error)
        // 2-Calisma zamani hatalar(Runtime error)
        // 3-Mantiksal hatalar(Logical eror)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            try
            {
                string say1 = txtSay1.Text;
                string say2 = txtSay2.Text;
                test();
                int sayInt1 = Convert.ToInt32(say1);
                int sayInt2 = Convert.ToInt32(say2);
                int sum = sayInt1 + sayInt2;
                label3.Text = sum.ToString();
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message + "\nDuzgen formatda deyil");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message + "\nLimiti asmisiz");
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            finally
            {
                //Try icerisindeki kodlar hata versede vermesede Finally blokuna daxil olaraq burdaki kodlari calisidirir.Yeni her bir halda Finally blokuna daxil olur. Misal olaraq con.Close(); baglantinin kapanmasi xetalari.
            }

        }
    }
}
