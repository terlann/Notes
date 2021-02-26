
namespace CodeFirst_SIDU
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMehsulAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQiymet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MehsulAdinaGoreAxtar = new System.Windows.Forms.TextBox();
            this.rdbArtan = new System.Windows.Forms.RadioButton();
            this.rdbAzalan = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mehsul adi";
            // 
            // txtMehsulAdi
            // 
            this.txtMehsulAdi.Location = new System.Drawing.Point(12, 89);
            this.txtMehsulAdi.Multiline = true;
            this.txtMehsulAdi.Name = "txtMehsulAdi";
            this.txtMehsulAdi.Size = new System.Drawing.Size(150, 27);
            this.txtMehsulAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tedarikci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori";
            // 
            // txtQiymet
            // 
            this.txtQiymet.Location = new System.Drawing.Point(574, 89);
            this.txtQiymet.Multiline = true;
            this.txtQiymet.Name = "txtQiymet";
            this.txtQiymet.Size = new System.Drawing.Size(58, 27);
            this.txtQiymet.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qiymet";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(739, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(180, 40);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(739, 76);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(180, 40);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(951, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(951, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(201, 89);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(147, 24);
            this.cmbTedarikci.TabIndex = 10;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(387, 90);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(146, 24);
            this.cmbKategori.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mehsul adina gore axtaris";
            // 
            // txt_MehsulAdinaGoreAxtar
            // 
            this.txt_MehsulAdinaGoreAxtar.Location = new System.Drawing.Point(12, 533);
            this.txt_MehsulAdinaGoreAxtar.Name = "txt_MehsulAdinaGoreAxtar";
            this.txt_MehsulAdinaGoreAxtar.Size = new System.Drawing.Size(170, 22);
            this.txt_MehsulAdinaGoreAxtar.TabIndex = 13;
            this.txt_MehsulAdinaGoreAxtar.TextChanged += new System.EventHandler(this.txt_MehsulAdinaGoreAxtar_TextChanged);
            // 
            // rdbArtan
            // 
            this.rdbArtan.AutoSize = true;
            this.rdbArtan.Location = new System.Drawing.Point(201, 529);
            this.rdbArtan.Name = "rdbArtan";
            this.rdbArtan.Size = new System.Drawing.Size(158, 21);
            this.rdbArtan.TabIndex = 14;
            this.rdbArtan.Text = "Qiymeti artan sira ile";
            this.rdbArtan.UseVisualStyleBackColor = true;
            this.rdbArtan.CheckedChanged += new System.EventHandler(this.rdbArtan_CheckedChanged);
            // 
            // rdbAzalan
            // 
            this.rdbAzalan.AutoSize = true;
            this.rdbAzalan.Location = new System.Drawing.Point(382, 529);
            this.rdbAzalan.Name = "rdbAzalan";
            this.rdbAzalan.Size = new System.Drawing.Size(164, 21);
            this.rdbAzalan.TabIndex = 14;
            this.rdbAzalan.Text = "Qiymet azalan sira ile";
            this.rdbAzalan.UseVisualStyleBackColor = true;
            this.rdbAzalan.CheckedChanged += new System.EventHandler(this.rdbAzalan_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(574, 529);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ilk nece qeyd gorunsun?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(1008, 512);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(123, 33);
            this.btnRapor.TabIndex = 17;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 572);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rdbAzalan);
            this.Controls.Add(this.rdbArtan);
            this.Controls.Add(this.txt_MehsulAdinaGoreAxtar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtQiymet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMehsulAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMehsulAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQiymet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MehsulAdinaGoreAxtar;
        private System.Windows.Forms.RadioButton rdbArtan;
        private System.Windows.Forms.RadioButton rdbAzalan;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRapor;
    }
}

