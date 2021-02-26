namespace CodeFirst_SIDU
{
    partial class FormRapor
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
            this.btnShowRapor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowRapor2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowRapor
            // 
            this.btnShowRapor.Location = new System.Drawing.Point(13, 24);
            this.btnShowRapor.Name = "btnShowRapor";
            this.btnShowRapor.Size = new System.Drawing.Size(174, 53);
            this.btnShowRapor.TabIndex = 0;
            this.btnShowRapor.Text = "Show Rapor";
            this.btnShowRapor.UseVisualStyleBackColor = true;
            this.btnShowRapor.Click += new System.EventHandler(this.btnShowRapor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnShowRapor2
            // 
            this.btnShowRapor2.Location = new System.Drawing.Point(193, 24);
            this.btnShowRapor2.Name = "btnShowRapor2";
            this.btnShowRapor2.Size = new System.Drawing.Size(174, 53);
            this.btnShowRapor2.TabIndex = 0;
            this.btnShowRapor2.Text = "Show Rapor2";
            this.btnShowRapor2.UseVisualStyleBackColor = true;
            this.btnShowRapor2.Click += new System.EventHandler(this.btnShowRapor2_Click);
            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 384);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowRapor2);
            this.Controls.Add(this.btnShowRapor);
            this.Name = "FormRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRapor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowRapor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowRapor2;
    }
}