
namespace ToBase64_IleSifreleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNormalHal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifreliHal = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnSifredenCixar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normal hal";
            // 
            // txtNormalHal
            // 
            this.txtNormalHal.Location = new System.Drawing.Point(264, 99);
            this.txtNormalHal.Multiline = true;
            this.txtNormalHal.Name = "txtNormalHal";
            this.txtNormalHal.Size = new System.Drawing.Size(193, 31);
            this.txtNormalHal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sfireli hal";
            // 
            // txtSifreliHal
            // 
            this.txtSifreliHal.Location = new System.Drawing.Point(264, 154);
            this.txtSifreliHal.Multiline = true;
            this.txtSifreliHal.Name = "txtSifreliHal";
            this.txtSifreliHal.Size = new System.Drawing.Size(193, 33);
            this.txtSifreliHal.TabIndex = 1;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(214, 233);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(129, 40);
            this.btnSifrele.TabIndex = 2;
            this.btnSifrele.Text = "Sifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnSifredenCixar
            // 
            this.btnSifredenCixar.Location = new System.Drawing.Point(398, 233);
            this.btnSifredenCixar.Name = "btnSifredenCixar";
            this.btnSifredenCixar.Size = new System.Drawing.Size(129, 40);
            this.btnSifredenCixar.TabIndex = 2;
            this.btnSifredenCixar.Text = "Sifreden Cixar";
            this.btnSifredenCixar.UseVisualStyleBackColor = true;
            this.btnSifredenCixar.Click += new System.EventHandler(this.btnSifredenCixar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSifredenCixar);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtSifreliHal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNormalHal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNormalHal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifreliHal;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnSifredenCixar;
    }
}

