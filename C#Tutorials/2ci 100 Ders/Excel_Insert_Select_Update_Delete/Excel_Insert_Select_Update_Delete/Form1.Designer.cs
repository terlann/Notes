
namespace Excel_Insert_Select_Update_Delete
{
    partial class btnExportToExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDisplayDataFromSql = new System.Windows.Forms.Button();
            this.btnDisplayDataFromExcel = new System.Windows.Forms.Button();
            this.btnExportExcelToSql = new System.Windows.Forms.Button();
            this.cmbSheets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Export To Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisplayDataFromSql
            // 
            this.btnDisplayDataFromSql.Location = new System.Drawing.Point(15, 23);
            this.btnDisplayDataFromSql.Name = "btnDisplayDataFromSql";
            this.btnDisplayDataFromSql.Size = new System.Drawing.Size(341, 41);
            this.btnDisplayDataFromSql.TabIndex = 6;
            this.btnDisplayDataFromSql.Text = "Display Data From Sql";
            this.btnDisplayDataFromSql.UseVisualStyleBackColor = true;
            this.btnDisplayDataFromSql.Click += new System.EventHandler(this.btnDisplayDataFromSql_Click);
            // 
            // btnDisplayDataFromExcel
            // 
            this.btnDisplayDataFromExcel.Location = new System.Drawing.Point(15, 106);
            this.btnDisplayDataFromExcel.Name = "btnDisplayDataFromExcel";
            this.btnDisplayDataFromExcel.Size = new System.Drawing.Size(341, 41);
            this.btnDisplayDataFromExcel.TabIndex = 6;
            this.btnDisplayDataFromExcel.Text = "Display Data From Excel";
            this.btnDisplayDataFromExcel.UseVisualStyleBackColor = true;
            this.btnDisplayDataFromExcel.Click += new System.EventHandler(this.btnDisplayDataFromExcel_Click);
            // 
            // btnExportExcelToSql
            // 
            this.btnExportExcelToSql.Location = new System.Drawing.Point(373, 106);
            this.btnExportExcelToSql.Name = "btnExportExcelToSql";
            this.btnExportExcelToSql.Size = new System.Drawing.Size(226, 40);
            this.btnExportExcelToSql.TabIndex = 7;
            this.btnExportExcelToSql.Text = "Export Excel To Sql";
            this.btnExportExcelToSql.UseVisualStyleBackColor = true;
            this.btnExportExcelToSql.Click += new System.EventHandler(this.btnExportExcelToSql_Click);
            // 
            // cmbSheets
            // 
            this.cmbSheets.FormattingEnabled = true;
            this.cmbSheets.Location = new System.Drawing.Point(70, 201);
            this.cmbSheets.Name = "cmbSheets";
            this.cmbSheets.Size = new System.Drawing.Size(213, 24);
            this.cmbSheets.TabIndex = 8;
            this.cmbSheets.SelectedIndexChanged += new System.EventHandler(this.cmbSheets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sheets";
            // 
            // txtSheetName
            // 
            this.txtSheetName.Location = new System.Drawing.Point(70, 170);
            this.txtSheetName.Multiline = true;
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(213, 25);
            this.txtSheetName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sheets";
            // 
            // btnExportToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSheetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSheets);
            this.Controls.Add(this.btnExportExcelToSql);
            this.Controls.Add(this.btnDisplayDataFromExcel);
            this.Controls.Add(this.btnDisplayDataFromSql);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "btnExportToExcel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDisplayDataFromSql;
        private System.Windows.Forms.Button btnDisplayDataFromExcel;
        private System.Windows.Forms.Button btnExportExcelToSql;
        private System.Windows.Forms.ComboBox cmbSheets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.Label label2;
    }
}

