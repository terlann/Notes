
namespace Abstract
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
            this.btnMusiqiAletleri = new System.Windows.Forms.Button();
            this.btnGitara = new System.Windows.Forms.Button();
            this.btnKeman = new System.Windows.Forms.Button();
            this.btnTruba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusiqiAletleri
            // 
            this.btnMusiqiAletleri.Location = new System.Drawing.Point(131, 79);
            this.btnMusiqiAletleri.Name = "btnMusiqiAletleri";
            this.btnMusiqiAletleri.Size = new System.Drawing.Size(105, 33);
            this.btnMusiqiAletleri.TabIndex = 0;
            this.btnMusiqiAletleri.Text = "Musiqi Aletleri";
            this.btnMusiqiAletleri.UseVisualStyleBackColor = true;
            this.btnMusiqiAletleri.Click += new System.EventHandler(this.btnMusiqiAletleri_Click);
            // 
            // btnGitara
            // 
            this.btnGitara.Location = new System.Drawing.Point(273, 79);
            this.btnGitara.Name = "btnGitara";
            this.btnGitara.Size = new System.Drawing.Size(105, 33);
            this.btnGitara.TabIndex = 1;
            this.btnGitara.Text = "Gitara";
            this.btnGitara.UseVisualStyleBackColor = true;
            this.btnGitara.Click += new System.EventHandler(this.btnGitara_Click);
            // 
            // btnKeman
            // 
            this.btnKeman.Location = new System.Drawing.Point(415, 79);
            this.btnKeman.Name = "btnKeman";
            this.btnKeman.Size = new System.Drawing.Size(105, 33);
            this.btnKeman.TabIndex = 2;
            this.btnKeman.Text = "Keman";
            this.btnKeman.UseVisualStyleBackColor = true;
            this.btnKeman.Click += new System.EventHandler(this.btnKeman_Click);
            // 
            // btnTruba
            // 
            this.btnTruba.Location = new System.Drawing.Point(559, 79);
            this.btnTruba.Name = "btnTruba";
            this.btnTruba.Size = new System.Drawing.Size(105, 33);
            this.btnTruba.TabIndex = 3;
            this.btnTruba.Text = "Truba";
            this.btnTruba.UseVisualStyleBackColor = true;
            this.btnTruba.Click += new System.EventHandler(this.btnTruba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTruba);
            this.Controls.Add(this.btnKeman);
            this.Controls.Add(this.btnGitara);
            this.Controls.Add(this.btnMusiqiAletleri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusiqiAletleri;
        private System.Windows.Forms.Button btnGitara;
        private System.Windows.Forms.Button btnKeman;
        private System.Windows.Forms.Button btnTruba;
    }
}

