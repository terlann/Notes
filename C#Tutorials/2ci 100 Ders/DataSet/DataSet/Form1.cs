using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_PersonalTableAdapter ds = new DataSet1TableAdapters.Tbl_PersonalTableAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.PersonelSelect();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ds.PersonalInsert(txtFirsName.Text, txtLastName.Text, dtpDateOfBirth.Value.ToString());
            dataGridView1.DataSource = ds.PersonelSelect();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            ds.PersonalUpdate(txtFirsName.Text, txtLastName.Text, dtpDateOfBirth.Value.ToString(),id);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            ds.PersonalDelete(id);
            dataGridView1.DataSource = ds.PersonelSelect();
        }
    }
}
