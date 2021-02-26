
namespace Ders_5_N_Tier_Mimari
{
    partial class Form_Urunler
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
            this.dtgridUrunler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMehsulAdi = new System.Windows.Forms.TextBox();
            this.nudQiymeti = new System.Windows.Forms.NumericUpDown();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.brnElaveEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Yenile = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.cmbTedarikciler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQiymeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridUrunler
            // 
            this.dtgridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridUrunler.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgridUrunler.Location = new System.Drawing.Point(31, 121);
            this.dtgridUrunler.Name = "dtgridUrunler";
            this.dtgridUrunler.RowHeadersWidth = 51;
            this.dtgridUrunler.RowTemplate.Height = 24;
            this.dtgridUrunler.Size = new System.Drawing.Size(927, 317);
            this.dtgridUrunler.TabIndex = 0;
            this.dtgridUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridUrunler_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 52);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.yenileToolStripMenuItem.Text = "Yenile";
            // 
            // txtMehsulAdi
            // 
            this.txtMehsulAdi.Location = new System.Drawing.Point(31, 35);
            this.txtMehsulAdi.Name = "txtMehsulAdi";
            this.txtMehsulAdi.Size = new System.Drawing.Size(124, 22);
            this.txtMehsulAdi.TabIndex = 1;
            // 
            // nudQiymeti
            // 
            this.nudQiymeti.Location = new System.Drawing.Point(194, 36);
            this.nudQiymeti.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQiymeti.Name = "nudQiymeti";
            this.nudQiymeti.Size = new System.Drawing.Size(144, 22);
            this.nudQiymeti.TabIndex = 2;
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(382, 36);
            this.nudStok.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(139, 22);
            this.nudStok.TabIndex = 2;
            // 
            // brnElaveEt
            // 
            this.brnElaveEt.Location = new System.Drawing.Point(558, 69);
            this.brnElaveEt.Name = "brnElaveEt";
            this.brnElaveEt.Size = new System.Drawing.Size(92, 44);
            this.brnElaveEt.TabIndex = 3;
            this.brnElaveEt.Text = "Elave Et";
            this.brnElaveEt.UseVisualStyleBackColor = true;
            this.brnElaveEt.Click += new System.EventHandler(this.brnElaveEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "MehsulAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qiymeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok";
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.Location = new System.Drawing.Point(656, 68);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(92, 44);
            this.btn_Yenile.TabIndex = 3;
            this.btn_Yenile.Text = "Yenile";
            this.btn_Yenile.UseVisualStyleBackColor = true;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(754, 68);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 44);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(964, 121);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(61, 185);
            this.btnKategoriler.TabIndex = 5;
            this.btnKategoriler.Text = "Ka\r\nte\r\ngo\r\nri\r\nler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(34, 90);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(212, 24);
            this.cmbKategoriler.TabIndex = 6;
            // 
            // cmbTedarikciler
            // 
            this.cmbTedarikciler.FormattingEnabled = true;
            this.cmbTedarikciler.Location = new System.Drawing.Point(309, 90);
            this.cmbTedarikciler.Name = "cmbTedarikciler";
            this.cmbTedarikciler.Size = new System.Drawing.Size(212, 24);
            this.cmbTedarikciler.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "KategoriAdi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "TedarikciAdi";
            // 
            // Form_Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.cmbTedarikciler);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.btnKategoriler);
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
            this.Controls.Add(this.dtgridUrunler);
            this.Name = "Form_Urunler";
            this.Text = "Ururnler";
            this.Load += new System.EventHandler(this.Form_Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQiymeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridUrunler;
        private System.Windows.Forms.TextBox txtMehsulAdi;
        private System.Windows.Forms.NumericUpDown nudQiymeti;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Button brnElaveEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ComboBox cmbTedarikciler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

