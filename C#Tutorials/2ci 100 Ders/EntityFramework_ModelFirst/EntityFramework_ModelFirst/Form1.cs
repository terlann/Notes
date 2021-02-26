using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_ModelFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DBPersonalEntities ent = new DBPersonalEntities();
        Tbl_Personal p = new Tbl_Personal();

        void clear()
        {
            txtFirsName.Text = "";
            txtLastName.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ent.Tbl_Personal.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            p.FirstName = txtFirsName.Text;
            p.LastName = txtLastName.Text;
            p.DateOfBirthb = dtpDateOfBirth.Value;
            ent.Tbl_Personal.Add(p);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Tbl_Personal.ToList();
            clear();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //p.ID = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
           int id= (int)dataGridView1.CurrentRow.Cells["ID"].Value;
           Tbl_Personal p = ent.Tbl_Personal.First(x => x.ID == id);
            ent.Tbl_Personal.Remove(p);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Tbl_Personal.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.ID = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            p.FirstName = txtFirsName.Text;
            p.LastName = txtLastName.Text;
            p.DateOfBirthb = dtpDateOfBirth.Value;
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Tbl_Personal.ToList();
            clear();
        }
    }
}
