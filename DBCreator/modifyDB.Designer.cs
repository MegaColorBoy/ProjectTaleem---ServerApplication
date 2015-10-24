namespace DBCreator
{
    partial class ModifyDB
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
            this.delDBBtn = new MetroFramework.Controls.MetroTile();
            this.dbListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delColumnBtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.columnListBox = new System.Windows.Forms.ListBox();
            this.tableListBox = new System.Windows.Forms.ListBox();
            this.dbListBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.addColumnBtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.columnText = new MetroFramework.Controls.MetroTextBox();
            this.tableListBox2 = new System.Windows.Forms.ListBox();
            this.typeListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tableListBox3 = new System.Windows.Forms.ListBox();
            this.dbListBox3 = new System.Windows.Forms.ListBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tableText = new MetroFramework.Controls.MetroTextBox();
            this.delTableBtn = new MetroFramework.Controls.MetroTile();
            this.addTableBtn = new MetroFramework.Controls.MetroTile();
            this.addDBBtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.dbText = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delDBBtn
            // 
            this.delDBBtn.ActiveControl = null;
            this.delDBBtn.Location = new System.Drawing.Point(177, 94);
            this.delDBBtn.Name = "delDBBtn";
            this.delDBBtn.Size = new System.Drawing.Size(130, 33);
            this.delDBBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.delDBBtn.TabIndex = 1;
            this.delDBBtn.Text = "Delete Database";
            this.delDBBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delDBBtn.UseSelectable = true;
            this.delDBBtn.Click += new System.EventHandler(this.delDBBtn_Click);
            // 
            // dbListBox
            // 
            this.dbListBox.FormattingEnabled = true;
            this.dbListBox.Location = new System.Drawing.Point(6, 19);
            this.dbListBox.Name = "dbListBox";
            this.dbListBox.Size = new System.Drawing.Size(165, 108);
            this.dbListBox.TabIndex = 0;
            this.dbListBox.SelectedIndexChanged += new System.EventHandler(this.dbListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delColumnBtn);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.columnListBox);
            this.groupBox2.Controls.Add(this.tableListBox);
            this.groupBox2.Controls.Add(this.dbListBox2);
            this.groupBox2.Location = new System.Drawing.Point(344, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Column";
            // 
            // delColumnBtn
            // 
            this.delColumnBtn.ActiveControl = null;
            this.delColumnBtn.Location = new System.Drawing.Point(6, 231);
            this.delColumnBtn.Name = "delColumnBtn";
            this.delColumnBtn.Size = new System.Drawing.Size(134, 50);
            this.delColumnBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.delColumnBtn.TabIndex = 6;
            this.delColumnBtn.Text = "Delete Column";
            this.delColumnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delColumnBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.delColumnBtn.UseSelectable = true;
            this.delColumnBtn.Click += new System.EventHandler(this.delColumnBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 162);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Select column:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Select table:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Select database:";
            // 
            // columnListBox
            // 
            this.columnListBox.FormattingEnabled = true;
            this.columnListBox.Location = new System.Drawing.Point(6, 184);
            this.columnListBox.Name = "columnListBox";
            this.columnListBox.Size = new System.Drawing.Size(134, 43);
            this.columnListBox.TabIndex = 2;
            // 
            // tableListBox
            // 
            this.tableListBox.FormattingEnabled = true;
            this.tableListBox.Location = new System.Drawing.Point(5, 106);
            this.tableListBox.Name = "tableListBox";
            this.tableListBox.Size = new System.Drawing.Size(135, 56);
            this.tableListBox.TabIndex = 1;
            this.tableListBox.SelectedIndexChanged += new System.EventHandler(this.tableListBox_SelectedIndexChanged);
            // 
            // dbListBox2
            // 
            this.dbListBox2.FormattingEnabled = true;
            this.dbListBox2.Location = new System.Drawing.Point(6, 38);
            this.dbListBox2.Name = "dbListBox2";
            this.dbListBox2.Size = new System.Drawing.Size(134, 43);
            this.dbListBox2.TabIndex = 0;
            this.dbListBox2.SelectedIndexChanged += new System.EventHandler(this.dbListBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.addColumnBtn);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.columnText);
            this.groupBox3.Controls.Add(this.tableListBox2);
            this.groupBox3.Controls.Add(this.typeListBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Column";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(117, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(178, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Select table to insert column:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Select data type:";
            // 
            // addColumnBtn
            // 
            this.addColumnBtn.ActiveControl = null;
            this.addColumnBtn.Location = new System.Drawing.Point(117, 100);
            this.addColumnBtn.Name = "addColumnBtn";
            this.addColumnBtn.Size = new System.Drawing.Size(176, 41);
            this.addColumnBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.addColumnBtn.TabIndex = 4;
            this.addColumnBtn.Text = "Add Column";
            this.addColumnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addColumnBtn.UseSelectable = true;
            this.addColumnBtn.Click += new System.EventHandler(this.addColumnBtn_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 97);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Column name:";
            // 
            // columnText
            // 
            this.columnText.Lines = new string[0];
            this.columnText.Location = new System.Drawing.Point(10, 118);
            this.columnText.MaxLength = 32767;
            this.columnText.Name = "columnText";
            this.columnText.PasswordChar = '\0';
            this.columnText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.columnText.SelectedText = "";
            this.columnText.Size = new System.Drawing.Size(92, 23);
            this.columnText.TabIndex = 2;
            this.columnText.UseSelectable = true;
            // 
            // tableListBox2
            // 
            this.tableListBox2.FormattingEnabled = true;
            this.tableListBox2.Location = new System.Drawing.Point(117, 38);
            this.tableListBox2.Name = "tableListBox2";
            this.tableListBox2.Size = new System.Drawing.Size(176, 56);
            this.tableListBox2.TabIndex = 1;
            // 
            // typeListBox
            // 
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.Location = new System.Drawing.Point(6, 38);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(104, 56);
            this.typeListBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel10);
            this.groupBox4.Controls.Add(this.addDBBtn);
            this.groupBox4.Controls.Add(this.dbText);
            this.groupBox4.Controls.Add(this.delDBBtn);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.dbListBox);
            this.groupBox4.Location = new System.Drawing.Point(23, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 288);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add/Delete Database/Add Column";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addTableBtn);
            this.groupBox1.Controls.Add(this.delTableBtn);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.tableText);
            this.groupBox1.Controls.Add(this.tableListBox3);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.dbListBox3);
            this.groupBox1.Location = new System.Drawing.Point(498, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Delete Table";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(147, 70);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(79, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Select table:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 70);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Select database:";
            // 
            // tableListBox3
            // 
            this.tableListBox3.FormattingEnabled = true;
            this.tableListBox3.Location = new System.Drawing.Point(150, 92);
            this.tableListBox3.Name = "tableListBox3";
            this.tableListBox3.Size = new System.Drawing.Size(135, 160);
            this.tableListBox3.TabIndex = 8;
            // 
            // dbListBox3
            // 
            this.dbListBox3.FormattingEnabled = true;
            this.dbListBox3.Location = new System.Drawing.Point(10, 92);
            this.dbListBox3.Name = "dbListBox3";
            this.dbListBox3.Size = new System.Drawing.Size(134, 160);
            this.dbListBox3.TabIndex = 7;
            this.dbListBox3.SelectedIndexChanged += new System.EventHandler(this.dbListBox3_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 22);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(79, 19);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Table name:";
            // 
            // tableText
            // 
            this.tableText.Lines = new string[0];
            this.tableText.Location = new System.Drawing.Point(10, 44);
            this.tableText.MaxLength = 32767;
            this.tableText.Name = "tableText";
            this.tableText.PasswordChar = '\0';
            this.tableText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableText.SelectedText = "";
            this.tableText.Size = new System.Drawing.Size(275, 23);
            this.tableText.TabIndex = 7;
            this.tableText.UseSelectable = true;
            // 
            // delTableBtn
            // 
            this.delTableBtn.ActiveControl = null;
            this.delTableBtn.Location = new System.Drawing.Point(150, 258);
            this.delTableBtn.Name = "delTableBtn";
            this.delTableBtn.Size = new System.Drawing.Size(135, 23);
            this.delTableBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.delTableBtn.TabIndex = 11;
            this.delTableBtn.Text = "Delete Table";
            this.delTableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delTableBtn.UseSelectable = true;
            this.delTableBtn.Click += new System.EventHandler(this.delTableBtn_Click);
            // 
            // addTableBtn
            // 
            this.addTableBtn.ActiveControl = null;
            this.addTableBtn.Location = new System.Drawing.Point(10, 258);
            this.addTableBtn.Name = "addTableBtn";
            this.addTableBtn.Size = new System.Drawing.Size(134, 23);
            this.addTableBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.addTableBtn.TabIndex = 12;
            this.addTableBtn.Text = "Add Table";
            this.addTableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTableBtn.UseSelectable = true;
            this.addTableBtn.Click += new System.EventHandler(this.addTableBtn_Click);
            // 
            // addDBBtn
            // 
            this.addDBBtn.ActiveControl = null;
            this.addDBBtn.Location = new System.Drawing.Point(177, 67);
            this.addDBBtn.Name = "addDBBtn";
            this.addDBBtn.Size = new System.Drawing.Size(130, 21);
            this.addDBBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.addDBBtn.TabIndex = 3;
            this.addDBBtn.Text = "Add Database";
            this.addDBBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDBBtn.UseSelectable = true;
            this.addDBBtn.Click += new System.EventHandler(this.addDBBtn_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(174, 17);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(103, 19);
            this.metroLabel10.TabIndex = 8;
            this.metroLabel10.Text = "Database name:";
            // 
            // dbText
            // 
            this.dbText.Lines = new string[0];
            this.dbText.Location = new System.Drawing.Point(177, 38);
            this.dbText.MaxLength = 32767;
            this.dbText.Name = "dbText";
            this.dbText.PasswordChar = '\0';
            this.dbText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dbText.SelectedText = "";
            this.dbText.Size = new System.Drawing.Size(130, 23);
            this.dbText.TabIndex = 7;
            this.dbText.UseSelectable = true;
            // 
            // ModifyDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "ModifyDB";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Modify Database";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile delDBBtn;
        private System.Windows.Forms.ListBox dbListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox dbListBox2;
        private System.Windows.Forms.ListBox columnListBox;
        private System.Windows.Forms.ListBox tableListBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile delColumnBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox typeListBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox columnText;
        private System.Windows.Forms.ListBox tableListBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTile addColumnBtn;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile addTableBtn;
        private MetroFramework.Controls.MetroTile delTableBtn;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tableText;
        private System.Windows.Forms.ListBox tableListBox3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ListBox dbListBox3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile addDBBtn;
        private MetroFramework.Controls.MetroTextBox dbText;
    }
}