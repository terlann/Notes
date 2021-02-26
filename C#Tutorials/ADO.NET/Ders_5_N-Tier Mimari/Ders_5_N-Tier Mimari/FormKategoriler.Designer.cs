
namespace Ders_5_N_Tier_Mimari
{
    partial class FormKategoriler
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
            this.dtGridKategoriler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategori_Yenile = new System.Windows.Forms.Button();
            this.btnKategoriElaveEt = new System.Windows.Forms.Button();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtKategoriTanimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridKategoriler
            // 
            this.dtGridKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridKategoriler.Location = new System.Drawing.Point(50, 155);
            this.dtGridKategoriler.Name = "dtGridKategoriler";
            this.dtGridKategoriler.RowHeadersWidth = 51;
            this.dtGridKategoriler.RowTemplate.Height = 24;
            this.dtGridKategoriler.Size = new System.Drawing.Size(702, 273);
            this.dtGridKategoriler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "MehsulAdi";
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(592, 90);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(92, 44);
            this.btnKategoriSil.TabIndex = 8;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            // 
            // btnKategori_Yenile
            // 
            this.btnKategori_Yenile.Location = new System.Drawing.Point(494, 90);
            this.btnKategori_Yenile.Name = "btnKategori_Yenile";
            this.btnKategori_Yenile.Size = new System.Drawing.Size(92, 44);
            this.btnKategori_Yenile.TabIndex = 9;
            this.btnKategori_Yenile.Text = "Yenile";
            this.btnKategori_Yenile.UseVisualStyleBackColor = true;
            // 
            // btnKategoriElaveEt
            // 
            this.btnKategoriElaveEt.Location = new System.Drawing.Point(396, 91);
            this.btnKategoriElaveEt.Name = "btnKategoriElaveEt";
            this.btnKategoriElaveEt.Size = new System.Drawing.Size(92, 44);
            this.btnKategoriElaveEt.TabIndex = 10;
            this.btnKategoriElaveEt.Text = "Elave Et";
            this.btnKategoriElaveEt.UseVisualStyleBackColor = true;
            this.btnKategoriElaveEt.Click += new System.EventHandler(this.btnKategoriElaveEt_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(51, 112);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKategoriAdi.TabIndex = 5;
            // 
            // txtKategoriTanimi
            // 
            this.txtKategoriTanimi.Location = new System.Drawing.Point(188, 112);
            this.txtKategoriTanimi.Name = "txtKategoriTanimi";
            this.txtKategoriTanimi.Size = new System.Drawing.Size(100, 22);
            this.txtKategoriTanimi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "MehsulAdi";
            // 
            // FormKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnKategori_Yenile);
            this.Controls.Add(this.btnKategoriElaveEt);
            this.Controls.Add(this.txtKategoriTanimi);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.dtGridKategoriler);
            this.Name = "FormKategoriler";
            this.Text = "FormKategoriler";
            this.Load += new System.EventHandler(this.FormKategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridKategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategori_Yenile;
        private System.Windows.Forms.Button btnKategoriElaveEt;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.TextBox txtKategoriTanimi;
        private System.Windows.Forms.Label label2;
    }
}