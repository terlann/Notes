
namespace PictureGetSet
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PictureSetGetDataSet = new PictureGetSet.DB_PictureSetGetDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenFD = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.productNameTableAdapter = new PictureGetSet.DB_PictureSetGetDataSetTableAdapters.ProductNameTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSekilCek = new System.Windows.Forms.Button();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.btnCameraniAc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PictureSetGetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 40);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(123, 22);
            this.txtProductName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.productNameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(590, 214);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 30F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "ProductName";
            this.productNameBindingSource.DataSource = this.dB_PictureSetGetDataSet;
            // 
            // dB_PictureSetGetDataSet
            // 
            this.dB_PictureSetGetDataSet.DataSetName = "DB_PictureSetGetDataSet";
            this.dB_PictureSetGetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(348, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenFD
            // 
            this.btnOpenFD.Location = new System.Drawing.Point(141, 89);
            this.btnOpenFD.Name = "btnOpenFD";
            this.btnOpenFD.Size = new System.Drawing.Size(37, 29);
            this.btnOpenFD.TabIndex = 4;
            this.btnOpenFD.Text = "...";
            this.btnOpenFD.UseVisualStyleBackColor = true;
            this.btnOpenFD.Click += new System.EventHandler(this.btnOpenFD_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // productNameTableAdapter
            // 
            this.productNameTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(623, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(349, 479);
            this.dataGridView2.TabIndex = 5;
            // 
            // btnSekilCek
            // 
            this.btnSekilCek.Location = new System.Drawing.Point(243, 214);
            this.btnSekilCek.Name = "btnSekilCek";
            this.btnSekilCek.Size = new System.Drawing.Size(99, 30);
            this.btnSekilCek.TabIndex = 6;
            this.btnSekilCek.Text = "Sekil Cek";
            this.btnSekilCek.UseVisualStyleBackColor = true;
            this.btnSekilCek.Click += new System.EventHandler(this.btnSekilCek_Click);
            // 
            // cmbCameras
            // 
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(348, 259);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(254, 24);
            this.cmbCameras.TabIndex = 7;
            // 
            // btnCameraniAc
            // 
            this.btnCameraniAc.Location = new System.Drawing.Point(243, 181);
            this.btnCameraniAc.Name = "btnCameraniAc";
            this.btnCameraniAc.Size = new System.Drawing.Size(99, 27);
            this.btnCameraniAc.TabIndex = 8;
            this.btnCameraniAc.Text = "Camerani ac";
            this.btnCameraniAc.UseVisualStyleBackColor = true;
            this.btnCameraniAc.Click += new System.EventHandler(this.btnCameraniAc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1042, 531);
            this.Controls.Add(this.btnCameraniAc);
            this.Controls.Add(this.cmbCameras);
            this.Controls.Add(this.btnSekilCek);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnOpenFD);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProductName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PictureSetGetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenFD;
        private System.Windows.Forms.Button btnUpdate;
        private DB_PictureSetGetDataSet dB_PictureSetGetDataSet;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private DB_PictureSetGetDataSetTableAdapters.ProductNameTableAdapter productNameTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button btnSekilCek;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.Button btnCameraniAc;
    }
}

