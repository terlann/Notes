
namespace Ders6_UstDuzeyKatmansalMimari
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
            this.urunlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikcilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunlerToolStripMenuItem,
            this.kategorilerToolStripMenuItem,
            this.tedarikcilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // urunlerToolStripMenuItem
            // 
            this.urunlerToolStripMenuItem.Name = "urunlerToolStripMenuItem";
            this.urunlerToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.urunlerToolStripMenuItem.Text = "Urunler";
            this.urunlerToolStripMenuItem.Click += new System.EventHandler(this.urunlerToolStripMenuItem_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // tedarikcilerToolStripMenuItem
            // 
            this.tedarikcilerToolStripMenuItem.Name = "tedarikcilerToolStripMenuItem";
            this.tedarikcilerToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.tedarikcilerToolStripMenuItem.Text = "Tedarikciler";
            this.tedarikcilerToolStripMenuItem.Click += new System.EventHandler(this.tedarikcilerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 487);
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
        private System.Windows.Forms.ToolStripMenuItem urunlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikcilerToolStripMenuItem;
    }
}

