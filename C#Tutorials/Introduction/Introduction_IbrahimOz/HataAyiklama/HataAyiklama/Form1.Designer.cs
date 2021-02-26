namespace HataAyiklama
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
            this.txtSay1 = new System.Windows.Forms.TextBox();
            this.txtSay2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesabla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Say1";
            // 
            // txtSay1
            // 
            this.txtSay1.Location = new System.Drawing.Point(161, 81);
            this.txtSay1.Name = "txtSay1";
            this.txtSay1.Size = new System.Drawing.Size(100, 20);
            this.txtSay1.TabIndex = 1;
            // 
            // txtSay2
            // 
            this.txtSay2.Location = new System.Drawing.Point(161, 118);
            this.txtSay2.Name = "txtSay2";
            this.txtSay2.Size = new System.Drawing.Size(100, 20);
            this.txtSay2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Say2";
            // 
            // btnHesabla
            // 
            this.btnHesabla.Location = new System.Drawing.Point(186, 161);
            this.btnHesabla.Name = "btnHesabla";
            this.btnHesabla.Size = new System.Drawing.Size(75, 23);
            this.btnHesabla.TabIndex = 4;
            this.btnHesabla.Text = "Hesabla";
            this.btnHesabla.UseVisualStyleBackColor = true;
            this.btnHesabla.Click += new System.EventHandler(this.btnHesabla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHesabla);
            this.Controls.Add(this.txtSay2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSay1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSay1;
        private System.Windows.Forms.TextBox txtSay2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesabla;
        private System.Windows.Forms.Label label3;
    }
}

