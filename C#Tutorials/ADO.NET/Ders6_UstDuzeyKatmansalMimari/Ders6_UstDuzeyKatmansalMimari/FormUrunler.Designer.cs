
namespace Ders6_UstDuzeyKatmansalMimari
{
    partial class FormUrunler
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
            this.cmbTedarikciler = new System.Windows.Forms.ComboBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btn_Yenile = new System.Windows.Forms.Button();
            this.brnElaveEt = new System.Windows.Forms.Button();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.nudQiymeti = new System.Windows.Forms.NumericUpDown();
            this.txtMehsulAdi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQiymeti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbTedarikciler
            // 
            this.cmbTedarikciler.FormattingEnabled = true;
            this.cmbTedarikciler.Location = new System.Drawing.Point(308, 111);
            this.cmbTedarikciler.Name = "cmbTedarikciler";
            this.cmbTedarikciler.Size = new System.Drawing.Size(212, 24);
            this.cmbTedarikciler.TabIndex = 18;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(31, 111);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(212, 24);
            this.cmbKategoriler.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Qiymeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "TedarikciAdi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "KategoriAdi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "MehsulAdi";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(753, 89);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 44);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.Location = new System.Drawing.Point(655, 89);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(92, 44);
            this.btn_Yenile.TabIndex = 11;
            this.btn_Yenile.Text = "Yenile";
            this.btn_Yenile.UseVisualStyleBackColor = true;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // brnElaveEt
            // 
            this.brnElaveEt.Location = new System.Drawing.Point(557, 90);
            this.brnElaveEt.Name = "brnElaveEt";
            this.brnElaveEt.Size = new System.Drawing.Size(92, 44);
            this.brnElaveEt.TabIndex = 12;
            this.brnElaveEt.Text = "Elave Et";
            this.brnElaveEt.UseVisualStyleBackColor = true;
            this.brnElaveEt.Click += new System.EventHandler(this.brnElaveEt_Click);
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(381, 57);
            this.nudStok.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(139, 22);
            this.nudStok.TabIndex = 8;
            // 
            // nudQiymeti
            // 
            this.nudQiymeti.Location = new System.Drawing.Point(193, 57);
            this.nudQiymeti.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQiymeti.Name = "nudQiymeti";
            this.nudQiymeti.Size = new System.Drawing.Size(144, 22);
            this.nudQiymeti.TabIndex = 9;
            // 
            // txtMehsulAdi
            // 
            this.txtMehsulAdi.Location = new System.Drawing.Point(30, 56);
            this.txtMehsulAdi.Name = "txtMehsulAdi";
            this.txtMehsulAdi.Size = new System.Drawing.Size(124, 22);
            this.txtMehsulAdi.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(599, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 20;
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbTedarikciler);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btn_Yenile);
            this.Controls.Add(this.brnElaveEt);
            this.Controls.Add(this.nudStok);
            this.Controls.Add(this.nudQiymeti);
            this.Controls.Add(this.txtMehsulAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUrunler";
            this.Text = "FormUrunler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQiymeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbTedarikciler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.Button brnElaveEt;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.NumericUpDown nudQiymeti;
        private System.Windows.Forms.TextBox txtMehsulAdi;
        private System.Windows.Forms.TextBox textBox1;
    }
}