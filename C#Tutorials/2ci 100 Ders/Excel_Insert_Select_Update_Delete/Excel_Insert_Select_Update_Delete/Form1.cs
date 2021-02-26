using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.IO;
using ExcelDataReader;

namespace Excel_Insert_Select_Update_Delete
{
    public partial class btnExportToExcel : Form
    {
        public btnExportToExcel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");

        public Func<object, ExcelDataTableConfiguration> ConfigureDataTable { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==0)
            {
                excel.Application app = new excel.Application();
                app.Visible = true;
                Workbook book = app.Workbooks.Add(System.Reflection.Missing.Value);
                Worksheet page = book.Sheets[1];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Range area = page.Cells[1, 1]; //Hansi setir ve stundan baslamagini deyirik
                    area.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;//ve secdiyimiz setir ve stun yerinden yazamaga baslayiriq.
                }
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    for (int column = 0; column < dataGridView1.Columns.Count; column++)
                    {
                        Range area = page.Cells[2, 1];
                        area.Cells[row + 1, column + 1] = dataGridView1[column, row].Value;

                        //UNUTMA: Excelde birinci setir sonra strun qeyd olunur[setir,strun]
                        //Datagridvie'da ise birinci strun sonra ise setir qeyd olunur[stun,setir]
                    }
                }
            }
            else
            {
                excel.Application app = new excel.Application();
                app.Visible = true;
                Workbook book = app.Workbooks.Add(System.Reflection.Missing.Value);
                Worksheet page = book.Sheets[1];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Range area = page.Cells[1, 1]; //Hansi setir ve stundan baslamagini deyirik
                    area.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;//ve secdiyimiz setir ve stun yerinden yazamaga baslayiriq.
                }
                for (int row = 0; row < dataGridView1.SelectedRows.Count; row++)
                {
                    for (int c = 0; c < dataGridView1.SelectedRows[row].Cells.Count; c++)
                    {
                        Range area = page.Cells[2, 1];
                        area.Cells[row + 1, c + 1] = dataGridView1.SelectedRows[row].Cells[c].Value;
                    }
                }
            }
            
        }

        private void btnExportToExcelSelectedRows_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDisplayDataFromSql_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Urunler", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Urunler");
            dataGridView1.DataSource = ds.Tables["Urunler"];
        }
        DataTableCollection tableCollection;

        private void btnDisplayDataFromExcel_Click(object sender, EventArgs e)
        {
            //Ilk olaraq NuGet'den ExcelDataReader'i elave etmek lazimdir.
            //1 - ci usul
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //    ofd.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx";
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
            //        {
            //            using (IExcelDataReader dr = ExcelReaderFactory.CreateReader(stream))
            //            {
            //                DataSet ds = dr.AsDataSet(new ExcelDataSetConfiguration()
            //                {
            //                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
            //                    {
            //                        UseHeaderRow = true
            //                    }
            //                });
            //                tableCollection = ds.Tables;
            //                cmbSheets.Items.Clear();
            //                foreach (System.Data.DataTable table in tableCollection)
            //                {
            //                    cmbSheets.Items.Add(table.TableName);//add sheet to Combobox
            //                }
            //            }
            //        }
            //    }
            //}

            //2-ci usul
            try
            {
                if (string.IsNullOrWhiteSpace(txtSheetName.Text))
                    MessageBox.Show("Zehmet olmasa Sheet'i qeyd edin");
                else
                {
                    using (OpenFileDialog ofd = new OpenFileDialog())
                    {
                        ofd.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ofd.FileName + ";Extended Properties='Excel 12.0 Xml; HDR = Yes; Readonly = 0;'");
                            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [" + txtSheetName.Text + "$]", con);
                            DataSet ds = new DataSet();
                            tableCollection = ds.Tables;
                            da.Fill(ds);

                            dataGridView1.DataSource = ds.Tables[0];
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = tableCollection[cmbSheets.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void btnExportExcelToSql_Click(object sender, EventArgs e)
        {
            //Ilk olaraq NuGetden Z.Dapper.Plus yuklemey lazimdi

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KuzeyYeli;Integrated Security=True");

            try
            {
                if (dataGridView1.SelectedRows.Count ==0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into UrunlerTest Values(@prmID,@prmAdi,@prmTedarikciID,@prmKategoriID,@prmBirimdekiMiktar,@Fiyat,@Stok,@YeniSatis,@prmEnAzYenidenSatisMikatari,@Status)", con);
                        cmd.Parameters.AddWithValue("@prmID", dataGridView1[0, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmAdi", dataGridView1[1, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmTedarikciID", dataGridView1[2, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmKategoriID", dataGridView1[3, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmBirimdekiMiktar", dataGridView1[4, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@Fiyat", dataGridView1[5, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@Stok", dataGridView1[6, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@YeniSatis", dataGridView1[7, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmEnAzYenidenSatisMikatari", dataGridView1[8, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@Status", dataGridView1[9, i].Value.ToString());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into UrunlerTest Values(@prmID,@prmAdi,@prmTedarikciID,@prmKategoriID,@prmBirimdekiMiktar,@Fiyat,@Stok,@YeniSatis,@prmEnAzYenidenSatisMikatari,@Status)", con);
                        cmd.Parameters.AddWithValue("@prmID", dataGridView1[0, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmAdi", dataGridView1[1, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmTedarikciID", dataGridView1[2, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmKategoriID", dataGridView1[3, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmBirimdekiMiktar", dataGridView1[4, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@Fiyat", dataGridView1[5, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@Stok", dataGridView1[6, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@YeniSatis", dataGridView1[7, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@prmEnAzYenidenSatisMikatari", dataGridView1[8, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@Status", dataGridView1[9, i].Value.ToString());
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1[1, 0].Value.ToString());
        }

    }
}
