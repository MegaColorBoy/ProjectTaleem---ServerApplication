namespace DBCreator
{
    partial class AEDTeacherProfile
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
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addProfileBtn = new MetroFramework.Controls.MetroTile();
            this.editProfileBtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.passText = new MetroFramework.Controls.MetroTextBox();
            this.userText = new MetroFramework.Controls.MetroTextBox();
            this.classSecText = new MetroFramework.Controls.MetroTextBox();
            this.lnameText = new MetroFramework.Controls.MetroTextBox();
            this.fnameText = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delProfileBtn = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherListBox
            // 
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.Location = new System.Drawing.Point(6, 19);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(220, 95);
            this.teacherListBox.TabIndex = 0;
            this.teacherListBox.SelectedIndexChanged += new System.EventHandler(this.teacherListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teacherListBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a teacher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addProfileBtn);
            this.groupBox2.Controls.Add(this.editProfileBtn);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.passText);
            this.groupBox2.Controls.Add(this.userText);
            this.groupBox2.Controls.Add(this.classSecText);
            this.groupBox2.Controls.Add(this.lnameText);
            this.groupBox2.Controls.Add(this.fnameText);
            this.groupBox2.Location = new System.Drawing.Point(261, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 193);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add/Edit teacher profile";
            // 
            // addProfileBtn
            // 
            this.addProfileBtn.ActiveControl = null;
            this.addProfileBtn.Location = new System.Drawing.Point(10, 165);
            this.addProfileBtn.Name = "addProfileBtn";
            this.addProfileBtn.Size = new System.Drawing.Size(127, 23);
            this.addProfileBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.addProfileBtn.TabIndex = 10;
            this.addProfileBtn.Text = "Add Profile";
            this.addProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addProfileBtn.UseSelectable = true;
            this.addProfileBtn.Click += new System.EventHandler(this.addProfileBtn_Click);
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.ActiveControl = null;
            this.editProfileBtn.Location = new System.Drawing.Point(143, 165);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(159, 23);
            this.editProfileBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.editProfileBtn.TabIndex = 9;
            this.editProfileBtn.Text = "Edit Profile";
            this.editProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editProfileBtn.UseSelectable = true;
            this.editProfileBtn.Click += new System.EventHandler(this.editProfileBtn_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(10, 108);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Username:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Password:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Class Section:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Lastname:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Firstname:";
            // 
            // passText
            // 
            this.passText.Lines = new string[0];
            this.passText.Location = new System.Drawing.Point(99, 135);
            this.passText.MaxLength = 32767;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '\0';
            this.passText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passText.SelectedText = "";
            this.passText.Size = new System.Drawing.Size(203, 23);
            this.passText.TabIndex = 4;
            this.passText.UseSelectable = true;
            // 
            // userText
            // 
            this.userText.Lines = new string[0];
            this.userText.Location = new System.Drawing.Point(99, 106);
            this.userText.MaxLength = 32767;
            this.userText.Name = "userText";
            this.userText.PasswordChar = '\0';
            this.userText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userText.SelectedText = "";
            this.userText.Size = new System.Drawing.Size(203, 23);
            this.userText.TabIndex = 3;
            this.userText.UseSelectable = true;
            // 
            // classSecText
            // 
            this.classSecText.Lines = new string[0];
            this.classSecText.Location = new System.Drawing.Point(99, 77);
            this.classSecText.MaxLength = 32767;
            this.classSecText.Name = "classSecText";
            this.classSecText.PasswordChar = '\0';
            this.classSecText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.classSecText.SelectedText = "";
            this.classSecText.Size = new System.Drawing.Size(203, 23);
            this.classSecText.TabIndex = 2;
            this.classSecText.UseSelectable = true;
            // 
            // lnameText
            // 
            this.lnameText.Lines = new string[0];
            this.lnameText.Location = new System.Drawing.Point(99, 48);
            this.lnameText.MaxLength = 32767;
            this.lnameText.Name = "lnameText";
            this.lnameText.PasswordChar = '\0';
            this.lnameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lnameText.SelectedText = "";
            this.lnameText.Size = new System.Drawing.Size(203, 23);
            this.lnameText.TabIndex = 1;
            this.lnameText.UseSelectable = true;
            // 
            // fnameText
            // 
            this.fnameText.Lines = new string[0];
            this.fnameText.Location = new System.Drawing.Point(99, 19);
            this.fnameText.MaxLength = 32767;
            this.fnameText.Name = "fnameText";
            this.fnameText.PasswordChar = '\0';
            this.fnameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fnameText.SelectedText = "";
            this.fnameText.Size = new System.Drawing.Size(203, 23);
            this.fnameText.TabIndex = 0;
            this.fnameText.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delProfileBtn);
            this.groupBox3.Location = new System.Drawing.Point(23, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 66);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete teacher profile";
            // 
            // delProfileBtn
            // 
            this.delProfileBtn.ActiveControl = null;
            this.delProfileBtn.Location = new System.Drawing.Point(7, 20);
            this.delProfileBtn.Name = "delProfileBtn";
            this.delProfileBtn.Size = new System.Drawing.Size(219, 40);
            this.delProfileBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.delProfileBtn.TabIndex = 0;
            this.delProfileBtn.Text = "Delete Profile";
            this.delProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delProfileBtn.UseSelectable = true;
            this.delProfileBtn.Click += new System.EventHandler(this.delProfileBtn_Click);
            // 
            // AEDTeacherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 277);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AEDTeacherProfile";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Add/Edit/Delete Teacher profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox passText;
        private MetroFramework.Controls.MetroTextBox userText;
        private MetroFramework.Controls.MetroTextBox classSecText;
        private MetroFramework.Controls.MetroTextBox lnameText;
        private MetroFramework.Controls.MetroTextBox fnameText;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile editProfileBtn;
        private MetroFramework.Controls.MetroTile delProfileBtn;
        private MetroFramework.Controls.MetroTile addProfileBtn;
    }
}