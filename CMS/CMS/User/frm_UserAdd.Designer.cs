﻿namespace CMS
{
    partial class frm_UserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserAdd));
            this.cb_UserStatus = new System.Windows.Forms.ComboBox();
            this.lbl_UserStatus = new System.Windows.Forms.Label();
            this.cb_UserTitle = new System.Windows.Forms.ComboBox();
            this.lbl_UserTitle = new System.Windows.Forms.Label();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.tb_Organisation = new System.Windows.Forms.TextBox();
            this.lbl_Organisation = new System.Windows.Forms.Label();
            this.mtb_UserStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mtb_UserEndDate = new System.Windows.Forms.MaskedTextBox();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.mtb_LASERAgreement = new System.Windows.Forms.MaskedTextBox();
            this.mtb_ISET = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ISET = new System.Windows.Forms.Label();
            this.lbl_LASERAgreement = new System.Windows.Forms.Label();
            this.mtb_ISAT = new System.Windows.Forms.MaskedTextBox();
            this.mtb_SAFE = new System.Windows.Forms.MaskedTextBox();
            this.lbl_SAFE = new System.Windows.Forms.Label();
            this.lbl_ISAT = new System.Windows.Forms.Label();
            this.btn_UserOK = new System.Windows.Forms.Button();
            this.btn_UserCancel = new System.Windows.Forms.Button();
            this.gb_Training = new System.Windows.Forms.GroupBox();
            this.gb_UserDetail = new System.Windows.Forms.GroupBox();
            this.lbl_UserAdd = new System.Windows.Forms.Label();
            this.mtb_InformationSecurity = new System.Windows.Forms.MaskedTextBox();
            this.lbl_InformationSecurity = new System.Windows.Forms.Label();
            this.mtb_DataProtection = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DataProtection = new System.Windows.Forms.Label();
            this.gb_Training.SuspendLayout();
            this.gb_UserDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_UserStatus
            // 
            this.cb_UserStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_UserStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_UserStatus.FormattingEnabled = true;
            this.cb_UserStatus.Location = new System.Drawing.Point(75, 19);
            this.cb_UserStatus.Name = "cb_UserStatus";
            this.cb_UserStatus.Size = new System.Drawing.Size(76, 21);
            this.cb_UserStatus.TabIndex = 25;
            // 
            // lbl_UserStatus
            // 
            this.lbl_UserStatus.AutoSize = true;
            this.lbl_UserStatus.Location = new System.Drawing.Point(6, 22);
            this.lbl_UserStatus.Name = "lbl_UserStatus";
            this.lbl_UserStatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_UserStatus.TabIndex = 24;
            this.lbl_UserStatus.Text = "Status";
            // 
            // cb_UserTitle
            // 
            this.cb_UserTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_UserTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_UserTitle.FormattingEnabled = true;
            this.cb_UserTitle.Location = new System.Drawing.Point(75, 46);
            this.cb_UserTitle.Name = "cb_UserTitle";
            this.cb_UserTitle.Size = new System.Drawing.Size(76, 21);
            this.cb_UserTitle.TabIndex = 27;
            // 
            // lbl_UserTitle
            // 
            this.lbl_UserTitle.AutoSize = true;
            this.lbl_UserTitle.Location = new System.Drawing.Point(6, 49);
            this.lbl_UserTitle.Name = "lbl_UserTitle";
            this.lbl_UserTitle.Size = new System.Drawing.Size(27, 13);
            this.lbl_UserTitle.TabIndex = 26;
            this.lbl_UserTitle.Text = "Title";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(217, 46);
            this.tb_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FirstName.MaxLength = 50;
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(120, 20);
            this.tb_FirstName.TabIndex = 29;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(156, 50);
            this.lbl_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 28;
            this.lbl_FirstName.Text = "First Name";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(217, 70);
            this.tb_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_LastName.MaxLength = 50;
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(120, 20);
            this.tb_LastName.TabIndex = 31;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(155, 75);
            this.lbl_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 30;
            this.lbl_LastName.Text = "Last Name";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(217, 118);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Email.MaxLength = 255;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(120, 20);
            this.tb_Email.TabIndex = 33;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(181, 121);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 32;
            this.lbl_Email.Text = "Email";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(411, 118);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Phone.MaxLength = 15;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(75, 20);
            this.tb_Phone.TabIndex = 35;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(364, 121);
            this.lbl_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(38, 13);
            this.lbl_Phone.TabIndex = 34;
            this.lbl_Phone.Text = "Phone";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(75, 118);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_UserName.MaxLength = 12;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(75, 20);
            this.tb_UserName.TabIndex = 37;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(6, 121);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(60, 13);
            this.lbl_UserName.TabIndex = 36;
            this.lbl_UserName.Text = "User Name";
            // 
            // tb_Organisation
            // 
            this.tb_Organisation.Location = new System.Drawing.Point(75, 142);
            this.tb_Organisation.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Organisation.MaxLength = 255;
            this.tb_Organisation.Name = "tb_Organisation";
            this.tb_Organisation.Size = new System.Drawing.Size(262, 20);
            this.tb_Organisation.TabIndex = 39;
            // 
            // lbl_Organisation
            // 
            this.lbl_Organisation.AutoSize = true;
            this.lbl_Organisation.Location = new System.Drawing.Point(6, 145);
            this.lbl_Organisation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Organisation.Name = "lbl_Organisation";
            this.lbl_Organisation.Size = new System.Drawing.Size(66, 13);
            this.lbl_Organisation.TabIndex = 38;
            this.lbl_Organisation.Text = "Organisation";
            // 
            // mtb_UserStartDate
            // 
            this.mtb_UserStartDate.Location = new System.Drawing.Point(409, 46);
            this.mtb_UserStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_UserStartDate.Mask = "00/00/0000";
            this.mtb_UserStartDate.Name = "mtb_UserStartDate";
            this.mtb_UserStartDate.Size = new System.Drawing.Size(76, 20);
            this.mtb_UserStartDate.TabIndex = 41;
            this.mtb_UserStartDate.ValidatingType = typeof(System.DateTime);
            this.mtb_UserStartDate.Click += new System.EventHandler(this.enter_MaskedTextBox);
            this.mtb_UserStartDate.Enter += new System.EventHandler(this.enter_MaskedTextBox);
            // 
            // mtb_UserEndDate
            // 
            this.mtb_UserEndDate.Location = new System.Drawing.Point(410, 70);
            this.mtb_UserEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_UserEndDate.Mask = "00/00/0000";
            this.mtb_UserEndDate.Name = "mtb_UserEndDate";
            this.mtb_UserEndDate.Size = new System.Drawing.Size(76, 20);
            this.mtb_UserEndDate.TabIndex = 43;
            this.mtb_UserEndDate.ValidatingType = typeof(System.DateTime);
            this.mtb_UserEndDate.Click += new System.EventHandler(this.enter_MaskedTextBox);
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(354, 73);
            this.lbl_EndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_EndDate.TabIndex = 42;
            this.lbl_EndDate.Text = "End Date";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(350, 49);
            this.lbl_StartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_StartDate.TabIndex = 40;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // mtb_LASERAgreement
            // 
            this.mtb_LASERAgreement.Location = new System.Drawing.Point(105, 18);
            this.mtb_LASERAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_LASERAgreement.Mask = "00/00/0000";
            this.mtb_LASERAgreement.Name = "mtb_LASERAgreement";
            this.mtb_LASERAgreement.Size = new System.Drawing.Size(76, 20);
            this.mtb_LASERAgreement.TabIndex = 45;
            this.mtb_LASERAgreement.ValidatingType = typeof(System.DateTime);
            this.mtb_LASERAgreement.Click += new System.EventHandler(this.enter_MaskedTextBox);
            // 
            // mtb_ISET
            // 
            this.mtb_ISET.Location = new System.Drawing.Point(261, 18);
            this.mtb_ISET.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_ISET.Mask = "00/00/0000";
            this.mtb_ISET.Name = "mtb_ISET";
            this.mtb_ISET.Size = new System.Drawing.Size(76, 20);
            this.mtb_ISET.TabIndex = 47;
            this.mtb_ISET.ValidatingType = typeof(System.DateTime);
            this.mtb_ISET.Click += new System.EventHandler(this.enter_MaskedTextBox);
            // 
            // lbl_ISET
            // 
            this.lbl_ISET.AutoSize = true;
            this.lbl_ISET.Location = new System.Drawing.Point(214, 21);
            this.lbl_ISET.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ISET.Name = "lbl_ISET";
            this.lbl_ISET.Size = new System.Drawing.Size(31, 13);
            this.lbl_ISET.TabIndex = 46;
            this.lbl_ISET.Text = "ISET";
            // 
            // lbl_LASERAgreement
            // 
            this.lbl_LASERAgreement.AutoSize = true;
            this.lbl_LASERAgreement.Location = new System.Drawing.Point(5, 21);
            this.lbl_LASERAgreement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LASERAgreement.Name = "lbl_LASERAgreement";
            this.lbl_LASERAgreement.Size = new System.Drawing.Size(96, 13);
            this.lbl_LASERAgreement.TabIndex = 44;
            this.lbl_LASERAgreement.Text = "LASER Agreement";
            // 
            // mtb_ISAT
            // 
            this.mtb_ISAT.Location = new System.Drawing.Point(261, 42);
            this.mtb_ISAT.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_ISAT.Mask = "00/00/0000";
            this.mtb_ISAT.Name = "mtb_ISAT";
            this.mtb_ISAT.Size = new System.Drawing.Size(76, 20);
            this.mtb_ISAT.TabIndex = 49;
            this.mtb_ISAT.ValidatingType = typeof(System.DateTime);
            this.mtb_ISAT.Click += new System.EventHandler(this.enter_MaskedTextBox);
            // 
            // mtb_SAFE
            // 
            this.mtb_SAFE.Location = new System.Drawing.Point(261, 66);
            this.mtb_SAFE.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_SAFE.Mask = "00/00/0000";
            this.mtb_SAFE.Name = "mtb_SAFE";
            this.mtb_SAFE.Size = new System.Drawing.Size(76, 20);
            this.mtb_SAFE.TabIndex = 51;
            this.mtb_SAFE.ValidatingType = typeof(System.DateTime);
            this.mtb_SAFE.Click += new System.EventHandler(this.enter_MaskedTextBox);
            // 
            // lbl_SAFE
            // 
            this.lbl_SAFE.AutoSize = true;
            this.lbl_SAFE.Location = new System.Drawing.Point(214, 69);
            this.lbl_SAFE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SAFE.Name = "lbl_SAFE";
            this.lbl_SAFE.Size = new System.Drawing.Size(34, 13);
            this.lbl_SAFE.TabIndex = 50;
            this.lbl_SAFE.Text = "SAFE";
            // 
            // lbl_ISAT
            // 
            this.lbl_ISAT.AutoSize = true;
            this.lbl_ISAT.Location = new System.Drawing.Point(214, 45);
            this.lbl_ISAT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ISAT.Name = "lbl_ISAT";
            this.lbl_ISAT.Size = new System.Drawing.Size(31, 13);
            this.lbl_ISAT.TabIndex = 48;
            this.lbl_ISAT.Text = "ISAT";
            // 
            // btn_UserOK
            // 
            this.btn_UserOK.Location = new System.Drawing.Point(395, 265);
            this.btn_UserOK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UserOK.Name = "btn_UserOK";
            this.btn_UserOK.Size = new System.Drawing.Size(56, 24);
            this.btn_UserOK.TabIndex = 63;
            this.btn_UserOK.Text = "OK";
            this.btn_UserOK.UseVisualStyleBackColor = true;
            this.btn_UserOK.Click += new System.EventHandler(this.btn_UserOK_Click);
            // 
            // btn_UserCancel
            // 
            this.btn_UserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_UserCancel.Location = new System.Drawing.Point(455, 265);
            this.btn_UserCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UserCancel.Name = "btn_UserCancel";
            this.btn_UserCancel.Size = new System.Drawing.Size(56, 24);
            this.btn_UserCancel.TabIndex = 64;
            this.btn_UserCancel.Text = "Cancel";
            this.btn_UserCancel.UseVisualStyleBackColor = true;
            this.btn_UserCancel.Click += new System.EventHandler(this.btn_UserCancel_Click);
            // 
            // gb_Training
            // 
            this.gb_Training.Controls.Add(this.mtb_InformationSecurity);
            this.gb_Training.Controls.Add(this.lbl_LASERAgreement);
            this.gb_Training.Controls.Add(this.lbl_InformationSecurity);
            this.gb_Training.Controls.Add(this.mtb_LASERAgreement);
            this.gb_Training.Controls.Add(this.mtb_DataProtection);
            this.gb_Training.Controls.Add(this.lbl_DataProtection);
            this.gb_Training.Controls.Add(this.mtb_ISET);
            this.gb_Training.Controls.Add(this.lbl_ISET);
            this.gb_Training.Controls.Add(this.mtb_ISAT);
            this.gb_Training.Controls.Add(this.lbl_ISAT);
            this.gb_Training.Controls.Add(this.mtb_SAFE);
            this.gb_Training.Controls.Add(this.lbl_SAFE);
            this.gb_Training.Location = new System.Drawing.Point(12, 192);
            this.gb_Training.Name = "gb_Training";
            this.gb_Training.Size = new System.Drawing.Size(350, 97);
            this.gb_Training.TabIndex = 0;
            this.gb_Training.TabStop = false;
            this.gb_Training.Text = "Training";
            // 
            // gb_UserDetail
            // 
            this.gb_UserDetail.Controls.Add(this.lbl_UserAdd);
            this.gb_UserDetail.Controls.Add(this.cb_UserStatus);
            this.gb_UserDetail.Controls.Add(this.lbl_UserTitle);
            this.gb_UserDetail.Controls.Add(this.lbl_UserStatus);
            this.gb_UserDetail.Controls.Add(this.lbl_UserName);
            this.gb_UserDetail.Controls.Add(this.cb_UserTitle);
            this.gb_UserDetail.Controls.Add(this.lbl_LastName);
            this.gb_UserDetail.Controls.Add(this.lbl_FirstName);
            this.gb_UserDetail.Controls.Add(this.tb_FirstName);
            this.gb_UserDetail.Controls.Add(this.lbl_Email);
            this.gb_UserDetail.Controls.Add(this.tb_UserName);
            this.gb_UserDetail.Controls.Add(this.lbl_Organisation);
            this.gb_UserDetail.Controls.Add(this.lbl_StartDate);
            this.gb_UserDetail.Controls.Add(this.lbl_Phone);
            this.gb_UserDetail.Controls.Add(this.mtb_UserEndDate);
            this.gb_UserDetail.Controls.Add(this.tb_Email);
            this.gb_UserDetail.Controls.Add(this.mtb_UserStartDate);
            this.gb_UserDetail.Controls.Add(this.lbl_EndDate);
            this.gb_UserDetail.Controls.Add(this.tb_Phone);
            this.gb_UserDetail.Controls.Add(this.tb_LastName);
            this.gb_UserDetail.Controls.Add(this.tb_Organisation);
            this.gb_UserDetail.Location = new System.Drawing.Point(12, 12);
            this.gb_UserDetail.Name = "gb_UserDetail";
            this.gb_UserDetail.Size = new System.Drawing.Size(499, 174);
            this.gb_UserDetail.TabIndex = 0;
            this.gb_UserDetail.TabStop = false;
            this.gb_UserDetail.Text = "User Detail";
            // 
            // lbl_UserAdd
            // 
            this.lbl_UserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserAdd.Location = new System.Drawing.Point(159, 15);
            this.lbl_UserAdd.Name = "lbl_UserAdd";
            this.lbl_UserAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_UserAdd.Size = new System.Drawing.Size(327, 20);
            this.lbl_UserAdd.TabIndex = 32;
            this.lbl_UserAdd.Text = "Add new user";
            this.lbl_UserAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_InformationSecurity
            // 
            this.mtb_InformationSecurity.Location = new System.Drawing.Point(105, 66);
            this.mtb_InformationSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_InformationSecurity.Mask = "00/00/0000";
            this.mtb_InformationSecurity.Name = "mtb_InformationSecurity";
            this.mtb_InformationSecurity.Size = new System.Drawing.Size(76, 20);
            this.mtb_InformationSecurity.TabIndex = 68;
            this.mtb_InformationSecurity.ValidatingType = typeof(System.DateTime);
            this.mtb_InformationSecurity.Click += new System.EventHandler(this.enter_MaskedTextBox);
            // 
            // lbl_InformationSecurity
            // 
            this.lbl_InformationSecurity.AutoSize = true;
            this.lbl_InformationSecurity.Location = new System.Drawing.Point(5, 69);
            this.lbl_InformationSecurity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_InformationSecurity.Name = "lbl_InformationSecurity";
            this.lbl_InformationSecurity.Size = new System.Drawing.Size(100, 13);
            this.lbl_InformationSecurity.TabIndex = 67;
            this.lbl_InformationSecurity.Text = "Information Security";
            // 
            // mtb_DataProtection
            // 
            this.mtb_DataProtection.Location = new System.Drawing.Point(105, 42);
            this.mtb_DataProtection.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_DataProtection.Mask = "00/00/0000";
            this.mtb_DataProtection.Name = "mtb_DataProtection";
            this.mtb_DataProtection.Size = new System.Drawing.Size(76, 20);
            this.mtb_DataProtection.TabIndex = 66;
            this.mtb_DataProtection.ValidatingType = typeof(System.DateTime);
            this.mtb_DataProtection.Click += new System.EventHandler(this.enter_MaskedTextBox);
            // 
            // lbl_DataProtection
            // 
            this.lbl_DataProtection.AutoSize = true;
            this.lbl_DataProtection.Location = new System.Drawing.Point(5, 45);
            this.lbl_DataProtection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DataProtection.Name = "lbl_DataProtection";
            this.lbl_DataProtection.Size = new System.Drawing.Size(81, 13);
            this.lbl_DataProtection.TabIndex = 65;
            this.lbl_DataProtection.Text = "Data Protection";
            // 
            // frm_UserAdd
            // 
            this.AcceptButton = this.btn_UserOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_UserCancel;
            this.ClientSize = new System.Drawing.Size(524, 299);
            this.Controls.Add(this.gb_UserDetail);
            this.Controls.Add(this.gb_Training);
            this.Controls.Add(this.btn_UserOK);
            this.Controls.Add(this.btn_UserCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_UserAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "New User";
            this.gb_Training.ResumeLayout(false);
            this.gb_Training.PerformLayout();
            this.gb_UserDetail.ResumeLayout(false);
            this.gb_UserDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_UserStatus;
        private System.Windows.Forms.Label lbl_UserStatus;
        private System.Windows.Forms.ComboBox cb_UserTitle;
        private System.Windows.Forms.Label lbl_UserTitle;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tb_Organisation;
        private System.Windows.Forms.Label lbl_Organisation;
        private System.Windows.Forms.MaskedTextBox mtb_UserStartDate;
        private System.Windows.Forms.MaskedTextBox mtb_UserEndDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.MaskedTextBox mtb_LASERAgreement;
        private System.Windows.Forms.MaskedTextBox mtb_ISET;
        private System.Windows.Forms.Label lbl_ISET;
        private System.Windows.Forms.Label lbl_LASERAgreement;
        private System.Windows.Forms.MaskedTextBox mtb_ISAT;
        private System.Windows.Forms.MaskedTextBox mtb_SAFE;
        private System.Windows.Forms.Label lbl_SAFE;
        private System.Windows.Forms.Label lbl_ISAT;
        private System.Windows.Forms.Button btn_UserOK;
        private System.Windows.Forms.Button btn_UserCancel;
        private System.Windows.Forms.GroupBox gb_Training;
        private System.Windows.Forms.GroupBox gb_UserDetail;
        private System.Windows.Forms.Label lbl_UserAdd;
        private System.Windows.Forms.MaskedTextBox mtb_InformationSecurity;
        private System.Windows.Forms.Label lbl_InformationSecurity;
        private System.Windows.Forms.MaskedTextBox mtb_DataProtection;
        private System.Windows.Forms.Label lbl_DataProtection;
    }
}