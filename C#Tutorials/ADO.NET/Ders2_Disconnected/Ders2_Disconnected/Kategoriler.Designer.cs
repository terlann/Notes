
namespace Ders2_Disconnected
{
    partial class Kategoriler
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
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtTanimi = new System.Windows.Forms.TextBox();
            this.btnKategoriElaveEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 263);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(42, 131);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(139, 22);
            this.txtKategoriAdi.TabIndex = 2;
            // 
            // txtTanimi
            // 
            this.txtTanimi.Location = new System.Drawing.Point(201, 131);
            this.txtTanimi.Name = "txtTanimi";
            this.txtTanimi.Size = new System.Drawing.Size(139, 22);
            this.txtTanimi.TabIndex = 2;
            // 
            // btnKategoriElaveEt
            // 
            this.btnKategoriElaveEt.Location = new System.Drawing.Point(400, 129);
            this.btnKategoriElaveEt.Name = "btnKategoriElaveEt";
            this.btnKategoriElaveEt.Size = new System.Drawing.Size(112, 23);
            this.btnKategoriElaveEt.TabIndex = 3;
            this.btnKategoriElaveEt.Text = "Kategori Elave et";
            this.btnKategoriElaveEt.UseVisualStyleBackColor = true;
            this.btnKategoriElaveEt.Click += new System.EventHandler(this.btnKategoriElaveEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanimi";
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKategoriElaveEt);
            this.Controls.Add(this.txtTanimi);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.TextBox txtTanimi;
        private System.Windows.Forms.Button btnKategoriElaveEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}