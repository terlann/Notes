using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM;
using ENTİTY;

namespace Ders6_UstDuzeyKatmansalMimari
{
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            KategorilerORM ko = new KategorilerORM();
            dataGridView1.DataSource = ko.Select();
        }
    }
}
