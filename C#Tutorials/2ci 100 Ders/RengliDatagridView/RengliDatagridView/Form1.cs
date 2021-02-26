using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RengliDatagridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Urunler", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (i%2== 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
