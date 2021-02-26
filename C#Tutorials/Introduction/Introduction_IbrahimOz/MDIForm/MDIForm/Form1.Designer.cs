namespace MDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personallarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikcilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yonetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personallarToolStripMenuItem,
            this.musterilerToolStripMenuItem,
            this.tedarikcilerToolStripMenuItem,
            this.yonetimToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personallarToolStripMenuItem
            // 
            this.personallarToolStripMenuItem.Name = "personallarToolStripMenuItem";
            this.personallarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.personallarToolStripMenuItem.Text = "Personallar";
            this.personallarToolStripMenuItem.Click += new System.EventHandler(this.personallarToolStripMenuItem_Click);
            // 
            // musterilerToolStripMenuItem
            // 
            this.musterilerToolStripMenuItem.Name = "musterilerToolStripMenuItem";
            this.musterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.musterilerToolStripMenuItem.Text = "Musteriler";
            this.musterilerToolStripMenuItem.Click += new System.EventHandler(this.musterilerToolStripMenuItem_Click);
            // 
            // tedarikcilerToolStripMenuItem
            // 
            this.tedarikcilerToolStripMenuItem.Name = "tedarikcilerToolStripMenuItem";
            this.tedarikcilerToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tedarikcilerToolStripMenuItem.Text = "Tedarikciler";
            // 
            // yonetimToolStripMenuItem
            // 
            this.yonetimToolStripMenuItem.Name = "yonetimToolStripMenuItem";
            this.yonetimToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.yonetimToolStripMenuItem.Text = "Yonetim";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 381);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personallarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikcilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yonetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
    }
}

