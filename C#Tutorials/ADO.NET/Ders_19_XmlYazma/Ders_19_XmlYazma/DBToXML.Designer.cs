
namespace Ders_19_XmlYazma
{
    partial class DBToXML
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
            this.btnUrunlerToXml = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrunlerXmlDosyasiniListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunlerToXml
            // 
            this.btnUrunlerToXml.Location = new System.Drawing.Point(12, 12);
            this.btnUrunlerToXml.Name = "btnUrunlerToXml";
            this.btnUrunlerToXml.Size = new System.Drawing.Size(254, 50);
            this.btnUrunlerToXml.TabIndex = 0;
            this.btnUrunlerToXml.Text = "Urunler Ucun XML";
            this.btnUrunlerToXml.UseVisualStyleBackColor = true;
            this.btnUrunlerToXml.Click += new System.EventHandler(this.btnUrunlerToXml_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 251);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnUrunlerXmlDosyasiniListele
            // 
            this.btnUrunlerXmlDosyasiniListele.Location = new System.Drawing.Point(301, 13);
            this.btnUrunlerXmlDosyasiniListele.Name = "btnUrunlerXmlDosyasiniListele";
            this.btnUrunlerXmlDosyasiniListele.Size = new System.Drawing.Size(274, 49);
            this.btnUrunlerXmlDosyasiniListele.TabIndex = 2;
            this.btnUrunlerXmlDosyasiniListele.Text = "UrunlerXml dosyasini listele";
            this.btnUrunlerXmlDosyasiniListele.UseVisualStyleBackColor = true;
            this.btnUrunlerXmlDosyasiniListele.Click += new System.EventHandler(this.btnUrunlerXmlDosyasiniListele_Click);
            // 
            // DBToXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 551);
            this.Controls.Add(this.btnUrunlerXmlDosyasiniListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUrunlerToXml);
            this.Name = "DBToXML";
            this.Text = "DBToXML";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunlerToXml;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunlerXmlDosyasiniListele;
    }
}