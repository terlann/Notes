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
using ENTITY;

namespace Ders_11_17OtelProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Products p = new Products();
        ProductsORM po = new ProductsORM();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = po.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = textBox1.Text;
            p.Price = Convert.ToDecimal(textBox2.Text);
            p.Quantity = Convert.ToDouble(textBox3.Text);
            po.Insert(p);
            dataGridView1.DataSource = po.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.ProductID = (int)textBox1.Tag;
            p.Name = textBox1.Text;
            p.Price = Convert.ToDecimal(textBox2.Text);
            p.Quantity = Convert.ToDouble(textBox3.Text);
            po.Update(p);
            dataGridView1.DataSource = po.Select();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Tag = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            po.Delete((int)textBox1.Tag);
            dataGridView1.DataSource = po.Select();
        }
    }
}
