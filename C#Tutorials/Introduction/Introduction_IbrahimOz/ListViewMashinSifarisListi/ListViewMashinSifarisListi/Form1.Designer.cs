namespace ListViewMashinSifarisListi
{
    partial class btn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn));
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbYanacaqNovu = new System.Windows.Forms.ComboBox();
            this.dtYear = new System.Windows.Forms.DateTimePicker();
            this.listViewSaved = new System.Windows.Forms.ListView();
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YanacaqNovu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.UpdateSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Mercedes",
            "BMW",
            "KIA"});
            this.cmbMarka.Location = new System.Drawing.Point(12, 43);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(139, 43);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 0;
            // 
            // cmbYanacaqNovu
            // 
            this.cmbYanacaqNovu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYanacaqNovu.FormattingEnabled = true;
            this.cmbYanacaqNovu.Items.AddRange(new object[] {
            "Benzin",
            "Dizel"});
            this.cmbYanacaqNovu.Location = new System.Drawing.Point(266, 43);
            this.cmbYanacaqNovu.Name = "cmbYanacaqNovu";
            this.cmbYanacaqNovu.Size = new System.Drawing.Size(121, 21);
            this.cmbYanacaqNovu.TabIndex = 0;
            // 
            // dtYear
            // 
            this.dtYear.CustomFormat = "yyyy";
            this.dtYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtYear.Location = new System.Drawing.Point(139, 106);
            this.dtYear.Name = "dtYear";
            this.dtYear.Size = new System.Drawing.Size(121, 20);
            this.dtYear.TabIndex = 1;
            // 
            // listViewSaved
            // 
            this.listViewSaved.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listViewSaved.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marka,
            this.Model,
            this.YanacaqNovu,
            this.reng,
            this.İl});
            this.listViewSaved.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewSaved.FullRowSelect = true;
            this.listViewSaved.GridLines = true;
            this.listViewSaved.HideSelection = false;
            this.listViewSaved.Location = new System.Drawing.Point(13, 143);
            this.listViewSaved.Name = "listViewSaved";
            this.listViewSaved.Size = new System.Drawing.Size(775, 295);
            this.listViewSaved.TabIndex = 2;
            this.listViewSaved.UseCompatibleStateImageBehavior = false;
            this.listViewSaved.View = System.Windows.Forms.View.Details;
            this.listViewSaved.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewSaved_KeyDown);
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 211;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 206;
            // 
            // YanacaqNovu
            // 
            this.YanacaqNovu.Text = "YanacağNövü";
            this.YanacaqNovu.Width = 117;
            // 
            // reng
            // 
            this.reng.Text = "Rəng";
            this.reng.Width = 159;
            // 
            // İl
            // 
            this.İl.Text = "İl";
            this.İl.Width = 104;
            // 
            // btnColor
            // 
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.Location = new System.Drawing.Point(13, 104);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(120, 21);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(266, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 55);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(395, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 56);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(267, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(847, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(928, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(973, 143);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1013, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(518, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 54);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateSave
            // 
            this.UpdateSave.Location = new System.Drawing.Point(652, 72);
            this.UpdateSave.Name = "UpdateSave";
            this.UpdateSave.Size = new System.Drawing.Size(56, 53);
            this.UpdateSave.TabIndex = 15;
            this.UpdateSave.Text = "UpdateSave";
            this.UpdateSave.UseVisualStyleBackColor = true;
            this.UpdateSave.Click += new System.EventHandler(this.UpdateSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.UpdateSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.listViewSaved);
            this.Controls.Add(this.dtYear);
            this.Controls.Add(this.cmbYanacaqNovu);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMarka);
            this.Name = "btn";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbYanacaqNovu;
        private System.Windows.Forms.DateTimePicker dtYear;
        private System.Windows.Forms.ListView listViewSaved;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader YanacaqNovu;
        private System.Windows.Forms.ColumnHeader reng;
        private System.Windows.Forms.ColumnHeader İl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button UpdateSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

