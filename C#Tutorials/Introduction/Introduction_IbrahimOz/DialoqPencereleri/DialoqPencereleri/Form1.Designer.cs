namespace DialoqPencereleri
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
            this.btnFontDialoq = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOpenFileDialoq = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveFileDialoq = new System.Windows.Forms.Button();
            this.btnFolderBrowserDialoq = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(505, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "label";
            // 
            // btnFontDialoq
            // 
            this.btnFontDialoq.Location = new System.Drawing.Point(6, 49);
            this.btnFontDialoq.Name = "btnFontDialoq";
            this.btnFontDialoq.Size = new System.Drawing.Size(113, 23);
            this.btnFontDialoq.TabIndex = 1;
            this.btnFontDialoq.Text = "Font Dialoq";
            this.btnFontDialoq.UseVisualStyleBackColor = true;
            this.btnFontDialoq.Click += new System.EventHandler(this.btnFontDialoq_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // btnOpenFileDialoq
            // 
            this.btnOpenFileDialoq.Location = new System.Drawing.Point(135, 48);
            this.btnOpenFileDialoq.Name = "btnOpenFileDialoq";
            this.btnOpenFileDialoq.Size = new System.Drawing.Size(119, 23);
            this.btnOpenFileDialoq.TabIndex = 2;
            this.btnOpenFileDialoq.Text = "File Dialoq";
            this.btnOpenFileDialoq.UseVisualStyleBackColor = true;
            this.btnOpenFileDialoq.Click += new System.EventHandler(this.btnOpenFileDialoq_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\QurbanovTM\\Pictures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btnSaveFileDialoq
            // 
            this.btnSaveFileDialoq.Location = new System.Drawing.Point(271, 48);
            this.btnSaveFileDialoq.Name = "btnSaveFileDialoq";
            this.btnSaveFileDialoq.Size = new System.Drawing.Size(128, 23);
            this.btnSaveFileDialoq.TabIndex = 4;
            this.btnSaveFileDialoq.Text = "Save File Dialoq ";
            this.btnSaveFileDialoq.UseVisualStyleBackColor = true;
            this.btnSaveFileDialoq.Click += new System.EventHandler(this.btnSaveFileDialoq_Click);
            // 
            // btnFolderBrowserDialoq
            // 
            this.btnFolderBrowserDialoq.Location = new System.Drawing.Point(415, 48);
            this.btnFolderBrowserDialoq.Name = "btnFolderBrowserDialoq";
            this.btnFolderBrowserDialoq.Size = new System.Drawing.Size(132, 23);
            this.btnFolderBrowserDialoq.TabIndex = 5;
            this.btnFolderBrowserDialoq.Text = "Folder Browser Dialoq";
            this.btnFolderBrowserDialoq.UseVisualStyleBackColor = true;
            this.btnFolderBrowserDialoq.Click += new System.EventHandler(this.btnFolderBrowserDialoq_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(568, 49);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(141, 23);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Color Dialoq";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFolderBrowserDialoq);
            this.Controls.Add(this.btnSaveFileDialoq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenFileDialoq);
            this.Controls.Add(this.btnFontDialoq);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFontDialoq;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnOpenFileDialoq;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveFileDialoq;
        private System.Windows.Forms.Button btnFolderBrowserDialoq;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

