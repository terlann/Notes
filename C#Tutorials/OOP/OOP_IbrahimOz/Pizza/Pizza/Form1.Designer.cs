
namespace Pizza
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
            this.cmbOlculer = new System.Windows.Forms.ComboBox();
            this.ListbPizzalar = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbQalin = new System.Windows.Forms.RadioButton();
            this.rdbNazik = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPendir = new System.Windows.Forms.CheckBox();
            this.cbZeytun = new System.Windows.Forms.CheckBox();
            this.cbTonBaligi = new System.Windows.Forms.CheckBox();
            this.cbAncuez = new System.Windows.Forms.CheckBox();
            this.cbMantar = new System.Windows.Forms.CheckBox();
            this.cbSucuk = new System.Windows.Forms.CheckBox();
            this.sbMisir = new System.Windows.Forms.CheckBox();
            this.cbSalam = new System.Windows.Forms.CheckBox();
            this.cbSosis = new System.Windows.Forms.CheckBox();
            this.cbDanaJanbon = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSebeteElaveEt = new System.Windows.Forms.Button();
            this.btnSifarisVer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQiymet = new System.Windows.Forms.TextBox();
            this.btnHesabla = new System.Windows.Forms.Button();
            this.nudEded = new System.Windows.Forms.NumericUpDown();
            this.ListbSebet = new System.Windows.Forms.ListBox();
            this.lblToplamQiymet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEded)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1110, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIZZA SATISHI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbOlculer
            // 
            this.cmbOlculer.FormattingEnabled = true;
            this.cmbOlculer.Location = new System.Drawing.Point(13, 82);
            this.cmbOlculer.Name = "cmbOlculer";
            this.cmbOlculer.Size = new System.Drawing.Size(278, 24);
            this.cmbOlculer.TabIndex = 1;
            // 
            // ListbPizzalar
            // 
            this.ListbPizzalar.FormattingEnabled = true;
            this.ListbPizzalar.ItemHeight = 16;
            this.ListbPizzalar.Location = new System.Drawing.Point(13, 144);
            this.ListbPizzalar.Name = "ListbPizzalar";
            this.ListbPizzalar.Size = new System.Drawing.Size(278, 84);
            this.ListbPizzalar.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbQalin);
            this.groupBox1.Controls.Add(this.rdbNazik);
            this.groupBox1.Location = new System.Drawing.Point(13, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdbQalin
            // 
            this.rdbQalin.AutoSize = true;
            this.rdbQalin.Location = new System.Drawing.Point(128, 21);
            this.rdbQalin.Name = "rdbQalin";
            this.rdbQalin.Size = new System.Drawing.Size(110, 21);
            this.rdbQalin.TabIndex = 0;
            this.rdbQalin.Text = "Qalin Kenarli";
            this.rdbQalin.UseVisualStyleBackColor = true;
            // 
            // rdbNazik
            // 
            this.rdbNazik.AutoSize = true;
            this.rdbNazik.Checked = true;
            this.rdbNazik.Location = new System.Drawing.Point(12, 22);
            this.rdbNazik.Name = "rdbNazik";
            this.rdbNazik.Size = new System.Drawing.Size(112, 21);
            this.rdbNazik.TabIndex = 0;
            this.rdbNazik.TabStop = true;
            this.rdbNazik.Text = "Nazik Kenarli";
            this.rdbNazik.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPendir);
            this.groupBox2.Controls.Add(this.cbZeytun);
            this.groupBox2.Controls.Add(this.cbTonBaligi);
            this.groupBox2.Controls.Add(this.cbAncuez);
            this.groupBox2.Controls.Add(this.cbMantar);
            this.groupBox2.Controls.Add(this.cbSucuk);
            this.groupBox2.Controls.Add(this.sbMisir);
            this.groupBox2.Controls.Add(this.cbSalam);
            this.groupBox2.Controls.Add(this.cbSosis);
            this.groupBox2.Controls.Add(this.cbDanaJanbon);
            this.groupBox2.Location = new System.Drawing.Point(20, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cbPendir
            // 
            this.cbPendir.AutoSize = true;
            this.cbPendir.Location = new System.Drawing.Point(128, 130);
            this.cbPendir.Name = "cbPendir";
            this.cbPendir.Size = new System.Drawing.Size(71, 21);
            this.cbPendir.TabIndex = 0;
            this.cbPendir.Text = "Pendir";
            this.cbPendir.UseVisualStyleBackColor = true;
            // 
            // cbZeytun
            // 
            this.cbZeytun.AutoSize = true;
            this.cbZeytun.Location = new System.Drawing.Point(6, 130);
            this.cbZeytun.Name = "cbZeytun";
            this.cbZeytun.Size = new System.Drawing.Size(74, 21);
            this.cbZeytun.TabIndex = 0;
            this.cbZeytun.Text = "Zeytun";
            this.cbZeytun.UseVisualStyleBackColor = true;
            // 
            // cbTonBaligi
            // 
            this.cbTonBaligi.AutoSize = true;
            this.cbTonBaligi.Location = new System.Drawing.Point(128, 103);
            this.cbTonBaligi.Name = "cbTonBaligi";
            this.cbTonBaligi.Size = new System.Drawing.Size(93, 21);
            this.cbTonBaligi.TabIndex = 0;
            this.cbTonBaligi.Text = "Ton Baligi";
            this.cbTonBaligi.UseVisualStyleBackColor = true;
            // 
            // cbAncuez
            // 
            this.cbAncuez.AutoSize = true;
            this.cbAncuez.Location = new System.Drawing.Point(6, 103);
            this.cbAncuez.Name = "cbAncuez";
            this.cbAncuez.Size = new System.Drawing.Size(77, 21);
            this.cbAncuez.TabIndex = 0;
            this.cbAncuez.Text = "Ancuez";
            this.cbAncuez.UseVisualStyleBackColor = true;
            // 
            // cbMantar
            // 
            this.cbMantar.AutoSize = true;
            this.cbMantar.Location = new System.Drawing.Point(128, 76);
            this.cbMantar.Name = "cbMantar";
            this.cbMantar.Size = new System.Drawing.Size(74, 21);
            this.cbMantar.TabIndex = 0;
            this.cbMantar.Text = "Mantar";
            this.cbMantar.UseVisualStyleBackColor = true;
            // 
            // cbSucuk
            // 
            this.cbSucuk.AutoSize = true;
            this.cbSucuk.Location = new System.Drawing.Point(128, 49);
            this.cbSucuk.Name = "cbSucuk";
            this.cbSucuk.Size = new System.Drawing.Size(69, 21);
            this.cbSucuk.TabIndex = 0;
            this.cbSucuk.Text = "Sucuk";
            this.cbSucuk.UseVisualStyleBackColor = true;
            // 
            // sbMisir
            // 
            this.sbMisir.AutoSize = true;
            this.sbMisir.Location = new System.Drawing.Point(6, 76);
            this.sbMisir.Name = "sbMisir";
            this.sbMisir.Size = new System.Drawing.Size(59, 21);
            this.sbMisir.TabIndex = 0;
            this.sbMisir.Text = "Misir";
            this.sbMisir.UseVisualStyleBackColor = true;
            // 
            // cbSalam
            // 
            this.cbSalam.AutoSize = true;
            this.cbSalam.Location = new System.Drawing.Point(129, 22);
            this.cbSalam.Name = "cbSalam";
            this.cbSalam.Size = new System.Drawing.Size(69, 21);
            this.cbSalam.TabIndex = 0;
            this.cbSalam.Text = "Salam";
            this.cbSalam.UseVisualStyleBackColor = true;
            // 
            // cbSosis
            // 
            this.cbSosis.AutoSize = true;
            this.cbSosis.Location = new System.Drawing.Point(6, 49);
            this.cbSosis.Name = "cbSosis";
            this.cbSosis.Size = new System.Drawing.Size(64, 21);
            this.cbSosis.TabIndex = 0;
            this.cbSosis.Text = "Sosis";
            this.cbSosis.UseVisualStyleBackColor = true;
            // 
            // cbDanaJanbon
            // 
            this.cbDanaJanbon.AutoSize = true;
            this.cbDanaJanbon.Location = new System.Drawing.Point(7, 22);
            this.cbDanaJanbon.Name = "cbDanaJanbon";
            this.cbDanaJanbon.Size = new System.Drawing.Size(118, 21);
            this.cbDanaJanbon.TabIndex = 0;
            this.cbDanaJanbon.Text = "Dana Jambon";
            this.cbDanaJanbon.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSebeteElaveEt);
            this.groupBox3.Controls.Add(this.btnSifarisVer);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtQiymet);
            this.groupBox3.Controls.Add(this.btnHesabla);
            this.groupBox3.Controls.Add(this.nudEded);
            this.groupBox3.Location = new System.Drawing.Point(20, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1059, 78);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnSebeteElaveEt
            // 
            this.btnSebeteElaveEt.Location = new System.Drawing.Point(417, 38);
            this.btnSebeteElaveEt.Name = "btnSebeteElaveEt";
            this.btnSebeteElaveEt.Size = new System.Drawing.Size(148, 28);
            this.btnSebeteElaveEt.TabIndex = 5;
            this.btnSebeteElaveEt.Text = "Sebete Elave Et";
            this.btnSebeteElaveEt.UseVisualStyleBackColor = true;
            this.btnSebeteElaveEt.Click += new System.EventHandler(this.btnSebeteElaveEt_Click);
            // 
            // btnSifarisVer
            // 
            this.btnSifarisVer.Location = new System.Drawing.Point(853, 21);
            this.btnSifarisVer.Name = "btnSifarisVer";
            this.btnSifarisVer.Size = new System.Drawing.Size(180, 44);
            this.btnSifarisVer.TabIndex = 4;
            this.btnSifarisVer.Text = "Sifaris ver";
            this.btnSifarisVer.UseVisualStyleBackColor = true;
            this.btnSifarisVer.Click += new System.EventHandler(this.btnSifarisVer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Qiymet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eded";
            // 
            // txtQiymet
            // 
            this.txtQiymet.Location = new System.Drawing.Point(294, 43);
            this.txtQiymet.Name = "txtQiymet";
            this.txtQiymet.Size = new System.Drawing.Size(84, 22);
            this.txtQiymet.TabIndex = 2;
            // 
            // btnHesabla
            // 
            this.btnHesabla.Location = new System.Drawing.Point(151, 38);
            this.btnHesabla.Name = "btnHesabla";
            this.btnHesabla.Size = new System.Drawing.Size(119, 29);
            this.btnHesabla.TabIndex = 1;
            this.btnHesabla.Text = "Hesabla";
            this.btnHesabla.UseVisualStyleBackColor = true;
            this.btnHesabla.Click += new System.EventHandler(this.btnHesabla_Click);
            // 
            // nudEded
            // 
            this.nudEded.Location = new System.Drawing.Point(10, 41);
            this.nudEded.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEded.Name = "nudEded";
            this.nudEded.Size = new System.Drawing.Size(120, 22);
            this.nudEded.TabIndex = 0;
            this.nudEded.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ListbSebet
            // 
            this.ListbSebet.FormattingEnabled = true;
            this.ListbSebet.HorizontalScrollbar = true;
            this.ListbSebet.ItemHeight = 16;
            this.ListbSebet.Location = new System.Drawing.Point(382, 75);
            this.ListbSebet.Name = "ListbSebet";
            this.ListbSebet.Size = new System.Drawing.Size(697, 388);
            this.ListbSebet.TabIndex = 6;
            // 
            // lblToplamQiymet
            // 
            this.lblToplamQiymet.AutoSize = true;
            this.lblToplamQiymet.Location = new System.Drawing.Point(994, 482);
            this.lblToplamQiymet.Name = "lblToplamQiymet";
            this.lblToplamQiymet.Size = new System.Drawing.Size(24, 17);
            this.lblToplamQiymet.TabIndex = 7;
            this.lblToplamQiymet.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Odenilecey Mebleg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Olculer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pizzalar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 593);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamQiymet);
            this.Controls.Add(this.ListbSebet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListbPizzalar);
            this.Controls.Add(this.cmbOlculer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOlculer;
        private System.Windows.Forms.ListBox ListbPizzalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbQalin;
        private System.Windows.Forms.RadioButton rdbNazik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPendir;
        private System.Windows.Forms.CheckBox cbZeytun;
        private System.Windows.Forms.CheckBox cbTonBaligi;
        private System.Windows.Forms.CheckBox cbAncuez;
        private System.Windows.Forms.CheckBox cbMantar;
        private System.Windows.Forms.CheckBox cbSucuk;
        private System.Windows.Forms.CheckBox sbMisir;
        private System.Windows.Forms.CheckBox cbSalam;
        private System.Windows.Forms.CheckBox cbSosis;
        private System.Windows.Forms.CheckBox cbDanaJanbon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSifarisVer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQiymet;
        private System.Windows.Forms.Button btnHesabla;
        private System.Windows.Forms.NumericUpDown nudEded;
        private System.Windows.Forms.ListBox ListbSebet;
        private System.Windows.Forms.Label lblToplamQiymet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSebeteElaveEt;
    }
}

