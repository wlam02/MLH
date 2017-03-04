namespace MHL
{
    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;        
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
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.txtAddFName = new MetroFramework.Controls.MetroTextBox();
            this.pWDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pWDBDataSet = new MHL.PWDBDataSet();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAddLName = new MetroFramework.Controls.MetroTextBox();
            this.txtAddEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtAddPW = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ComboTeacherLN = new MetroFramework.Controls.MetroComboBox();
            this.RadioBtnIsStudent = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBtnIsTeacher = new MetroFramework.Controls.MetroRadioButton();
            this.lblTeacherLastName = new MetroFramework.Controls.MetroLabel();
            this.chkBoxAdmin = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pWDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(74, 71);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(121, 19);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Student First Name";
            this.lblFirstName.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtAddFName
            // 
            // 
            // 
            // 
            this.txtAddFName.CustomButton.Image = null;
            this.txtAddFName.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtAddFName.CustomButton.Name = "";
            this.txtAddFName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddFName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddFName.CustomButton.TabIndex = 1;
            this.txtAddFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddFName.CustomButton.UseSelectable = true;
            this.txtAddFName.CustomButton.Visible = false;
            this.txtAddFName.Lines = new string[] {
        "Enter First Name"};
            this.txtAddFName.Location = new System.Drawing.Point(214, 67);
            this.txtAddFName.MaxLength = 32767;
            this.txtAddFName.Name = "txtAddFName";
            this.txtAddFName.PasswordChar = '\0';
            this.txtAddFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddFName.SelectedText = "";
            this.txtAddFName.SelectionLength = 0;
            this.txtAddFName.SelectionStart = 0;
            this.txtAddFName.ShortcutsEnabled = true;
            this.txtAddFName.Size = new System.Drawing.Size(209, 23);
            this.txtAddFName.TabIndex = 1;
            this.txtAddFName.Text = "Enter First Name";
            this.txtAddFName.UseSelectable = true;
            this.txtAddFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddFName.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // pWDBBindingSource
            // 
            this.pWDBBindingSource.DataMember = "PWDB";
            this.pWDBBindingSource.DataSource = this.pWDBDataSet;
            // 
            // pWDBDataSet
            // 
            this.pWDBDataSet.DataSetName = "PWDBDataSet";
            this.pWDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(76, 116);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 19);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Student Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(106, 161);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Student Email";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(132, 202);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Password";
            // 
            // txtAddLName
            // 
            // 
            // 
            // 
            this.txtAddLName.CustomButton.Image = null;
            this.txtAddLName.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtAddLName.CustomButton.Name = "";
            this.txtAddLName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddLName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddLName.CustomButton.TabIndex = 1;
            this.txtAddLName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddLName.CustomButton.UseSelectable = true;
            this.txtAddLName.CustomButton.Visible = false;
            this.txtAddLName.Lines = new string[] {
        "Enter Last Name"};
            this.txtAddLName.Location = new System.Drawing.Point(214, 112);
            this.txtAddLName.MaxLength = 32767;
            this.txtAddLName.Name = "txtAddLName";
            this.txtAddLName.PasswordChar = '\0';
            this.txtAddLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddLName.SelectedText = "";
            this.txtAddLName.SelectionLength = 0;
            this.txtAddLName.SelectionStart = 0;
            this.txtAddLName.ShortcutsEnabled = true;
            this.txtAddLName.Size = new System.Drawing.Size(209, 23);
            this.txtAddLName.TabIndex = 7;
            this.txtAddLName.Text = "Enter Last Name";
            this.txtAddLName.UseSelectable = true;
            this.txtAddLName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddLName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddLName.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // txtAddEmail
            // 
            // 
            // 
            // 
            this.txtAddEmail.CustomButton.Image = null;
            this.txtAddEmail.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtAddEmail.CustomButton.Name = "";
            this.txtAddEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddEmail.CustomButton.TabIndex = 1;
            this.txtAddEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddEmail.CustomButton.UseSelectable = true;
            this.txtAddEmail.CustomButton.Visible = false;
            this.txtAddEmail.Lines = new string[] {
        "Enter Email / Login"};
            this.txtAddEmail.Location = new System.Drawing.Point(214, 157);
            this.txtAddEmail.MaxLength = 32767;
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.PasswordChar = '\0';
            this.txtAddEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddEmail.SelectedText = "";
            this.txtAddEmail.SelectionLength = 0;
            this.txtAddEmail.SelectionStart = 0;
            this.txtAddEmail.ShortcutsEnabled = true;
            this.txtAddEmail.Size = new System.Drawing.Size(209, 23);
            this.txtAddEmail.TabIndex = 8;
            this.txtAddEmail.Text = "Enter Email / Login";
            this.txtAddEmail.UseSelectable = true;
            this.txtAddEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddEmail.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // txtAddPW
            // 
            // 
            // 
            // 
            this.txtAddPW.CustomButton.Image = null;
            this.txtAddPW.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtAddPW.CustomButton.Name = "";
            this.txtAddPW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddPW.CustomButton.TabIndex = 1;
            this.txtAddPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddPW.CustomButton.UseSelectable = true;
            this.txtAddPW.CustomButton.Visible = false;
            this.txtAddPW.Lines = new string[] {
        "Enter Password"};
            this.txtAddPW.Location = new System.Drawing.Point(214, 198);
            this.txtAddPW.MaxLength = 32767;
            this.txtAddPW.Name = "txtAddPW";
            this.txtAddPW.PasswordChar = '\0';
            this.txtAddPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddPW.SelectedText = "";
            this.txtAddPW.SelectionLength = 0;
            this.txtAddPW.SelectionStart = 0;
            this.txtAddPW.ShortcutsEnabled = true;
            this.txtAddPW.Size = new System.Drawing.Size(209, 23);
            this.txtAddPW.TabIndex = 11;
            this.txtAddPW.Text = "Enter Password";
            this.txtAddPW.UseSelectable = true;
            this.txtAddPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddPW.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(240, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.Location = new System.Drawing.Point(132, 309);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Clear";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.pWDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // ComboTeacherLN
            // 
            this.ComboTeacherLN.FormattingEnabled = true;
            this.ComboTeacherLN.ItemHeight = 23;
            this.ComboTeacherLN.Location = new System.Drawing.Point(214, 240);
            this.ComboTeacherLN.Name = "ComboTeacherLN";
            this.ComboTeacherLN.Size = new System.Drawing.Size(209, 29);
            this.ComboTeacherLN.TabIndex = 14;
            this.ComboTeacherLN.UseSelectable = true;
            this.ComboTeacherLN.SelectedIndexChanged += new System.EventHandler(this.ComboTeacherLN_SelectedIndexChanged);
            // 
            // RadioBtnIsStudent
            // 
            this.RadioBtnIsStudent.AutoSize = true;
            this.RadioBtnIsStudent.Checked = true;
            this.RadioBtnIsStudent.Location = new System.Drawing.Point(161, 15);
            this.RadioBtnIsStudent.Name = "RadioBtnIsStudent";
            this.RadioBtnIsStudent.Size = new System.Drawing.Size(89, 15);
            this.RadioBtnIsStudent.TabIndex = 22;
            this.RadioBtnIsStudent.TabStop = true;
            this.RadioBtnIsStudent.Text = "Add Student";
            this.RadioBtnIsStudent.UseSelectable = true;
            this.RadioBtnIsStudent.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // RadioBtnIsTeacher
            // 
            this.RadioBtnIsTeacher.AutoSize = true;
            this.RadioBtnIsTeacher.Location = new System.Drawing.Point(161, 36);
            this.RadioBtnIsTeacher.Name = "RadioBtnIsTeacher";
            this.RadioBtnIsTeacher.Size = new System.Drawing.Size(89, 15);
            this.RadioBtnIsTeacher.TabIndex = 23;
            this.RadioBtnIsTeacher.Text = "Add Teacher";
            this.RadioBtnIsTeacher.UseSelectable = true;
            this.RadioBtnIsTeacher.CheckedChanged += new System.EventHandler(this.RadioBtnIsAdmin_CheckedChanged);
            // 
            // lblTeacherLastName
            // 
            this.lblTeacherLastName.AutoSize = true;
            this.lblTeacherLastName.Location = new System.Drawing.Point(76, 250);
            this.lblTeacherLastName.Name = "lblTeacherLastName";
            this.lblTeacherLastName.Size = new System.Drawing.Size(119, 19);
            this.lblTeacherLastName.TabIndex = 5;
            this.lblTeacherLastName.Text = "Teacher Last Name";
            // 
            // chkBoxAdmin
            // 
            this.chkBoxAdmin.AutoSize = true;
            this.chkBoxAdmin.Location = new System.Drawing.Point(269, 36);
            this.chkBoxAdmin.Name = "chkBoxAdmin";
            this.chkBoxAdmin.Size = new System.Drawing.Size(91, 15);
            this.chkBoxAdmin.TabIndex = 24;
            this.chkBoxAdmin.Text = "Make Admin";
            this.chkBoxAdmin.UseSelectable = true;
            this.chkBoxAdmin.Visible = false;
            this.chkBoxAdmin.CheckedChanged += new System.EventHandler(this.chkBoxAdmin_CheckedChanged);
            // 
            // AddUserForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 382);
            this.Controls.Add(this.chkBoxAdmin);
            this.Controls.Add(this.RadioBtnIsTeacher);
            this.Controls.Add(this.RadioBtnIsStudent);
            this.Controls.Add(this.ComboTeacherLN);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddPW);
            this.Controls.Add(this.txtAddEmail);
            this.Controls.Add(this.txtAddLName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblTeacherLastName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtAddFName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "AddUserForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Add User";
            this.TransparencyKey = System.Drawing.Color.LightSkyBlue;
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pWDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblFirstName;
        private MetroFramework.Controls.MetroTextBox txtAddFName;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtAddLName;
        private MetroFramework.Controls.MetroTextBox txtAddEmail;
        private MetroFramework.Controls.MetroTextBox txtAddPW;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private PWDBDataSet pWDBDataSet;
        private System.Windows.Forms.BindingSource pWDBBindingSource;
        private MetroFramework.Controls.MetroComboBox ComboTeacherLN;
        private MetroFramework.Controls.MetroRadioButton RadioBtnIsStudent;
        private MetroFramework.Controls.MetroRadioButton RadioBtnIsTeacher;
        private MetroFramework.Controls.MetroLabel lblTeacherLastName;
        private MetroFramework.Controls.MetroCheckBox chkBoxAdmin;
    }
}