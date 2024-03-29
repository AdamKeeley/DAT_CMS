﻿using DataControlsLib;
using DataControlsLib.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class frm_ProjectCostings : Form
    {
        public frm_ProjectCostings(string pNumber, DataSet ds_prj)
        {
            InitializeComponent();
            setTabIndex();
            refreshProjectCostingsForm(pNumber, ds_prj);
        }

        string ProjectNumber;
        
        private void refreshProjectCostingsForm(string pNumber, DataSet ds_Project)
        {
            //set controls
            string pName = ds_Project.Tables["tblProjects"].Select($"ProjectNumber = '{pNumber}'")[0]["ProjectName"].ToString();
            lbl_pNumber.Text = $"{pNumber} - {pName}";
            cb_CostingType.DataSource = ds_Project.Tables["tlkCostingType"];
            cb_CostingType.ValueMember = "CostingTypeId";
            cb_CostingType.DisplayMember = "CostingTypeDescription";

            // Clear controls
            cb_CostingType.SelectedIndex = -1;
            mtb_DateCosted.Clear();
            mtb_CostedFromDate.Clear();
            mtb_CostedToDate.Clear();
            tb_ComputeAmount.Text = "£0.00";
            tb_ItsSupportAmount.Text = "£0.00";
            tb_FixedInfraAmount.Text = "£0.00";
            mtb_FromDate.Clear();
            mtb_ToDate.Clear();
            nud_DatAllocation.Value = decimal.Parse(nud_DatAllocation.Minimum.ToString());

            ProjectNumber = pNumber;

            populateDatAllocationDGV(pNumber, ds_Project);
            populateProjectCostingsDGV(pNumber, ds_Project);
        }

        private void populateDatAllocationDGV (string pNumber, DataSet ds_Project)
        {
            string filter = $"ProjectNumber = '{pNumber}'";

            //populate DataGridView (dgv_projectDatAllocation) from DataTable (ds_Project.Tables["tblProjectDatAllocation"])
            //create new DataTable (dt_dgv_projectDatAllocation) that just contains columns and records of interest
            DataTable dt_dgv_projectDatAllocation = new DataTable();

            dt_dgv_projectDatAllocation.Columns.Add("PDAId");
            DataColumn FromDate = new DataColumn("From Date");
            FromDate.DataType = Type.GetType("System.DateTime");
            dt_dgv_projectDatAllocation.Columns.Add(FromDate);
            DataColumn ToDate = new DataColumn("To Date");
            ToDate.DataType = Type.GetType("System.DateTime");
            dt_dgv_projectDatAllocation.Columns.Add(ToDate);
            dt_dgv_projectDatAllocation.Columns.Add("Duration (months)");
            dt_dgv_projectDatAllocation.Columns.Add("FTE");

            //iterate through each entry in source DataTable and add to newly created DataTable
            DataRow row;
            foreach (DataRow nRow in ds_Project.Tables["tblProjectDatAllocation"].Select(filter))
            {
                row = dt_dgv_projectDatAllocation.NewRow();
                row["PDAId"] = nRow["ProjectDatAllocationId"];
                row["From Date"] = nRow["FromDate"];
                row["To Date"] = nRow["ToDate"];
                row["Duration (months)"] = nRow["DurationComputed"];
                row["FTE"] = nRow["FTE"];
                dt_dgv_projectDatAllocation.Rows.Add(row);
            }
            dgv_projectDatAllocation.DataSource = dt_dgv_projectDatAllocation;

            //format DataGridView (dgv_pNotes) column widths etc.
            dgv_projectDatAllocation.Columns["PDAId"].Visible = false;
            dgv_projectDatAllocation.Columns["From Date"].Width = 70;
            dgv_projectDatAllocation.Columns["To Date"].Width = 70;
            dgv_projectDatAllocation.Columns["Duration (months)"].Width = 55;
            dgv_projectDatAllocation.Columns["FTE"].Width = 50;
            dgv_projectDatAllocation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_projectDatAllocation.Sort(dgv_projectDatAllocation.Columns["From Date"], ListSortDirection.Descending);
        }

        private void populateProjectCostingsDGV(string pNumber, DataSet ds_Project)
        {
            string filter = $"ProjectNumber = '{pNumber}'";

            //populate DataGridView (dgv_ProjectCostings) from DataTable (ds_Project.Tables["tblProjectCostings"])
            //create new DataTable (dt_dgv_ProjectCostings) that just contains columns and records of interest
            DataTable dt_dgv_ProjectCostings = new DataTable();

            dt_dgv_ProjectCostings.Columns.Add("ProjectCostingsId");
            dt_dgv_ProjectCostings.Columns.Add("Costing Type");
            DataColumn FromDate = new DataColumn("From Date");
            FromDate.DataType = Type.GetType("System.DateTime");
            dt_dgv_ProjectCostings.Columns.Add(FromDate);
            DataColumn ToDate = new DataColumn("To Date");
            ToDate.DataType = Type.GetType("System.DateTime");
            dt_dgv_ProjectCostings.Columns.Add(ToDate);
            dt_dgv_ProjectCostings.Columns.Add("Duration (months)");
            dt_dgv_ProjectCostings.Columns.Add("Laser Compute");
            dt_dgv_ProjectCostings.Columns.Add("ITS Support");
            dt_dgv_ProjectCostings.Columns.Add("Fixed Infrastructure");

            //iterate through each entry in source DataTable and add to newly created DataTable
            DataRow row;
            foreach (DataRow nRow in ds_Project.Tables["tblProjectCostings"].Select(filter))
            {
                row = dt_dgv_ProjectCostings.NewRow();
                row["ProjectCostingsId"] = nRow["ProjectCostingsId"];
                foreach (DataRow c in nRow.GetParentRows("ProjectCostings_CostingType"))
                {
                    row["Costing Type"] = c["CostingTypeDescription"];
                }
                row["From Date"] = nRow["FromDate"];
                row["To Date"] = nRow["ToDate"];
                row["Duration (months)"] = nRow["DurationComputed"];
                row["Laser Compute"] = nRow["LaserCompute"];
                row["ITS Support"] = nRow["ItsSupport"];
                row["Fixed Infrastructure"] = nRow["FixedInfra"];
                dt_dgv_ProjectCostings.Rows.Add(row);
            }
            dgv_ProjectCostings.DataSource = dt_dgv_ProjectCostings;

            //format DataGridView (dgv_pNotes) column widths etc.
            dgv_ProjectCostings.Columns["ProjectCostingsId"].Visible = false;
            dgv_ProjectCostings.Columns["Costing Type"].Width = 105;
            dgv_ProjectCostings.Columns["From Date"].Width = 71;
            dgv_ProjectCostings.Columns["To Date"].Width = 71;
            dgv_ProjectCostings.Columns["Duration (months)"].Width = 60;
            dgv_ProjectCostings.Columns["Laser Compute"].Width = 60;
            dgv_ProjectCostings.Columns["ITS Support"].Width = 60;
            dgv_ProjectCostings.Columns["Fixed Infrastructure"].Width = 75;
            dgv_ProjectCostings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_ProjectCostings.Sort(dgv_ProjectCostings.Columns["From Date"], ListSortDirection.Descending);
            dgv_ProjectCostings.Columns["Laser Compute"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_ProjectCostings.Columns["ITS Support"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_ProjectCostings.Columns["Fixed Infrastructure"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        private mdl_ProjectDatAllocation fillProjectDatAllocationModel()
        {
            mdl_ProjectDatAllocation mdl_PDA = new mdl_ProjectDatAllocation();

            mdl_PDA.ProjectNumber = ProjectNumber;
            
            if (mtb_FromDate.Text != "" & mtb_FromDate.Text != "  /  /")
            {
                try
                {
                    mdl_PDA.FromDate = Convert.ToDateTime(mtb_FromDate.Text);
                }
                catch (Exception)
                {
                    //MessageBox.Show("Please enter valid DAT Allocation From Date");
                }
            }
            if (mtb_ToDate.Text != "" & mtb_ToDate.Text != "  /  /")
            {
                try
                {
                    mdl_PDA.ToDate = Convert.ToDateTime(mtb_ToDate.Text);
                }
                catch (Exception)
                {
                    //MessageBox.Show("Please enter valid DAT Allocation To Date");
                }
            }

            mdl_PDA.FTE = nud_DatAllocation.Value;

            return mdl_PDA;
        }

        private bool checkRequiredFields_DatAllocation(mdl_ProjectDatAllocation mdl_PDA)
        {
            // Check dates are present
            if (mdl_PDA.FromDate == default(DateTime))
            {
                MessageBox.Show("Please enter valid From Date");
                return false;
            }
            if (mdl_PDA.ToDate == default(DateTime))
            {
                MessageBox.Show("Please enter valid To Date");
                return false;
            }
            // Check chronology
            if (mdl_PDA.FromDate >= mdl_PDA.ToDate)
            {
                MessageBox.Show("From Date must be before To Date");
                return false;
            }

            // Check overlapping allocations
            foreach (DataGridViewRow row in dgv_projectDatAllocation.Rows)
            {
                if (row.Cells["From Date"].Value.ToString() != "" & row.Cells["To Date"].Value.ToString() != "")
                {
                    if ( (mdl_PDA.FromDate >= Convert.ToDateTime(row.Cells["From Date"].Value.ToString()) 
                        && mdl_PDA.FromDate <= Convert.ToDateTime(row.Cells["To Date"].Value.ToString()) )
                        | ( mdl_PDA.ToDate <= Convert.ToDateTime(row.Cells["To Date"].Value.ToString()) 
                        && mdl_PDA.ToDate >= Convert.ToDateTime(row.Cells["From Date"].Value.ToString()) ) )
                    {
                        MessageBox.Show("Entered period of DAT support coincides with existing period");
                        return false;
                    }
                }

            }

            return true;
        }

        private void insertNewDatAllocation()
        {
            Project Project = new Project();
            mdl_ProjectDatAllocation mdl_PDA = fillProjectDatAllocationModel();

            //Check fields have valid entries and fill DAT Allocation model
            if (checkRequiredFields_DatAllocation(mdl_PDA) == true)
            {
                //Add record to SQL db, close form on success
                if (Project.insertDatAllocation(mdl_PDA) == true)
                {
                    refreshProjectCostingsForm(ProjectNumber, Project.getProjectsDataSet());
                }
            }
        }

        private void removeDatAllocation()
        {
            if (dgv_projectDatAllocation.Rows.Count > 0 & dgv_projectDatAllocation.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dgv_projectDatAllocation.SelectedRows)
                {
                    mdl_ProjectDatAllocation mdl_PDA = new mdl_ProjectDatAllocation();

                    int current_PDAId = int.Parse(r.Cells["PDAId"].Value.ToString());

                    DateTime FromDate;
                    DateTime ToDate;
                    DateTime.TryParse(r.Cells["From Date"].Value.ToString(), out FromDate);
                    mdl_PDA.FromDate = FromDate;
                    DateTime.TryParse(r.Cells["To Date"].Value.ToString(), out ToDate);
                    mdl_PDA.ToDate = ToDate;
                    
                    DialogResult acceptProjectDoc = MessageBox.Show($"Delete DAT Allocation for period: {Environment.NewLine} {mdl_PDA.FromDate.ToShortDateString()} to {mdl_PDA.ToDate.ToShortDateString()}?", "", MessageBoxButtons.YesNo);
                    if (acceptProjectDoc == DialogResult.Yes)
                    {
                        Project projects = new Project();
                        // update valid to of current record
                        if (projects.deleteDatAllocation(current_PDAId) == true)
                            dgv_projectDatAllocation.Rows.RemoveAt(r.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a DAT Allocation record.");
            }
        }


        private mdl_ProjectCosting fillProjectCostingModel()
        {
            mdl_ProjectCosting mdl_PC = new mdl_ProjectCosting();

            mdl_PC.ProjectNumber = ProjectNumber;
            try
            {
                mdl_PC.CostingType = Convert.ToInt32(cb_CostingType.SelectedValue.ToString());
            }
            catch (Exception)
            {
                //MessageBox.Show("Please enter valid Costing Type");
            }

            try
            {
                mdl_PC.CostingTypeDesc = cb_CostingType.SelectedText.ToString();
            }
            catch (Exception)
            {

            }

            if (mtb_DateCosted.Text != "" & mtb_DateCosted.Text != "  /  /")
            {
                try
                {
                    mdl_PC.DateCosted = Convert.ToDateTime(mtb_DateCosted.Text);
                }
                catch (Exception)
                {
                    //MessageBox.Show("Please enter valid Date Costed");
                }
            }
            if (mtb_CostedFromDate .Text != "" & mtb_CostedFromDate.Text != "  /  /")
            {
                try
                {
                    mdl_PC.FromDate = Convert.ToDateTime(mtb_CostedFromDate.Text);
                }
                catch (Exception)
                {
                    //MessageBox.Show("Please enter valid Costed From Date");
                }
            }
            if (mtb_CostedToDate.Text != "" & mtb_CostedToDate.Text != "  /  /")
            {
                try
                {
                    mdl_PC.ToDate = Convert.ToDateTime(mtb_CostedToDate.Text);
                }
                catch (Exception)
                {
                    //MessageBox.Show("Please enter valid Costed To Date");
                }
            }
            try
            {
                mdl_PC.LaserCompute = Convert.ToDecimal(tb_ComputeAmount.Text.Replace(",", "").Replace("£", "").TrimStart('0'));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid LASER Compute Cost");
            }
            try
            {
                mdl_PC.ItsSupport = Convert.ToDecimal(tb_ItsSupportAmount.Text.Replace(",", "").Replace("£", "").TrimStart('0'));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid IT Services Support Cost");
            }
            try
            {
                mdl_PC.FixedInfra = Convert.ToDecimal(tb_FixedInfraAmount.Text.Replace(",", "").Replace("£", "").TrimStart('0'));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Fixed Infrastructure Cost");
            }

            return mdl_PC;
        }

        private bool checkRequiredFields_Costing(mdl_ProjectCosting mdl_PC)
        {
            if (!(mdl_PC.CostingType.ToString().Length > 0))
            {
                MessageBox.Show("Please enter valid Costing Type");
                return false;
            }

            // Check dates are present
            if (mdl_PC.DateCosted == default(DateTime))
            {
                MessageBox.Show("Please enter valid Date Costed");
                return false;
            }
            if (mdl_PC.FromDate == default(DateTime))
            {
                MessageBox.Show("Please enter valid Cost From Date");
                return false;
            }
            if (mdl_PC.ToDate == default(DateTime))
            {
                MessageBox.Show("Please enter valid Cost To Date");
                return false;
            }

            // Check chronology
            if (mdl_PC.FromDate >= mdl_PC.ToDate)
            {
                MessageBox.Show("Cost From Date must be before cost To Date");
                return false;
            }

            // Check cost values are present
            if (!(mdl_PC.LaserCompute > 0))
            {
                MessageBox.Show("Must enter an amount for LASER Compute costs");
                return false;
            }
            if (!(mdl_PC.ItsSupport > 0))
            {
                MessageBox.Show("Must enter an amount for IT Services Support costs");
                return false;
            }
            if (!(mdl_PC.FixedInfra > 0))
            {
                MessageBox.Show("Must enter an amount for Fixed Infrastructure costs");
                return false;
            }

            return true;
        }

        private void insertNewCosting()
        {
            Project Project = new Project();
            mdl_ProjectCosting mdl_PC = fillProjectCostingModel();

            //Check fields have valid entries and fill project costing model
            if (checkRequiredFields_Costing(mdl_PC) == true)
            {
                //Add record to SQL db, close form on success
                if (Project.insertProjectCosting(mdl_PC) == true)
                {
                    refreshProjectCostingsForm(ProjectNumber, Project.getProjectsDataSet());
                }
            }
        }

        private void removeCosting()
        {
            if (dgv_ProjectCostings.Rows.Count > 0 & dgv_ProjectCostings.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dgv_ProjectCostings.SelectedRows)
                {
                    mdl_ProjectCosting mdl_PC = new mdl_ProjectCosting();

                    int current_ProjectCostingsId = int.Parse(r.Cells["ProjectCostingsId"].Value.ToString());

                    DateTime FromDate;
                    DateTime ToDate;
                    DateTime.TryParse(r.Cells["From Date"].Value.ToString(), out FromDate);
                    mdl_PC.FromDate = FromDate;
                    DateTime.TryParse(r.Cells["To Date"].Value.ToString(), out ToDate);
                    mdl_PC.ToDate = ToDate;

                    mdl_PC.CostingTypeDesc = Convert.ToString(r.Cells["Costing Type"].Value);

                    DialogResult acceptProjectCosting = MessageBox.Show($"Delete Project Costing for: {Environment.NewLine} {mdl_PC.CostingTypeDesc} {Environment.NewLine} {mdl_PC.FromDate.ToShortDateString()} to {mdl_PC.ToDate.ToShortDateString()}?", "", MessageBoxButtons.YesNo);
                    if (acceptProjectCosting == DialogResult.Yes)
                    {
                        Project projects = new Project();
                        // update valid to of current record
                        if (projects.deleteProjectCosting(current_ProjectCostingsId) == true)
                            dgv_ProjectCostings.Rows.RemoveAt(r.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a DAT Allocation record.");
            }
        }


        private void setTabIndex()
        {
            int x = 999;
            foreach (Control c in this.Controls)
            {
                c.TabIndex = x;
            }

            x = 0;

            gb_LaserCosts.TabIndex = ++x;
            cb_CostingType.TabIndex = ++x;
            mtb_DateCosted.TabIndex = ++x;
            mtb_CostedFromDate.TabIndex = ++x;
            mtb_CostedToDate.TabIndex = ++x;
            tb_ComputeAmount.TabIndex = ++x;
            tb_ItsSupportAmount.TabIndex = ++x;
            tb_FixedInfraAmount.TabIndex = ++x;
            btn_LaserCosting_Add.TabIndex = ++x;
            btn_LaserCosting_Remove.TabIndex = ++x;

            gb_DatSupport.TabIndex = ++x;
            gb_NewDatAllocation.TabIndex = ++x;
            mtb_FromDate.TabIndex = ++x;
            mtb_ToDate.TabIndex = ++x;
            nud_DatAllocation.TabIndex = ++x;
            btn_Project_ProjectDatAllocation_Add.TabIndex = ++x;
            btn_Project_ProjectDatAllocation_Remove.TabIndex = ++x;

            btn_Project_ProjectDatAllocation_Close.TabIndex = ++x;
        }

        /// <summary>
        /// Prevent the cursor from being positioned in the middle of an empty masked textbox when 
        /// the user clicks in it. Get's a reference to target control and passes it through to method in 
        /// static helper class.
        /// To be called by the OnClick event of the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enter_MaskedTextBox(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox)
            {
                MaskedTextBox maskedtextBox_Target = (MaskedTextBox)Controls.Find(((Control)sender).Name, true).First();
                Static_Helper.enter_MaskedTextBox(maskedtextBox_Target);
            }
        }

        /// <summary>
        /// Prevent the cursor from being positioned in the middle of an empty textbox when 
        /// the user clicks in it. Get's a reference to target control and passes it through to method in 
        /// static helper class.
        /// To be called by the OnClick event of the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enter_TextBox(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox_Target = (TextBox)Controls.Find(((Control)sender).Name, true).First();
                Static_Helper.enter_TextBox(textBox_Target);
            }
        }

        /// <summary>
        /// Get's a reference to target control and passes it through to method in static helper class.
        /// To be called by the TextChanged event of the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textChanged_TextBox_Currency(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox_Target = (TextBox)Controls.Find(((Control)sender).Name, true).First();
                Static_Helper.textChanged_TextBox_Currency(textBox_Target);
            }
        }

        private void btn_Project_ProjectDatAllocation_Add_Click(object sender, EventArgs e)
        {
            insertNewDatAllocation();
        }

        private void btn_Project_ProjectDatAllocation_Remove_Click(object sender, EventArgs e)
        {
            removeDatAllocation();
        }

        private void btn_LaserCosting_Add_Click(object sender, EventArgs e)
        {
            insertNewCosting();
        }

        private void btn_LaserCosting_Remove_Click(object sender, EventArgs e)
        {
            removeCosting();
        }
    }
}
