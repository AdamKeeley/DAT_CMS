﻿namespace CMS
{
    partial class frm_ProjectAll
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
            this.lbl_LeadApplicant = new System.Windows.Forms.Label();
            this.tb_pLeadApplicantValue = new System.Windows.Forms.TextBox();
            this.btn_ClearSearch = new System.Windows.Forms.Button();
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.lbl_Faculty = new System.Windows.Forms.Label();
            this.cb_DATRAG = new System.Windows.Forms.ComboBox();
            this.lbl_DATRAG = new System.Windows.Forms.Label();
            this.lbl_pClassification = new System.Windows.Forms.Label();
            this.cb_pClassification = new System.Windows.Forms.ComboBox();
            this.btn_NewProject = new System.Windows.Forms.Button();
            this.dgv_ProjectList = new System.Windows.Forms.DataGridView();
            this.lbl_pPI = new System.Windows.Forms.Label();
            this.tb_pPIValue = new System.Windows.Forms.TextBox();
            this.cb_pStage = new System.Windows.Forms.ComboBox();
            this.lbl_pStage = new System.Windows.Forms.Label();
            this.tb_pNameValue = new System.Windows.Forms.TextBox();
            this.lbl_pName = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_LeadApplicant
            // 
            this.lbl_LeadApplicant.AutoSize = true;
            this.lbl_LeadApplicant.Location = new System.Drawing.Point(436, 59);
            this.lbl_LeadApplicant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LeadApplicant.Name = "lbl_LeadApplicant";
            this.lbl_LeadApplicant.Size = new System.Drawing.Size(78, 13);
            this.lbl_LeadApplicant.TabIndex = 67;
            this.lbl_LeadApplicant.Text = "Lead Applicant";
            // 
            // tb_pLeadApplicantValue
            // 
            this.tb_pLeadApplicantValue.Location = new System.Drawing.Point(518, 56);
            this.tb_pLeadApplicantValue.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pLeadApplicantValue.Name = "tb_pLeadApplicantValue";
            this.tb_pLeadApplicantValue.Size = new System.Drawing.Size(173, 20);
            this.tb_pLeadApplicantValue.TabIndex = 68;
            this.tb_pLeadApplicantValue.TextChanged += new System.EventHandler(this.searchItemAdded);
            // 
            // btn_ClearSearch
            // 
            this.btn_ClearSearch.Location = new System.Drawing.Point(892, 74);
            this.btn_ClearSearch.Name = "btn_ClearSearch";
            this.btn_ClearSearch.Size = new System.Drawing.Size(90, 23);
            this.btn_ClearSearch.TabIndex = 66;
            this.btn_ClearSearch.Text = "Clear Search";
            this.btn_ClearSearch.UseVisualStyleBackColor = true;
            this.btn_ClearSearch.Click += new System.EventHandler(this.clearSearch);
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_Faculty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Location = new System.Drawing.Point(518, 105);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(173, 21);
            this.cb_Faculty.TabIndex = 65;
            this.cb_Faculty.SelectionChangeCommitted += new System.EventHandler(this.searchItemAdded);
            // 
            // lbl_Faculty
            // 
            this.lbl_Faculty.AutoSize = true;
            this.lbl_Faculty.Location = new System.Drawing.Point(473, 108);
            this.lbl_Faculty.Name = "lbl_Faculty";
            this.lbl_Faculty.Size = new System.Drawing.Size(41, 13);
            this.lbl_Faculty.TabIndex = 64;
            this.lbl_Faculty.Text = "Faculty";
            // 
            // cb_DATRAG
            // 
            this.cb_DATRAG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_DATRAG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_DATRAG.FormattingEnabled = true;
            this.cb_DATRAG.Location = new System.Drawing.Point(615, 6);
            this.cb_DATRAG.Name = "cb_DATRAG";
            this.cb_DATRAG.Size = new System.Drawing.Size(76, 21);
            this.cb_DATRAG.TabIndex = 61;
            this.cb_DATRAG.SelectionChangeCommitted += new System.EventHandler(this.searchItemAdded);
            // 
            // lbl_DATRAG
            // 
            this.lbl_DATRAG.AutoSize = true;
            this.lbl_DATRAG.Location = new System.Drawing.Point(554, 9);
            this.lbl_DATRAG.Name = "lbl_DATRAG";
            this.lbl_DATRAG.Size = new System.Drawing.Size(55, 13);
            this.lbl_DATRAG.TabIndex = 60;
            this.lbl_DATRAG.Text = "DAT RAG";
            // 
            // lbl_pClassification
            // 
            this.lbl_pClassification.AutoSize = true;
            this.lbl_pClassification.Location = new System.Drawing.Point(199, 108);
            this.lbl_pClassification.Name = "lbl_pClassification";
            this.lbl_pClassification.Size = new System.Drawing.Size(68, 13);
            this.lbl_pClassification.TabIndex = 59;
            this.lbl_pClassification.Text = "Classification";
            // 
            // cb_pClassification
            // 
            this.cb_pClassification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_pClassification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_pClassification.FormattingEnabled = true;
            this.cb_pClassification.Location = new System.Drawing.Point(273, 105);
            this.cb_pClassification.Name = "cb_pClassification";
            this.cb_pClassification.Size = new System.Drawing.Size(124, 21);
            this.cb_pClassification.TabIndex = 57;
            this.cb_pClassification.SelectionChangeCommitted += new System.EventHandler(this.searchItemAdded);
            // 
            // btn_NewProject
            // 
            this.btn_NewProject.Location = new System.Drawing.Point(893, 102);
            this.btn_NewProject.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewProject.Name = "btn_NewProject";
            this.btn_NewProject.Size = new System.Drawing.Size(90, 24);
            this.btn_NewProject.TabIndex = 55;
            this.btn_NewProject.Text = "Create Project";
            this.btn_NewProject.UseVisualStyleBackColor = true;
            this.btn_NewProject.Click += new System.EventHandler(this.open_frm_ProjectAdd);
            // 
            // dgv_ProjectList
            // 
            this.dgv_ProjectList.AllowUserToAddRows = false;
            this.dgv_ProjectList.AllowUserToDeleteRows = false;
            this.dgv_ProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProjectList.Location = new System.Drawing.Point(11, 131);
            this.dgv_ProjectList.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ProjectList.Name = "dgv_ProjectList";
            this.dgv_ProjectList.ReadOnly = true;
            this.dgv_ProjectList.RowTemplate.Height = 24;
            this.dgv_ProjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProjectList.Size = new System.Drawing.Size(972, 419);
            this.dgv_ProjectList.TabIndex = 51;
            this.dgv_ProjectList.TabStop = false;
            this.dgv_ProjectList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProjectList_CellDoubleClick);
            // 
            // lbl_pPI
            // 
            this.lbl_pPI.AutoSize = true;
            this.lbl_pPI.Location = new System.Drawing.Point(409, 83);
            this.lbl_pPI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pPI.Name = "lbl_pPI";
            this.lbl_pPI.Size = new System.Drawing.Size(105, 13);
            this.lbl_pPI.TabIndex = 42;
            this.lbl_pPI.Text = "Principal Investigator";
            // 
            // tb_pPIValue
            // 
            this.tb_pPIValue.Location = new System.Drawing.Point(518, 80);
            this.tb_pPIValue.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pPIValue.Name = "tb_pPIValue";
            this.tb_pPIValue.Size = new System.Drawing.Size(173, 20);
            this.tb_pPIValue.TabIndex = 44;
            this.tb_pPIValue.TextChanged += new System.EventHandler(this.searchItemAdded);
            // 
            // cb_pStage
            // 
            this.cb_pStage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_pStage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_pStage.FormattingEnabled = true;
            this.cb_pStage.Location = new System.Drawing.Point(273, 79);
            this.cb_pStage.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pStage.Name = "cb_pStage";
            this.cb_pStage.Size = new System.Drawing.Size(124, 21);
            this.cb_pStage.TabIndex = 43;
            this.cb_pStage.SelectionChangeCommitted += new System.EventHandler(this.searchItemAdded);
            // 
            // lbl_pStage
            // 
            this.lbl_pStage.AutoSize = true;
            this.lbl_pStage.Location = new System.Drawing.Point(232, 82);
            this.lbl_pStage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pStage.Name = "lbl_pStage";
            this.lbl_pStage.Size = new System.Drawing.Size(35, 13);
            this.lbl_pStage.TabIndex = 41;
            this.lbl_pStage.Text = "Stage";
            // 
            // tb_pNameValue
            // 
            this.tb_pNameValue.Location = new System.Drawing.Point(273, 32);
            this.tb_pNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pNameValue.Name = "tb_pNameValue";
            this.tb_pNameValue.Size = new System.Drawing.Size(418, 20);
            this.tb_pNameValue.TabIndex = 40;
            this.tb_pNameValue.TextChanged += new System.EventHandler(this.searchItemAdded);
            // 
            // lbl_pName
            // 
            this.lbl_pName.AutoSize = true;
            this.lbl_pName.Location = new System.Drawing.Point(204, 35);
            this.lbl_pName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pName.Name = "lbl_pName";
            this.lbl_pName.Size = new System.Drawing.Size(63, 13);
            this.lbl_pName.TabIndex = 39;
            this.lbl_pName.Text = "Project Title";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(891, 45);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(91, 23);
            this.btn_Refresh.TabIndex = 69;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.refreshPage);
            // 
            // frm_ProjectAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 561);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_LeadApplicant);
            this.Controls.Add(this.tb_pLeadApplicantValue);
            this.Controls.Add(this.btn_ClearSearch);
            this.Controls.Add(this.cb_Faculty);
            this.Controls.Add(this.lbl_Faculty);
            this.Controls.Add(this.cb_DATRAG);
            this.Controls.Add(this.lbl_DATRAG);
            this.Controls.Add(this.lbl_pClassification);
            this.Controls.Add(this.cb_pClassification);
            this.Controls.Add(this.btn_NewProject);
            this.Controls.Add(this.dgv_ProjectList);
            this.Controls.Add(this.lbl_pPI);
            this.Controls.Add(this.tb_pPIValue);
            this.Controls.Add(this.cb_pStage);
            this.Controls.Add(this.lbl_pStage);
            this.Controls.Add(this.tb_pNameValue);
            this.Controls.Add(this.lbl_pName);
            this.Name = "frm_ProjectAll";
            this.Text = "frm_ProjectAll";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_LeadApplicant;
        private System.Windows.Forms.TextBox tb_pLeadApplicantValue;
        private System.Windows.Forms.Button btn_ClearSearch;
        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.Label lbl_Faculty;
        private System.Windows.Forms.ComboBox cb_DATRAG;
        private System.Windows.Forms.Label lbl_DATRAG;
        private System.Windows.Forms.Label lbl_pClassification;
        private System.Windows.Forms.ComboBox cb_pClassification;
        private System.Windows.Forms.Button btn_NewProject;
        private System.Windows.Forms.DataGridView dgv_ProjectList;
        private System.Windows.Forms.Label lbl_pPI;
        private System.Windows.Forms.TextBox tb_pPIValue;
        private System.Windows.Forms.ComboBox cb_pStage;
        private System.Windows.Forms.Label lbl_pStage;
        private System.Windows.Forms.TextBox tb_pNameValue;
        private System.Windows.Forms.Label lbl_pName;
        private System.Windows.Forms.Button btn_Refresh;
    }
}