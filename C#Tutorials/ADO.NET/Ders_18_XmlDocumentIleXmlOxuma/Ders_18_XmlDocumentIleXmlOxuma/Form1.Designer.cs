
namespace Ders_18_XmlDocumentIleXmlOxuma
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
            this.LBoxBasliqlar = new System.Windows.Forms.ListBox();
            this.LBoxAciqlama = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAciqlama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBoxBasliqlar
            // 
            this.LBoxBasliqlar.FormattingEnabled = true;
            this.LBoxBasliqlar.ItemHeight = 16;
            this.LBoxBasliqlar.Location = new System.Drawing.Point(12, 136);
            this.LBoxBasliqlar.Name = "LBoxBasliqlar";
            this.LBoxBasliqlar.Size = new System.Drawing.Size(359, 420);
            this.LBoxBasliqlar.TabIndex = 0;
            this.LBoxBasliqlar.SelectedIndexChanged += new System.EventHandler(this.LBoxBasliqlar_SelectedIndexChanged);
            // 
            // LBoxAciqlama
            // 
            this.LBoxAciqlama.FormattingEnabled = true;
            this.LBoxAciqlama.ItemHeight = 16;
            this.LBoxAciqlama.Location = new System.Drawing.Point(423, 136);
            this.LBoxAciqlama.Name = "LBoxAciqlama";
            this.LBoxAciqlama.Size = new System.Drawing.Size(678, 420);
            this.LBoxAciqlama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = ">>>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xeber basliqlari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xeber Detayli";
            // 
            // lblAciqlama
            // 
            this.lblAciqlama.AutoSize = true;
            this.lblAciqlama.Location = new System.Drawing.Point(364, 41);
            this.lblAciqlama.Name = "lblAciqlama";
            this.lblAciqlama.Size = new System.Drawing.Size(0, 17);
            this.lblAciqlama.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 568);
            this.Controls.Add(this.lblAciqlama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBoxAciqlama);
            this.Controls.Add(this.LBoxBasliqlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBoxBasliqlar;
        private System.Windows.Forms.ListBox LBoxAciqlama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAciqlama;
    }
}

