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
    public partial class FormTedarikciler : Form
    {
        public FormTedarikciler()
        {
            InitializeComponent();
        }

        private void FormTedarikciler_Load(object sender, EventArgs e)
        {
            TedarikcilerORM to = new TedarikcilerORM();
            dataGridView1.DataSource = to.Select();
        }
    }
}
