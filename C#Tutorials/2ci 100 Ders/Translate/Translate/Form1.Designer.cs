
namespace Translate
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
            this.richtxtEng = new System.Windows.Forms.RichTextBox();
            this.richtxtAz = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtnAZ_EN = new System.Windows.Forms.RadioButton();
            this.radiobtnEn_Az = new System.Windows.Forms.RadioButton();
            this.btnCevir = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // richtxtEng
            // 
            this.richtxtEng.Location = new System.Drawing.Point(416, 49);
            this.richtxtEng.Name = "richtxtEng";
            this.richtxtEng.Size = new System.Drawing.Size(287, 120);
            this.richtxtEng.TabIndex = 0;
            this.richtxtEng.Text = "";
            this.richtxtEng.TextChanged += new System.EventHandler(this.richtxtEng_TextChanged);
            // 
            // richtxtAz
            // 
            this.richtxtAz.Location = new System.Drawing.Point(53, 49);
            this.richtxtAz.Name = "richtxtAz";
            this.richtxtAz.Size = new System.Drawing.Size(287, 120);
            this.richtxtAz.TabIndex = 0;
            this.richtxtAz.Text = "";
            this.richtxtAz.TextChanged += new System.EventHandler(this.richtxtAz_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Az";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eng";
            // 
            // radiobtnAZ_EN
            // 
            this.radiobtnAZ_EN.AutoSize = true;
            this.radiobtnAZ_EN.Location = new System.Drawing.Point(301, 231);
            this.radiobtnAZ_EN.Name = "radiobtnAZ_EN";
            this.radiobtnAZ_EN.Size = new System.Drawing.Size(70, 21);
            this.radiobtnAZ_EN.TabIndex = 2;
            this.radiobtnAZ_EN.TabStop = true;
            this.radiobtnAZ_EN.Text = "Az>En";
            this.radiobtnAZ_EN.UseVisualStyleBackColor = true;
            this.radiobtnAZ_EN.CheckedChanged += new System.EventHandler(this.radiobtnAZ_EN_CheckedChanged);
            // 
            // radiobtnEn_Az
            // 
            this.radiobtnEn_Az.AutoSize = true;
            this.radiobtnEn_Az.Location = new System.Drawing.Point(301, 258);
            this.radiobtnEn_Az.Name = "radiobtnEn_Az";
            this.radiobtnEn_Az.Size = new System.Drawing.Size(70, 21);
            this.radiobtnEn_Az.TabIndex = 2;
            this.radiobtnEn_Az.TabStop = true;
            this.radiobtnEn_Az.Text = "En>Az";
            this.radiobtnEn_Az.UseVisualStyleBackColor = true;
            this.radiobtnEn_Az.CheckedChanged += new System.EventHandler(this.radiobtnEn_Az_CheckedChanged);
            // 
            // btnCevir
            // 
            this.btnCevir.Location = new System.Drawing.Point(261, 297);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(154, 37);
            this.btnCevir.TabIndex = 3;
            this.btnCevir.Text = "Cevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(661, 334);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(99, 80);
            this.webBrowser1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.radiobtnEn_Az);
            this.Controls.Add(this.radiobtnAZ_EN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxtAz);
            this.Controls.Add(this.richtxtEng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtEng;
        private System.Windows.Forms.RichTextBox richtxtAz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobtnAZ_EN;
        private System.Windows.Forms.RadioButton radiobtnEn_Az;
        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

