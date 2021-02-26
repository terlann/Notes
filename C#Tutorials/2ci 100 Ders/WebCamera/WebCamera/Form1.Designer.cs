
namespace WebCamera
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
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBaslad = new System.Windows.Forms.Button();
            this.btnSekilCek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kameralar";
            // 
            // cmbCameras
            // 
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(118, 41);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(418, 24);
            this.cmbCameras.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBaslad
            // 
            this.btnBaslad.Location = new System.Drawing.Point(118, 438);
            this.btnBaslad.Name = "btnBaslad";
            this.btnBaslad.Size = new System.Drawing.Size(185, 42);
            this.btnBaslad.TabIndex = 3;
            this.btnBaslad.Text = "Basla";
            this.btnBaslad.UseVisualStyleBackColor = true;
            this.btnBaslad.Click += new System.EventHandler(this.btnBaslad_Click);
            // 
            // btnSekilCek
            // 
            this.btnSekilCek.Location = new System.Drawing.Point(341, 438);
            this.btnSekilCek.Name = "btnSekilCek";
            this.btnSekilCek.Size = new System.Drawing.Size(195, 42);
            this.btnSekilCek.TabIndex = 3;
            this.btnSekilCek.Text = "SekilCek";
            this.btnSekilCek.UseVisualStyleBackColor = true;
            this.btnSekilCek.Click += new System.EventHandler(this.btnSekilCek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 532);
            this.Controls.Add(this.btnSekilCek);
            this.Controls.Add(this.btnBaslad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbCameras);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBaslad;
        private System.Windows.Forms.Button btnSekilCek;
    }
}

