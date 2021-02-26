
namespace Ders2_Disconnected
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMehsulunAdi = new System.Windows.Forms.TextBox();
            this.nudSayi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.btnKategiler = new System.Windows.Forms.Button();
            this.btnDeyis = new System.Windows.Forms.Button();
            this.txtQiymeti = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQiymeti)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(987, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtMehsulunAdi
            // 
            this.txtMehsulunAdi.Location = new System.Drawing.Point(21, 98);
            this.txtMehsulunAdi.Name = "txtMehsulunAdi";
            this.txtMehsulunAdi.Size = new System.Drawing.Size(143, 22);
            this.txtMehsulunAdi.TabIndex = 0;
            // 
            // nudSayi
            // 
            this.nudSayi.Location = new System.Drawing.Point(333, 97);
            this.nudSayi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSayi.Name = "nudSayi";
            this.nudSayi.Size = new System.Drawing.Size(76, 22);
            this.nudSayi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mehsulun adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Qiymeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sayi";
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.Location = new System.Drawing.Point(442, 86);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(144, 44);
            this.btnElaveEt.TabIndex = 3;
            this.btnElaveEt.Text = "Elave Et";
            this.btnElaveEt.UseVisualStyleBackColor = true;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // btnKategiler
            // 
            this.btnKategiler.Location = new System.Drawing.Point(601, 86);
            this.btnKategiler.Name = "btnKategiler";
            this.btnKategiler.Size = new System.Drawing.Size(121, 44);
            this.btnKategiler.TabIndex = 8;
            this.btnKategiler.Text = "Kategoriler";
            this.btnKategiler.UseVisualStyleBackColor = true;
            this.btnKategiler.Click += new System.EventHandler(this.btnKategiler_Click);
            // 
            // btnDeyis
            // 
            this.btnDeyis.Location = new System.Drawing.Point(740, 85);
            this.btnDeyis.Name = "btnDeyis";
            this.btnDeyis.Size = new System.Drawing.Size(151, 44);
            this.btnDeyis.TabIndex = 9;
            this.btnDeyis.Text = "Deyis";
            this.btnDeyis.UseVisualStyleBackColor = true;
            this.btnDeyis.Click += new System.EventHandler(this.btnDeyis_Click);
            // 
            // txtQiymeti
            // 
            this.txtQiymeti.Location = new System.Drawing.Point(216, 99);
            this.txtQiymeti.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtQiymeti.Name = "txtQiymeti";
            this.txtQiymeti.Size = new System.Drawing.Size(76, 22);
            this.txtQiymeti.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 497);
            this.Controls.Add(this.btnDeyis);
            this.Controls.Add(this.btnKategiler);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQiymeti);
            this.Controls.Add(this.nudSayi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMehsulunAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQiymeti)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMehsulunAdi;
        private System.Windows.Forms.NumericUpDown nudSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Button btnKategiler;
        private System.Windows.Forms.Button btnDeyis;
        private System.Windows.Forms.NumericUpDown txtQiymeti;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

