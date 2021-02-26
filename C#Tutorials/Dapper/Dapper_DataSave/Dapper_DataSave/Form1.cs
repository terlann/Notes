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
using Dapper;
using System.Collections;

namespace Dapper_DataSave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DB_PictureSetGet;Integrated Security=True");
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save 
            // con.Execute("Insert into ProductName(Name) Values('" + textBox1.Text + "')");
            //con.Execute("Insert into ProductName(Name) Values(@padi)", new {padi ="Parametreli" }) ;

            //Update
            //con.Execute("Update ProductName set Name=@Name where ProductID=@id", new { Name = "Update", id = 32 });

            //Delete
            //con.Execute("Delete ProductName where ProductID=@id", new { id = 22 });

            //StoredProcedura
            //var prc = con.ExecuteReader("prc_ProductSelect", new { id = 10 }, commandType: CommandType.StoredProcedure);
            //DataTable dt = new DataTable();
            //dt.Load(prc);
            //dataGridView1.DataSource = dt;


            //ExecuteDataReader
            //var reader = con.ExecuteReader("Select * from ProductName where ProductID=33");
            //while (reader.Read())
            //{
            //    textBox1.Text = reader.IsDBNull(1) ? "bos" : "Dolu";
            //}
            //------
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //dataGridView1.DataSource = dt;

            //ExecuteScalar(ExecuteScalar hemise Select olunan sorgunun ilk setirindeki ve ilk stunundaki deyeri getirmey ucundur)
            //var execScalar = con.ExecuteScalar("Select Name from ProductName");
            //textBox1.Text = execScalar.ToString();


            //Query
            //var qry = con.Query("Select * from ProductName");
            //foreach (var clm in qry)
            //{
            //    listBox1.Items.Add(clm.ProductID+"  "+clm.Name);
            //}

           
        }
    }
}
