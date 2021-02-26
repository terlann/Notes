namespace UserControls
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctrlTelefon = new UserControls.InputControl();
            this.ctrlAdress = new UserControls.InputControl();
            this.ctrlSoyadi = new UserControls.InputControl();
            this.ctrlAdi = new UserControls.InputControl();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 193);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(674, 224);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adress";
            this.columnHeader3.Width = 219;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 114;
            // 
            // ctrlTelefon
            // 
            this.ctrlTelefon.Location = new System.Drawing.Point(327, 102);
            this.ctrlTelefon.Name = "ctrlTelefon";
            this.ctrlTelefon.Size = new System.Drawing.Size(232, 73);
            this.ctrlTelefon.TabIndex = 4;
            // 
            // ctrlAdress
            // 
            this.ctrlAdress.Location = new System.Drawing.Point(327, 12);
            this.ctrlAdress.Name = "ctrlAdress";
            this.ctrlAdress.Size = new System.Drawing.Size(232, 73);
            this.ctrlAdress.TabIndex = 3;
            // 
            // ctrlSoyadi
            // 
            this.ctrlSoyadi.Location = new System.Drawing.Point(13, 102);
            this.ctrlSoyadi.Name = "ctrlSoyadi";
            this.ctrlSoyadi.Size = new System.Drawing.Size(232, 73);
            this.ctrlSoyadi.TabIndex = 2;
            // 
            // ctrlAdi
            // 
            this.ctrlAdi.Location = new System.Drawing.Point(13, 12);
            this.ctrlAdi.Name = "ctrlAdi";
            this.ctrlAdi.Size = new System.Drawing.Size(232, 73);
            this.ctrlAdi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 429);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlTelefon);
            this.Controls.Add(this.ctrlAdress);
            this.Controls.Add(this.ctrlSoyadi);
            this.Controls.Add(this.ctrlAdi);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private InputControl ctrlSoyadi;
        private InputControl ctrlAdress;
        private InputControl ctrlTelefon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private InputControl ctrlAdi;
    }
}

