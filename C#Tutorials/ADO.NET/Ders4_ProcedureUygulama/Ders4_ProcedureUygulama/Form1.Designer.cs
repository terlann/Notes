
namespace Ders4_ProcedureUygulama
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMehsulAdi = new System.Windows.Forms.TextBox();
            this.nudQiymet = new System.Windows.Forms.NumericUpDown();
            this.NudStok = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQiymet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // txtMehsulAdi
            // 
            this.txtMehsulAdi.Location = new System.Drawing.Point(45, 125);
            this.txtMehsulAdi.Name = "txtMehsulAdi";
            this.txtMehsulAdi.Size = new System.Drawing.Size(100, 22);
            this.txtMehsulAdi.TabIndex = 1;
            // 
            // nudQiymet
            // 
            this.nudQiymet.Location = new System.Drawing.Point(164, 125);
            this.nudQiymet.Name = "nudQiymet";
            this.nudQiymet.Size = new System.Drawing.Size(109, 22);
            this.nudQiymet.TabIndex = 2;
            // 
            // NudStok
            // 
            this.NudStok.Location = new System.Drawing.Point(295, 125);
            this.NudStok.Name = "NudStok";
            this.NudStok.Size = new System.Drawing.Size(109, 22);
            this.NudStok.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qiymeti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "MehsulunAdi";
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.Location = new System.Drawing.Point(446, 112);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(111, 36);
            this.btnElaveEt.TabIndex = 4;
            this.btnElaveEt.Text = "Elave Et";
            this.btnElaveEt.UseVisualStyleBackColor = true;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(563, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Deyis";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(680, 112);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 36);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NudStok);
            this.Controls.Add(this.nudQiymet);
            this.Controls.Add(this.txtMehsulAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQiymet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMehsulAdi;
        private System.Windows.Forms.NumericUpDown nudQiymet;
        private System.Windows.Forms.NumericUpDown NudStok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

