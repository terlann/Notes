
namespace Ders_19_XmlYazma
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
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilmKategori = new System.Windows.Forms.ComboBox();
            this.dtpFilmYaranmaIli = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYaradici = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIMDBPuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOyuncuAdi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOyuncuElaveEt = new System.Windows.Forms.Button();
            this.btnFilmElaveEt = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDBtoXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(13, 41);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(100, 22);
            this.txtFilmAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "FilmAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "FilmKategorisi";
            // 
            // cmbFilmKategori
            // 
            this.cmbFilmKategori.FormattingEnabled = true;
            this.cmbFilmKategori.Items.AddRange(new object[] {
            "Mafya",
            "Romantik"});
            this.cmbFilmKategori.Location = new System.Drawing.Point(149, 39);
            this.cmbFilmKategori.Name = "cmbFilmKategori";
            this.cmbFilmKategori.Size = new System.Drawing.Size(121, 24);
            this.cmbFilmKategori.TabIndex = 1;
            // 
            // dtpFilmYaranmaIli
            // 
            this.dtpFilmYaranmaIli.CustomFormat = "yyyy";
            this.dtpFilmYaranmaIli.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilmYaranmaIli.Location = new System.Drawing.Point(291, 41);
            this.dtpFilmYaranmaIli.Name = "dtpFilmYaranmaIli";
            this.dtpFilmYaranmaIli.Size = new System.Drawing.Size(107, 22);
            this.dtpFilmYaranmaIli.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Film Yaranma Tarixi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yaradici";
            // 
            // txtYaradici
            // 
            this.txtYaradici.Location = new System.Drawing.Point(445, 41);
            this.txtYaradici.Name = "txtYaradici";
            this.txtYaradici.Size = new System.Drawing.Size(100, 22);
            this.txtYaradici.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "IMDBPuan";
            // 
            // txtIMDBPuan
            // 
            this.txtIMDBPuan.Location = new System.Drawing.Point(564, 41);
            this.txtIMDBPuan.Name = "txtIMDBPuan";
            this.txtIMDBPuan.Size = new System.Drawing.Size(100, 22);
            this.txtIMDBPuan.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Oyuncu Adi";
            // 
            // txtOyuncuAdi
            // 
            this.txtOyuncuAdi.Location = new System.Drawing.Point(16, 109);
            this.txtOyuncuAdi.Name = "txtOyuncuAdi";
            this.txtOyuncuAdi.Size = new System.Drawing.Size(254, 22);
            this.txtOyuncuAdi.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 372);
            this.listBox1.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(291, 177);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(937, 372);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FilmAdi";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FilmKategori";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Film Yaranma ili";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yaradici";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "IMDBPuan";
            this.columnHeader5.Width = 83;
            // 
            // btnOyuncuElaveEt
            // 
            this.btnOyuncuElaveEt.Location = new System.Drawing.Point(16, 138);
            this.btnOyuncuElaveEt.Name = "btnOyuncuElaveEt";
            this.btnOyuncuElaveEt.Size = new System.Drawing.Size(254, 28);
            this.btnOyuncuElaveEt.TabIndex = 7;
            this.btnOyuncuElaveEt.Text = "Oyuncu Elave Et";
            this.btnOyuncuElaveEt.UseVisualStyleBackColor = true;
            this.btnOyuncuElaveEt.Click += new System.EventHandler(this.btnOyuncuElaveEt_Click);
            // 
            // btnFilmElaveEt
            // 
            this.btnFilmElaveEt.Location = new System.Drawing.Point(695, 39);
            this.btnFilmElaveEt.Name = "btnFilmElaveEt";
            this.btnFilmElaveEt.Size = new System.Drawing.Size(124, 23);
            this.btnFilmElaveEt.TabIndex = 5;
            this.btnFilmElaveEt.Text = "Film Elave Et";
            this.btnFilmElaveEt.UseVisualStyleBackColor = true;
            this.btnFilmElaveEt.Click += new System.EventHandler(this.btnFilmElaveEt_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Oyuncular";
            this.columnHeader6.Width = 281;
            // 
            // btnDBtoXML
            // 
            this.btnDBtoXML.Location = new System.Drawing.Point(695, 90);
            this.btnDBtoXML.Name = "btnDBtoXML";
            this.btnDBtoXML.Size = new System.Drawing.Size(131, 29);
            this.btnDBtoXML.TabIndex = 12;
            this.btnDBtoXML.Text = "DB To XML";
            this.btnDBtoXML.UseVisualStyleBackColor = true;
            this.btnDBtoXML.Click += new System.EventHandler(this.btnDBtoXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 568);
            this.Controls.Add(this.btnDBtoXML);
            this.Controls.Add(this.btnFilmElaveEt);
            this.Controls.Add(this.btnOyuncuElaveEt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOyuncuAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIMDBPuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYaradici);
            this.Controls.Add(this.dtpFilmYaranmaIli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFilmKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilmKategori;
        private System.Windows.Forms.DateTimePicker dtpFilmYaranmaIli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYaradici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIMDBPuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOyuncuAdi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnOyuncuElaveEt;
        private System.Windows.Forms.Button btnFilmElaveEt;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnDBtoXML;
    }
}

