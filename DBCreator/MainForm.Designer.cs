namespace DBCreator
{
    partial class MainForm
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
            this.generateDB_Btn = new MetroFramework.Controls.MetroTile();
            this.upldImgBtn = new MetroFramework.Controls.MetroTile();
            this.upldAudioBtn = new MetroFramework.Controls.MetroTile();
            this.dwnldImgBtn = new MetroFramework.Controls.MetroTile();
            this.dwnldAudioBtn = new MetroFramework.Controls.MetroTile();
            this.exitBtn = new MetroFramework.Controls.MetroTile();
            this.importDB_Btn = new MetroFramework.Controls.MetroTile();
            this.exportDB_Btn = new MetroFramework.Controls.MetroTile();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upldSWFBtn = new MetroFramework.Controls.MetroTile();
            this.dwnldSWFBtn = new MetroFramework.Controls.MetroTile();
            this.editProfileBtn = new MetroFramework.Controls.MetroTile();
            this.modifyDBBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // generateDB_Btn
            // 
            this.generateDB_Btn.ActiveControl = null;
            this.generateDB_Btn.Location = new System.Drawing.Point(25, 63);
            this.generateDB_Btn.Name = "generateDB_Btn";
            this.generateDB_Btn.Size = new System.Drawing.Size(175, 23);
            this.generateDB_Btn.Style = MetroFramework.MetroColorStyle.Red;
            this.generateDB_Btn.TabIndex = 0;
            this.generateDB_Btn.Text = "Generate Database";
            this.generateDB_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generateDB_Btn.UseSelectable = true;
            this.generateDB_Btn.Click += new System.EventHandler(this.generateDB_Btn_Click);
            // 
            // upldImgBtn
            // 
            this.upldImgBtn.ActiveControl = null;
            this.upldImgBtn.Location = new System.Drawing.Point(205, 92);
            this.upldImgBtn.Name = "upldImgBtn";
            this.upldImgBtn.Size = new System.Drawing.Size(175, 23);
            this.upldImgBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.upldImgBtn.TabIndex = 1;
            this.upldImgBtn.Text = "Upload phonics images";
            this.upldImgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upldImgBtn.UseSelectable = true;
            this.upldImgBtn.Click += new System.EventHandler(this.upldImgBtn_Click);
            // 
            // upldAudioBtn
            // 
            this.upldAudioBtn.ActiveControl = null;
            this.upldAudioBtn.Location = new System.Drawing.Point(205, 121);
            this.upldAudioBtn.Name = "upldAudioBtn";
            this.upldAudioBtn.Size = new System.Drawing.Size(175, 23);
            this.upldAudioBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.upldAudioBtn.TabIndex = 2;
            this.upldAudioBtn.Text = "Upload phonics audio";
            this.upldAudioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upldAudioBtn.UseSelectable = true;
            this.upldAudioBtn.Click += new System.EventHandler(this.upldAudioBtn_Click);
            // 
            // dwnldImgBtn
            // 
            this.dwnldImgBtn.ActiveControl = null;
            this.dwnldImgBtn.Location = new System.Drawing.Point(25, 150);
            this.dwnldImgBtn.Name = "dwnldImgBtn";
            this.dwnldImgBtn.Size = new System.Drawing.Size(175, 23);
            this.dwnldImgBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.dwnldImgBtn.TabIndex = 3;
            this.dwnldImgBtn.Text = "Download phonics images";
            this.dwnldImgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dwnldImgBtn.UseSelectable = true;
            this.dwnldImgBtn.Click += new System.EventHandler(this.dwnldImgBtn_Click);
            // 
            // dwnldAudioBtn
            // 
            this.dwnldAudioBtn.ActiveControl = null;
            this.dwnldAudioBtn.Location = new System.Drawing.Point(205, 150);
            this.dwnldAudioBtn.Name = "dwnldAudioBtn";
            this.dwnldAudioBtn.Size = new System.Drawing.Size(175, 23);
            this.dwnldAudioBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.dwnldAudioBtn.TabIndex = 4;
            this.dwnldAudioBtn.Text = "Download phonics audio";
            this.dwnldAudioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dwnldAudioBtn.UseSelectable = true;
            this.dwnldAudioBtn.Click += new System.EventHandler(this.dwnldAudioBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ActiveControl = null;
            this.exitBtn.Location = new System.Drawing.Point(205, 208);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(175, 23);
            this.exitBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.UseSelectable = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // importDB_Btn
            // 
            this.importDB_Btn.ActiveControl = null;
            this.importDB_Btn.Location = new System.Drawing.Point(205, 63);
            this.importDB_Btn.Name = "importDB_Btn";
            this.importDB_Btn.Size = new System.Drawing.Size(175, 23);
            this.importDB_Btn.Style = MetroFramework.MetroColorStyle.Red;
            this.importDB_Btn.TabIndex = 6;
            this.importDB_Btn.Text = "Import database";
            this.importDB_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importDB_Btn.UseSelectable = true;
            this.importDB_Btn.Click += new System.EventHandler(this.importDB_Btn_Click);
            // 
            // exportDB_Btn
            // 
            this.exportDB_Btn.ActiveControl = null;
            this.exportDB_Btn.Location = new System.Drawing.Point(25, 92);
            this.exportDB_Btn.Name = "exportDB_Btn";
            this.exportDB_Btn.Size = new System.Drawing.Size(175, 23);
            this.exportDB_Btn.Style = MetroFramework.MetroColorStyle.Red;
            this.exportDB_Btn.TabIndex = 7;
            this.exportDB_Btn.Text = "Export database";
            this.exportDB_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exportDB_Btn.UseSelectable = true;
            this.exportDB_Btn.Click += new System.EventHandler(this.exportDB_Btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(388, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 147);
            this.listBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select a database to export";
            // 
            // upldSWFBtn
            // 
            this.upldSWFBtn.ActiveControl = null;
            this.upldSWFBtn.Location = new System.Drawing.Point(25, 121);
            this.upldSWFBtn.Name = "upldSWFBtn";
            this.upldSWFBtn.Size = new System.Drawing.Size(174, 23);
            this.upldSWFBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.upldSWFBtn.TabIndex = 10;
            this.upldSWFBtn.Text = "Upload Flash Letters";
            this.upldSWFBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upldSWFBtn.UseSelectable = true;
            this.upldSWFBtn.Click += new System.EventHandler(this.upldSWFBtn_Click);
            // 
            // dwnldSWFBtn
            // 
            this.dwnldSWFBtn.ActiveControl = null;
            this.dwnldSWFBtn.Location = new System.Drawing.Point(25, 179);
            this.dwnldSWFBtn.Name = "dwnldSWFBtn";
            this.dwnldSWFBtn.Size = new System.Drawing.Size(174, 23);
            this.dwnldSWFBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.dwnldSWFBtn.TabIndex = 11;
            this.dwnldSWFBtn.Text = "Download Flash Letters";
            this.dwnldSWFBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dwnldSWFBtn.UseSelectable = true;
            this.dwnldSWFBtn.Click += new System.EventHandler(this.dwnldSWFBtn_Click);
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.ActiveControl = null;
            this.editProfileBtn.Location = new System.Drawing.Point(205, 179);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(174, 23);
            this.editProfileBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.editProfileBtn.TabIndex = 12;
            this.editProfileBtn.Text = "Add/Edit/delete teacher profile";
            this.editProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editProfileBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.editProfileBtn.UseSelectable = true;
            this.editProfileBtn.Click += new System.EventHandler(this.editProfileBtn_Click);
            // 
            // modifyDBBtn
            // 
            this.modifyDBBtn.ActiveControl = null;
            this.modifyDBBtn.Location = new System.Drawing.Point(25, 208);
            this.modifyDBBtn.Name = "modifyDBBtn";
            this.modifyDBBtn.Size = new System.Drawing.Size(174, 23);
            this.modifyDBBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.modifyDBBtn.TabIndex = 13;
            this.modifyDBBtn.Text = "Modify database";
            this.modifyDBBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifyDBBtn.UseSelectable = true;
            this.modifyDBBtn.Click += new System.EventHandler(this.modifyDBBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 246);
            this.Controls.Add(this.modifyDBBtn);
            this.Controls.Add(this.editProfileBtn);
            this.Controls.Add(this.dwnldSWFBtn);
            this.Controls.Add(this.upldSWFBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exportDB_Btn);
            this.Controls.Add(this.importDB_Btn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dwnldAudioBtn);
            this.Controls.Add(this.dwnldImgBtn);
            this.Controls.Add(this.upldAudioBtn);
            this.Controls.Add(this.upldImgBtn);
            this.Controls.Add(this.generateDB_Btn);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Database Admin Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile generateDB_Btn;
        private MetroFramework.Controls.MetroTile upldImgBtn;
        private MetroFramework.Controls.MetroTile upldAudioBtn;
        private MetroFramework.Controls.MetroTile dwnldImgBtn;
        private MetroFramework.Controls.MetroTile dwnldAudioBtn;
        private MetroFramework.Controls.MetroTile exitBtn;
        private MetroFramework.Controls.MetroTile importDB_Btn;
        private MetroFramework.Controls.MetroTile exportDB_Btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile upldSWFBtn;
        private MetroFramework.Controls.MetroTile dwnldSWFBtn;
        private MetroFramework.Controls.MetroTile editProfileBtn;
        private MetroFramework.Controls.MetroTile modifyDBBtn;
    }
}

