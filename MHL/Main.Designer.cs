namespace MHL
{
    partial class MLH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MLH));
            this.pWDBDataSet = new MHL.PWDBDataSet();
            this.pWDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPWGenerator = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picPW = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTeacherName = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboName = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPringBarCode = new System.Windows.Forms.Button();
            this.btnGenBarCode = new System.Windows.Forms.Button();
            this.tabAddEdit = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboTeacherLastName = new MetroFramework.Controls.MetroComboBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnFrmClear = new MetroFramework.Controls.MetroButton();
            this.txtEditPW = new MetroFramework.Controls.MetroTextBox();
            this.lblEditPW = new MetroFramework.Controls.MetroLabel();
            this.lblEditTeachLName = new MetroFramework.Controls.MetroLabel();
            this.txteditemail = new MetroFramework.Controls.MetroTextBox();
            this.lbleditemail = new MetroFramework.Controls.MetroLabel();
            this.txteditLastName = new MetroFramework.Controls.MetroTextBox();
            this.lbleditLastName = new MetroFramework.Controls.MetroLabel();
            this.txteditFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblHeader = new MetroFramework.Controls.MetroLabel();
            this.getAllDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllDataTableAdapter = new MHL.PWDBDataSetTableAdapters.GetAllDataTableAdapter();
            this.pWDBTableAdapter1 = new MHL.PWDBDataSetTableAdapters.PWDBTableAdapter();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.picAdd = new MetroFramework.Controls.MetroButton();
            this.lbleditFirstName = new MetroFramework.Controls.MetroLabel();
            this.picDel = new MetroFramework.Controls.MetroButton();
            this.picSave = new MetroFramework.Controls.MetroButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pWDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWDBBindingSource)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPWGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pWDBDataSet
            // 
            this.pWDBDataSet.DataSetName = "PWDBDataSet";
            this.pWDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pWDBBindingSource
            // 
            this.pWDBBindingSource.DataMember = "GetAllData";
            this.pWDBBindingSource.DataSource = this.pWDBDataSet;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPWGenerator);
            this.tabMain.Controls.Add(this.tabAddEdit);
            this.tabMain.Location = new System.Drawing.Point(5, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1101, 360);
            this.tabMain.TabIndex = 0;
            this.tabMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMain_Selected);
            // 
            // tabPWGenerator
            // 
            this.tabPWGenerator.AutoScroll = true;
            this.tabPWGenerator.Controls.Add(this.button1);
            this.tabPWGenerator.Controls.Add(this.picLogin);
            this.tabPWGenerator.Controls.Add(this.picPW);
            this.tabPWGenerator.Controls.Add(this.label4);
            this.tabPWGenerator.Controls.Add(this.comboTeacherName);
            this.tabPWGenerator.Controls.Add(this.label3);
            this.tabPWGenerator.Controls.Add(this.ComboName);
            this.tabPWGenerator.Controls.Add(this.label2);
            this.tabPWGenerator.Controls.Add(this.pictureBox1);
            this.tabPWGenerator.Controls.Add(this.label1);
            this.tabPWGenerator.Controls.Add(this.btnPringBarCode);
            this.tabPWGenerator.Controls.Add(this.btnGenBarCode);
            this.tabPWGenerator.Location = new System.Drawing.Point(4, 22);
            this.tabPWGenerator.Name = "tabPWGenerator";
            this.tabPWGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPWGenerator.Size = new System.Drawing.Size(1093, 334);
            this.tabPWGenerator.TabIndex = 0;
            this.tabPWGenerator.Text = "Generate Login";
            this.tabPWGenerator.UseVisualStyleBackColor = true;
            this.tabPWGenerator.Click += new System.EventHandler(this.tabPWGenerator_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(437, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Switch to Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLogin
            // 
            this.picLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogin.Location = new System.Drawing.Point(42, 162);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(603, 64);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogin.TabIndex = 12;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picPW
            // 
            this.picPW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPW.Location = new System.Drawing.Point(42, 245);
            this.picPW.Name = "picPW";
            this.picPW.Size = new System.Drawing.Size(603, 62);
            this.picPW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPW.TabIndex = 11;
            this.picPW.TabStop = false;
            this.picPW.Click += new System.EventHandler(this.picPW_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teacher Name";
            // 
            // comboTeacherName
            // 
            this.comboTeacherName.DataSource = this.pWDBBindingSource;
            this.comboTeacherName.DisplayMember = "TeacherLastName";
            this.comboTeacherName.FormattingEnabled = true;
            this.comboTeacherName.ItemHeight = 23;
            this.comboTeacherName.Location = new System.Drawing.Point(214, 28);
            this.comboTeacherName.Name = "comboTeacherName";
            this.comboTeacherName.Size = new System.Drawing.Size(250, 29);
            this.comboTeacherName.TabIndex = 9;
            this.comboTeacherName.UseSelectable = true;
            this.comboTeacherName.ValueMember = "TeacherLastName";
            this.comboTeacherName.SelectedIndexChanged += new System.EventHandler(this.comboTeacherName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Name";
            // 
            // ComboName
            // 
            this.ComboName.DataSource = this.pWDBBindingSource;
            this.ComboName.DisplayMember = "LastNAME";
            this.ComboName.FormattingEnabled = true;
            this.ComboName.ItemHeight = 23;
            this.ComboName.Location = new System.Drawing.Point(214, 86);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(253, 29);
            this.ComboName.TabIndex = 7;
            this.ComboName.UseSelectable = true;
            this.ComboName.ValueMember = "LastNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // btnPringBarCode
            // 
            this.btnPringBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPringBarCode.Location = new System.Drawing.Point(285, 127);
            this.btnPringBarCode.Name = "btnPringBarCode";
            this.btnPringBarCode.Size = new System.Drawing.Size(136, 29);
            this.btnPringBarCode.TabIndex = 1;
            this.btnPringBarCode.Text = "Print Barcode";
            this.btnPringBarCode.UseVisualStyleBackColor = true;
            this.btnPringBarCode.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnGenBarCode
            // 
            this.btnGenBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenBarCode.Location = new System.Drawing.Point(133, 127);
            this.btnGenBarCode.Name = "btnGenBarCode";
            this.btnGenBarCode.Size = new System.Drawing.Size(136, 29);
            this.btnGenBarCode.TabIndex = 0;
            this.btnGenBarCode.Text = "Generate Barcode";
            this.btnGenBarCode.UseVisualStyleBackColor = true;
            this.btnGenBarCode.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabAddEdit
            // 
            this.tabAddEdit.Controls.Add(this.picSave);
            this.tabAddEdit.Controls.Add(this.picDel);
            this.tabAddEdit.Controls.Add(this.picAdd);
            this.tabAddEdit.Controls.Add(this.metroButton1);
            this.tabAddEdit.Controls.Add(this.dataGridView);
            this.tabAddEdit.Controls.Add(this.comboTeacherLastName);
            this.tabAddEdit.Controls.Add(this.btnSearch);
            this.tabAddEdit.Controls.Add(this.btnFrmClear);
            this.tabAddEdit.Controls.Add(this.txtEditPW);
            this.tabAddEdit.Controls.Add(this.lblEditPW);
            this.tabAddEdit.Controls.Add(this.lblEditTeachLName);
            this.tabAddEdit.Controls.Add(this.txteditemail);
            this.tabAddEdit.Controls.Add(this.lbleditemail);
            this.tabAddEdit.Controls.Add(this.txteditLastName);
            this.tabAddEdit.Controls.Add(this.lbleditLastName);
            this.tabAddEdit.Controls.Add(this.txteditFirstName);
            this.tabAddEdit.Controls.Add(this.lbleditFirstName);
            this.tabAddEdit.Controls.Add(this.txtSearch);
            this.tabAddEdit.Location = new System.Drawing.Point(4, 22);
            this.tabAddEdit.Name = "tabAddEdit";
            this.tabAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEdit.Size = new System.Drawing.Size(1093, 334);
            this.tabAddEdit.TabIndex = 1;
            this.tabAddEdit.Text = "Admin Control";
            this.tabAddEdit.UseVisualStyleBackColor = true;
            this.tabAddEdit.Click += new System.EventHandler(this.tabAddEdit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.firstNAMEDataGridViewTextBoxColumn,
            this.lastNAMEDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.teacherFirstNameDataGridViewTextBoxColumn,
            this.teacherLastNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.Admin});
            this.dataGridView.DataSource = this.pWDBBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(304, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(783, 308);
            this.dataGridView.TabIndex = 35;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // comboTeacherLastName
            // 
            this.comboTeacherLastName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pWDBBindingSource, "TeacherLastName", true));
            this.comboTeacherLastName.DataSource = this.pWDBBindingSource;
            this.comboTeacherLastName.DisplayMember = "TeacherLastName";
            this.comboTeacherLastName.FormattingEnabled = true;
            this.comboTeacherLastName.ItemHeight = 23;
            this.comboTeacherLastName.Location = new System.Drawing.Point(118, 185);
            this.comboTeacherLastName.Name = "comboTeacherLastName";
            this.comboTeacherLastName.Size = new System.Drawing.Size(180, 29);
            this.comboTeacherLastName.TabIndex = 29;
            this.comboTeacherLastName.UseSelectable = true;
            this.comboTeacherLastName.ValueMember = "TeacherLastName";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 298);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFrmClear
            // 
            this.btnFrmClear.Location = new System.Drawing.Point(118, 257);
            this.btnFrmClear.Name = "btnFrmClear";
            this.btnFrmClear.Size = new System.Drawing.Size(180, 23);
            this.btnFrmClear.TabIndex = 27;
            this.btnFrmClear.Text = "Clear";
            this.btnFrmClear.UseSelectable = true;
            this.btnFrmClear.Click += new System.EventHandler(this.btnFrmClear_Click);
            // 
            // txtEditPW
            // 
            // 
            // 
            // 
            this.txtEditPW.CustomButton.Image = null;
            this.txtEditPW.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtEditPW.CustomButton.Name = "";
            this.txtEditPW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEditPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditPW.CustomButton.TabIndex = 1;
            this.txtEditPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEditPW.CustomButton.UseSelectable = true;
            this.txtEditPW.CustomButton.Visible = false;
            this.txtEditPW.Lines = new string[] {
        "Password"};
            this.txtEditPW.Location = new System.Drawing.Point(93, 220);
            this.txtEditPW.MaxLength = 32767;
            this.txtEditPW.Name = "txtEditPW";
            this.txtEditPW.PasswordChar = '\0';
            this.txtEditPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEditPW.SelectedText = "";
            this.txtEditPW.SelectionLength = 0;
            this.txtEditPW.SelectionStart = 0;
            this.txtEditPW.ShortcutsEnabled = true;
            this.txtEditPW.Size = new System.Drawing.Size(205, 23);
            this.txtEditPW.TabIndex = 26;
            this.txtEditPW.Text = "Password";
            this.txtEditPW.UseSelectable = true;
            this.txtEditPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEditPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEditPW
            // 
            this.lblEditPW.AutoSize = true;
            this.lblEditPW.Location = new System.Drawing.Point(12, 220);
            this.lblEditPW.Name = "lblEditPW";
            this.lblEditPW.Size = new System.Drawing.Size(63, 19);
            this.lblEditPW.TabIndex = 25;
            this.lblEditPW.Text = "Password";
            // 
            // lblEditTeachLName
            // 
            this.lblEditTeachLName.AutoSize = true;
            this.lblEditTeachLName.Location = new System.Drawing.Point(12, 185);
            this.lblEditTeachLName.Name = "lblEditTeachLName";
            this.lblEditTeachLName.Size = new System.Drawing.Size(100, 19);
            this.lblEditTeachLName.TabIndex = 23;
            this.lblEditTeachLName.Text = "Teacher\'s Name";
            // 
            // txteditemail
            // 
            // 
            // 
            // 
            this.txteditemail.CustomButton.Image = null;
            this.txteditemail.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txteditemail.CustomButton.Name = "";
            this.txteditemail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txteditemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txteditemail.CustomButton.TabIndex = 1;
            this.txteditemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txteditemail.CustomButton.UseSelectable = true;
            this.txteditemail.CustomButton.Visible = false;
            this.txteditemail.Lines = new string[] {
        "Email Address"};
            this.txteditemail.Location = new System.Drawing.Point(93, 156);
            this.txteditemail.MaxLength = 32767;
            this.txteditemail.Name = "txteditemail";
            this.txteditemail.PasswordChar = '\0';
            this.txteditemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txteditemail.SelectedText = "";
            this.txteditemail.SelectionLength = 0;
            this.txteditemail.SelectionStart = 0;
            this.txteditemail.ShortcutsEnabled = true;
            this.txteditemail.Size = new System.Drawing.Size(205, 23);
            this.txteditemail.TabIndex = 20;
            this.txteditemail.Text = "Email Address";
            this.txteditemail.UseSelectable = true;
            this.txteditemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txteditemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbleditemail
            // 
            this.lbleditemail.AutoSize = true;
            this.lbleditemail.Location = new System.Drawing.Point(12, 156);
            this.lbleditemail.Name = "lbleditemail";
            this.lbleditemail.Size = new System.Drawing.Size(47, 19);
            this.lbleditemail.TabIndex = 19;
            this.lbleditemail.Text = "E-mail";
            // 
            // txteditLastName
            // 
            // 
            // 
            // 
            this.txteditLastName.CustomButton.Image = null;
            this.txteditLastName.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txteditLastName.CustomButton.Name = "";
            this.txteditLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txteditLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txteditLastName.CustomButton.TabIndex = 1;
            this.txteditLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txteditLastName.CustomButton.UseSelectable = true;
            this.txteditLastName.CustomButton.Visible = false;
            this.txteditLastName.Lines = new string[] {
        "Last Name"};
            this.txteditLastName.Location = new System.Drawing.Point(93, 127);
            this.txteditLastName.MaxLength = 32767;
            this.txteditLastName.Name = "txteditLastName";
            this.txteditLastName.PasswordChar = '\0';
            this.txteditLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txteditLastName.SelectedText = "";
            this.txteditLastName.SelectionLength = 0;
            this.txteditLastName.SelectionStart = 0;
            this.txteditLastName.ShortcutsEnabled = true;
            this.txteditLastName.Size = new System.Drawing.Size(205, 23);
            this.txteditLastName.TabIndex = 18;
            this.txteditLastName.Text = "Last Name";
            this.txteditLastName.UseSelectable = true;
            this.txteditLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txteditLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbleditLastName
            // 
            this.lbleditLastName.AutoSize = true;
            this.lbleditLastName.Location = new System.Drawing.Point(12, 127);
            this.lbleditLastName.Name = "lbleditLastName";
            this.lbleditLastName.Size = new System.Drawing.Size(71, 19);
            this.lbleditLastName.TabIndex = 17;
            this.lbleditLastName.Text = "Last Name";
            // 
            // txteditFirstName
            // 
            // 
            // 
            // 
            this.txteditFirstName.CustomButton.Image = null;
            this.txteditFirstName.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txteditFirstName.CustomButton.Name = "";
            this.txteditFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txteditFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txteditFirstName.CustomButton.TabIndex = 1;
            this.txteditFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txteditFirstName.CustomButton.UseSelectable = true;
            this.txteditFirstName.CustomButton.Visible = false;
            this.txteditFirstName.Lines = new string[] {
        "First Name"};
            this.txteditFirstName.Location = new System.Drawing.Point(93, 96);
            this.txteditFirstName.MaxLength = 32767;
            this.txteditFirstName.Name = "txteditFirstName";
            this.txteditFirstName.PasswordChar = '\0';
            this.txteditFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txteditFirstName.SelectedText = "";
            this.txteditFirstName.SelectionLength = 0;
            this.txteditFirstName.SelectionStart = 0;
            this.txteditFirstName.ShortcutsEnabled = true;
            this.txteditFirstName.Size = new System.Drawing.Size(205, 23);
            this.txteditFirstName.TabIndex = 16;
            this.txteditFirstName.Text = "First Name";
            this.txteditFirstName.UseSelectable = true;
            this.txteditFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txteditFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[] {
        "Search by Student Last Name"};
            this.txtSearch.Location = new System.Drawing.Point(118, 298);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(180, 23);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Search by Student Last Name";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(459, 16);
            this.lblHeader.MinimumSize = new System.Drawing.Size(400, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(133, 19);
            this.lblHeader.TabIndex = 13;
            this.lblHeader.Text = "Murphy Login Helper";
            // 
            // getAllDataBindingSource
            // 
            this.getAllDataBindingSource.DataMember = "GetAllData";
            this.getAllDataBindingSource.DataSource = this.pWDBDataSet;
            // 
            // getAllDataTableAdapter
            // 
            this.getAllDataTableAdapter.ClearBeforeFill = true;
            // 
            // pWDBTableAdapter1
            // 
            this.pWDBTableAdapter1.ClearBeforeFill = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(16, 257);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 23);
            this.metroButton1.TabIndex = 36;
            this.metroButton1.Text = "Refresh";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // picAdd
            // 
            this.picAdd.BackgroundImage = global::MHL.Properties.Resources.AddS;
            this.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picAdd.Location = new System.Drawing.Point(9, 13);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(66, 66);
            this.picAdd.TabIndex = 37;
            this.picAdd.UseSelectable = true;
            this.picAdd.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // lbleditFirstName
            // 
            this.lbleditFirstName.AutoSize = true;
            this.lbleditFirstName.Location = new System.Drawing.Point(12, 100);
            this.lbleditFirstName.Name = "lbleditFirstName";
            this.lbleditFirstName.Size = new System.Drawing.Size(73, 19);
            this.lbleditFirstName.TabIndex = 15;
            this.lbleditFirstName.Text = "First Name";
            // 
            // picDel
            // 
            this.picDel.BackgroundImage = global::MHL.Properties.Resources.DeleteS;
            this.picDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picDel.Enabled = false;
            this.picDel.Location = new System.Drawing.Point(232, 13);
            this.picDel.Name = "picDel";
            this.picDel.Size = new System.Drawing.Size(66, 66);
            this.picDel.TabIndex = 39;
            this.picDel.UseSelectable = true;
            // 
            // picSave
            // 
            this.picSave.BackgroundImage = global::MHL.Properties.Resources.SaveS;
            this.picSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSave.Enabled = false;
            this.picSave.Location = new System.Drawing.Point(118, 13);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(66, 66);
            this.picSave.TabIndex = 40;
            this.picSave.UseSelectable = true;
            this.picSave.Click += new System.EventHandler(this.picSave_Click_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserID";
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.ToolTipText = "User ID";
            this.Column1.Visible = false;
            // 
            // firstNAMEDataGridViewTextBoxColumn
            // 
            this.firstNAMEDataGridViewTextBoxColumn.DataPropertyName = "FirstNAME";
            this.firstNAMEDataGridViewTextBoxColumn.HeaderText = "Student";
            this.firstNAMEDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.firstNAMEDataGridViewTextBoxColumn.Name = "firstNAMEDataGridViewTextBoxColumn";
            this.firstNAMEDataGridViewTextBoxColumn.ToolTipText = "Student First Name";
            // 
            // lastNAMEDataGridViewTextBoxColumn
            // 
            this.lastNAMEDataGridViewTextBoxColumn.DataPropertyName = "LastNAME";
            this.lastNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNAMEDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.lastNAMEDataGridViewTextBoxColumn.Name = "lastNAMEDataGridViewTextBoxColumn";
            this.lastNAMEDataGridViewTextBoxColumn.ToolTipText = "Student Last Name";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 180;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ToolTipText = "Emaill Address / Login info";
            this.emailDataGridViewTextBoxColumn.Width = 180;
            // 
            // teacherFirstNameDataGridViewTextBoxColumn
            // 
            this.teacherFirstNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherFirstName";
            this.teacherFirstNameDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherFirstNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.teacherFirstNameDataGridViewTextBoxColumn.Name = "teacherFirstNameDataGridViewTextBoxColumn";
            this.teacherFirstNameDataGridViewTextBoxColumn.ToolTipText = "Teacher First Name";
            // 
            // teacherLastNameDataGridViewTextBoxColumn
            // 
            this.teacherLastNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherLastName";
            this.teacherLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.teacherLastNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.teacherLastNameDataGridViewTextBoxColumn.Name = "teacherLastNameDataGridViewTextBoxColumn";
            this.teacherLastNameDataGridViewTextBoxColumn.ToolTipText = "Teacher Last Name";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 80;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.MinimumWidth = 55;
            this.Admin.Name = "Admin";
            this.Admin.ToolTipText = "Admin Rights?";
            this.Admin.Width = 55;
            // 
            // MLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1112, 388);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tabMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MLH";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pWDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWDBBindingSource)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPWGenerator.ResumeLayout(false);
            this.tabPWGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabAddEdit.ResumeLayout(false);
            this.tabAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PWDBDataSet pWDBDataSet;
        private System.Windows.Forms.BindingSource pWDBBindingSource;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPWGenerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPringBarCode;
        private System.Windows.Forms.Button btnGenBarCode;
        public System.Windows.Forms.TabPage tabAddEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox ComboName;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox comboTeacherName;
        private System.Windows.Forms.PictureBox picPW;
        private System.Windows.Forms.PictureBox picLogin;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtEditPW;
        private MetroFramework.Controls.MetroLabel lblEditPW;
        private MetroFramework.Controls.MetroTextBox txteditemail;
        private MetroFramework.Controls.MetroLabel lbleditemail;
        private MetroFramework.Controls.MetroTextBox txteditLastName;
        private MetroFramework.Controls.MetroLabel lbleditLastName;
        private MetroFramework.Controls.MetroTextBox txteditFirstName;
        private MetroFramework.Controls.MetroButton btnFrmClear;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel lblEditTeachLName;
        private MetroFramework.Controls.MetroComboBox comboTeacherLastName;
        private MetroFramework.Controls.MetroLabel lblHeader;
        private System.Windows.Forms.BindingSource getAllDataBindingSource;
        private PWDBDataSetTableAdapters.GetAllDataTableAdapter getAllDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private PWDBDataSetTableAdapters.PWDBTableAdapter pWDBTableAdapter1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton picAdd;
        private MetroFramework.Controls.MetroLabel lbleditFirstName;
        private MetroFramework.Controls.MetroButton picDel;
        private MetroFramework.Controls.MetroButton picSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
    }
}

