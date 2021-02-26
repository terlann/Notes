namespace Otabus_Otomosyonu
{
    partial class Form2
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
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.mtxtMobileNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbKisi = new System.Windows.Forms.RadioButton();
            this.rdbQadin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBiletSifarisEt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A.S.A";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(31, 37);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(220, 20);
            this.txtFullname.TabIndex = 1;
            // 
            // mtxtMobileNumber
            // 
            this.mtxtMobileNumber.Location = new System.Drawing.Point(31, 87);
            this.mtxtMobileNumber.Mask = "(+994)00 000-00-00";
            this.mtxtMobileNumber.Name = "mtxtMobileNumber";
            this.mtxtMobileNumber.Size = new System.Drawing.Size(136, 20);
            this.mtxtMobileNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobil Nomre";
            // 
            // rdbKisi
            // 
            this.rdbKisi.AutoSize = true;
            this.rdbKisi.Checked = true;
            this.rdbKisi.Location = new System.Drawing.Point(31, 138);
            this.rdbKisi.Name = "rdbKisi";
            this.rdbKisi.Size = new System.Drawing.Size(41, 17);
            this.rdbKisi.TabIndex = 4;
            this.rdbKisi.TabStop = true;
            this.rdbKisi.Text = "Kisi";
            this.rdbKisi.UseVisualStyleBackColor = true;
            // 
            // rdbQadin
            // 
            this.rdbQadin.AutoSize = true;
            this.rdbQadin.Location = new System.Drawing.Point(82, 138);
            this.rdbQadin.Name = "rdbQadin";
            this.rdbQadin.Size = new System.Drawing.Size(53, 17);
            this.rdbQadin.TabIndex = 5;
            this.rdbQadin.TabStop = true;
            this.rdbQadin.Text = "Qadin";
            this.rdbQadin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdbQadin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbKisi);
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtxtMobileNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qeydiyyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyyet";
            // 
            // btnBiletSifarisEt
            // 
            this.btnBiletSifarisEt.Location = new System.Drawing.Point(94, 223);
            this.btnBiletSifarisEt.Name = "btnBiletSifarisEt";
            this.btnBiletSifarisEt.Size = new System.Drawing.Size(136, 33);
            this.btnBiletSifarisEt.TabIndex = 7;
            this.btnBiletSifarisEt.Text = "Bilet Sifaris Et";
            this.btnBiletSifarisEt.UseVisualStyleBackColor = true;
            this.btnBiletSifarisEt.Click += new System.EventHandler(this.btnBiletSifarisEt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 315);
            this.Controls.Add(this.btnBiletSifarisEt);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBiletSifarisEt;
        public System.Windows.Forms.TextBox txtFullname;
        public System.Windows.Forms.MaskedTextBox mtxtMobileNumber;
        public System.Windows.Forms.RadioButton rdbKisi;
        public System.Windows.Forms.RadioButton rdbQadin;
    }
}