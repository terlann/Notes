namespace ListView_1._18
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
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelephoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.mtxtPin = new System.Windows.Forms.MaskedTextBox();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.mtxtTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cmbPrefix = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Pin,
            this.TelephoneNumber,
            this.BirthDay});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(576, 386);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 103;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 97;
            // 
            // Pin
            // 
            this.Pin.Text = "Pin";
            this.Pin.Width = 86;
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.Text = "TelephoneNumber";
            this.TelephoneNumber.Width = 135;
            // 
            // BirthDay
            // 
            this.BirthDay.Text = "BirthDay";
            this.BirthDay.Width = 153;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(592, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(113, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(592, 80);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(113, 20);
            this.txtLastname.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(592, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtxtPin
            // 
            this.mtxtPin.Location = new System.Drawing.Point(592, 107);
            this.mtxtPin.Mask = "00000000";
            this.mtxtPin.Name = "mtxtPin";
            this.mtxtPin.Size = new System.Drawing.Size(113, 20);
            this.mtxtPin.TabIndex = 2;
            this.mtxtPin.ValidatingType = typeof(int);
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthDay.Location = new System.Drawing.Point(593, 192);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(111, 20);
            this.dtBirthDay.TabIndex = 5;
            // 
            // mtxtTelephoneNumber
            // 
            this.mtxtTelephoneNumber.Location = new System.Drawing.Point(591, 166);
            this.mtxtTelephoneNumber.Mask = "000-00-00";
            this.mtxtTelephoneNumber.Name = "mtxtTelephoneNumber";
            this.mtxtTelephoneNumber.Size = new System.Drawing.Size(113, 20);
            this.mtxtTelephoneNumber.TabIndex = 4;
            // 
            // cmbPrefix
            // 
            this.cmbPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrefix.FormattingEnabled = true;
            this.cmbPrefix.Items.AddRange(new object[] {
            "050",
            "051",
            "055",
            "070",
            "077"});
            this.cmbPrefix.Location = new System.Drawing.Point(593, 137);
            this.cmbPrefix.Name = "cmbPrefix";
            this.cmbPrefix.Size = new System.Drawing.Size(111, 21);
            this.cmbPrefix.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(611, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbPrefix);
            this.Controls.Add(this.dtBirthDay);
            this.Controls.Add(this.mtxtTelephoneNumber);
            this.Controls.Add(this.mtxtPin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Pin;
        private System.Windows.Forms.ColumnHeader TelephoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox mtxtPin;
        private System.Windows.Forms.DateTimePicker dtBirthDay;
        private System.Windows.Forms.MaskedTextBox mtxtTelephoneNumber;
        private System.Windows.Forms.ColumnHeader BirthDay;
        private System.Windows.Forms.ComboBox cmbPrefix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

