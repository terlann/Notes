namespace Otabus_Otomosyonu
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
            this.components = new System.ComponentModel.Container();
            this.LVAvtobusQeyd = new System.Windows.Forms.ListView();
            this.AvtobusNovu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Haradan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Haraya = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qiymet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MobileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Siraniz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbAvtobusNovu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtVaxt = new System.Windows.Forms.DateTimePicker();
            this.numQiymet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYaddaSaxla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHaraya = new System.Windows.Forms.ComboBox();
            this.cmbHardan = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numQiymet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LVAvtobusQeyd
            // 
            this.LVAvtobusQeyd.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LVAvtobusQeyd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AvtobusNovu,
            this.Haradan,
            this.Haraya,
            this.Tarix,
            this.Qiymet,
            this.FullName,
            this.MobileNumber,
            this.Cinsiyyet,
            this.Siraniz});
            this.LVAvtobusQeyd.ForeColor = System.Drawing.Color.White;
            this.LVAvtobusQeyd.GridLines = true;
            this.LVAvtobusQeyd.HideSelection = false;
            this.LVAvtobusQeyd.Location = new System.Drawing.Point(483, 20);
            this.LVAvtobusQeyd.Name = "LVAvtobusQeyd";
            this.LVAvtobusQeyd.Size = new System.Drawing.Size(867, 426);
            this.LVAvtobusQeyd.TabIndex = 0;
            this.LVAvtobusQeyd.UseCompatibleStateImageBehavior = false;
            this.LVAvtobusQeyd.View = System.Windows.Forms.View.Details;
            // 
            // AvtobusNovu
            // 
            this.AvtobusNovu.Text = "Avtobus Novu";
            this.AvtobusNovu.Width = 92;
            // 
            // Haradan
            // 
            this.Haradan.Text = "Haradan";
            this.Haradan.Width = 83;
            // 
            // Haraya
            // 
            this.Haraya.Text = "Haraya";
            this.Haraya.Width = 84;
            // 
            // Tarix
            // 
            this.Tarix.Text = "Tarix";
            this.Tarix.Width = 73;
            // 
            // Qiymet
            // 
            this.Qiymet.Text = "Qiymet";
            this.Qiymet.Width = 125;
            // 
            // FullName
            // 
            this.FullName.Text = "A.S.A";
            this.FullName.Width = 177;
            // 
            // MobileNumber
            // 
            this.MobileNumber.Text = "MobileNumber";
            this.MobileNumber.Width = 111;
            // 
            // Cinsiyyet
            // 
            this.Cinsiyyet.Text = "Cinsiyyet";
            // 
            // Siraniz
            // 
            this.Siraniz.Text = "Siraniz";
            // 
            // cmbAvtobusNovu
            // 
            this.cmbAvtobusNovu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvtobusNovu.FormattingEnabled = true;
            this.cmbAvtobusNovu.Items.AddRange(new object[] {
            "Hundai",
            "Kia",
            "Qazel",
            "Mercedes"});
            this.cmbAvtobusNovu.Location = new System.Drawing.Point(302, 38);
            this.cmbAvtobusNovu.Name = "cmbAvtobusNovu";
            this.cmbAvtobusNovu.Size = new System.Drawing.Size(121, 21);
            this.cmbAvtobusNovu.Sorted = true;
            this.cmbAvtobusNovu.TabIndex = 1;
            this.cmbAvtobusNovu.SelectedIndexChanged += new System.EventHandler(this.cmbAvtobusNovu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Avtobus Novu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vaxt";
            // 
            // dtVaxt
            // 
            this.dtVaxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVaxt.Location = new System.Drawing.Point(299, 201);
            this.dtVaxt.Name = "dtVaxt";
            this.dtVaxt.Size = new System.Drawing.Size(121, 20);
            this.dtVaxt.TabIndex = 3;
            // 
            // numQiymet
            // 
            this.numQiymet.Location = new System.Drawing.Point(299, 262);
            this.numQiymet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numQiymet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQiymet.Name = "numQiymet";
            this.numQiymet.Size = new System.Drawing.Size(121, 20);
            this.numQiymet.TabIndex = 4;
            this.numQiymet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Qiymet";
            // 
            // btnYaddaSaxla
            // 
            this.btnYaddaSaxla.Location = new System.Drawing.Point(302, 310);
            this.btnYaddaSaxla.Name = "btnYaddaSaxla";
            this.btnYaddaSaxla.Size = new System.Drawing.Size(121, 38);
            this.btnYaddaSaxla.TabIndex = 6;
            this.btnYaddaSaxla.Text = "Sifariş et";
            this.btnYaddaSaxla.UseVisualStyleBackColor = true;
            this.btnYaddaSaxla.Click += new System.EventHandler(this.btnYaddaSaxla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbHaraya);
            this.groupBox1.Controls.Add(this.cmbHardan);
            this.groupBox1.Location = new System.Drawing.Point(299, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Haraya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Haradan";
            // 
            // cmbHaraya
            // 
            this.cmbHaraya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHaraya.FormattingEnabled = true;
            this.cmbHaraya.Items.AddRange(new object[] {
            "Baki",
            "Xacmaz",
            "Quba",
            "Qusar",
            "Samaxi"});
            this.cmbHaraya.Location = new System.Drawing.Point(5, 75);
            this.cmbHaraya.Name = "cmbHaraya";
            this.cmbHaraya.Size = new System.Drawing.Size(121, 21);
            this.cmbHaraya.Sorted = true;
            this.cmbHaraya.TabIndex = 3;
            // 
            // cmbHardan
            // 
            this.cmbHardan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHardan.FormattingEnabled = true;
            this.cmbHardan.Items.AddRange(new object[] {
            "Baki",
            "Xacmaz",
            "Quba",
            "Qusar",
            "Samaxi"});
            this.cmbHardan.Location = new System.Drawing.Point(5, 31);
            this.cmbHardan.Name = "cmbHardan";
            this.cmbHardan.Size = new System.Drawing.Size(121, 21);
            this.cmbHardan.Sorted = true;
            this.cmbHardan.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1362, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYaddaSaxla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numQiymet);
            this.Controls.Add(this.dtVaxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAvtobusNovu);
            this.Controls.Add(this.LVAvtobusQeyd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numQiymet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVAvtobusQeyd;
        private System.Windows.Forms.ComboBox cmbAvtobusNovu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtVaxt;
        private System.Windows.Forms.NumericUpDown numQiymet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYaddaSaxla;
        private System.Windows.Forms.ColumnHeader AvtobusNovu;
        private System.Windows.Forms.ColumnHeader Haradan;
        private System.Windows.Forms.ColumnHeader Haraya;
        private System.Windows.Forms.ColumnHeader Tarix;
        private System.Windows.Forms.ColumnHeader Qiymet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHaraya;
        private System.Windows.Forms.ComboBox cmbHardan;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader MobileNumber;
        private System.Windows.Forms.ColumnHeader Cinsiyyet;
        private System.Windows.Forms.ColumnHeader Siraniz;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

