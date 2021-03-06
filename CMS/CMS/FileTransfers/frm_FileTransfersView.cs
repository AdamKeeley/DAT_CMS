﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataControlsLib;
using DataControlsLib.DataModels;
using DataControlsLib.ViewModels;

namespace CMS.FileTransfers
{
    public partial class frm_FileTransfersView : Form
    {
        public frm_FileTransfersView()
        {
            InitializeComponent();
            PopulateIODataset();
            SetFilterControls();
            UpdateDataViewBinding();
        }

        private DataSet ds;
        private List<string> changeTypesWanted;
        private List<bool?> approvalsWanted;
        private List<string> transferMethodsWanted;
        private FileTransfer io = new FileTransfer();

        public void PopulateIODataset()
        {
            try
            {
                ds = io.GetAssetsHistoryDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get assets history data from the database." + Environment.NewLine + 
                                ex.Message + Environment.NewLine + 
                                Environment.NewLine +
                                ex.StackTrace);
            }

         }

        public void SetFilterControls()
        {
            dtp_DateToFilter.Value = DateTime.Now.Date;

            List<string> projNumbers = ds.Tables["tblProject"].AsEnumerable()
                .OrderBy(p => p.Field<string>("ProjectNumber"))
                .Select(p => p.Field<string>("ProjectNumber"))
                .ToList();
            projNumbers.Insert(0, "");
            cb_ProjectFilter.DataSource = projNumbers;

            UpdateChangeTypesWanted();
            UpdateApprovalsWanted();
            UpdateTransferMethodsWanted();
        }

        public void UpdateChangeTypesWanted()
        {
            changeTypesWanted = new List<string>();
            if (chkb_ChangeTypeImport.Checked) changeTypesWanted.Add(chkb_ChangeTypeImport.Text);
            if (chkb_ChangeTypeExport.Checked) changeTypesWanted.Add(chkb_ChangeTypeExport.Text);
            if (chkb_ChangeTypeDelete.Checked) changeTypesWanted.Add(chkb_ChangeTypeDelete.Text);
        }

        public void UpdateApprovalsWanted()
        {
            approvalsWanted = new List<bool?>();
            if (chkb_ChangeAccepted1.Checked) approvalsWanted.Add(true);
            if (chkb_ChangeAccepted0.Checked) approvalsWanted.Add(false);
        }

        public void UpdateTransferMethodsWanted()
        {
            transferMethodsWanted = new List<string>();
            if (chkb_TransferBiscom.Checked)
            {
                transferMethodsWanted.AddRange(
                    ds.Tables["tlkFileTransferMethods"].AsEnumerable()
                        .Where(tm => tm.Field<string>("MethodLabel").Contains(chkb_TransferBiscom.Text))
                        .Select(tm => tm.Field<string>("MethodLabel"))
                        .ToList()
                );
            }
            if (chkb_TransferOther.Checked)
            {
                transferMethodsWanted.AddRange(
                    ds.Tables["tlkFileTransferMethods"].AsEnumerable()
                        .Where(tm => !tm.Field<string>("MethodLabel").Contains(chkb_TransferBiscom.Text))
                        .Select(tm => tm.Field<string>("MethodLabel"))
                        .ToList()
                );
            }
        }

        public void UpdateDataViewBinding()
        {
            try
            {
                // Add filters for data owner, DSA, and transfer method
                dgv_DataIOHistory.DataSource = io.CreateAssetsHistoryView(
                    ds: ds,
                    dateFrom: dtp_DateFromFilter.Value.Date, 
                    dateTo: dtp_DateToFilter.Value.Date, 
                    proj: cb_ProjectFilter.Text.NullIfEmpty(),
                    owner: cb_DataOwnerFilter.Text.NullIfEmpty(),
                    dsa: cb_DsaFilter.Text.NullIfEmpty(),
                    transferMethods: transferMethodsWanted,
                    fPath: tb_FilePathFilter.Text.NullIfEmpty(),
                    changeTypes: changeTypesWanted,
                    approvals: approvalsWanted
                );
                dgv_DataIOHistory.Columns["Project"].Width = 60;
                dgv_DataIOHistory.Columns["VRE"].Width = 60;
                dgv_DataIOHistory.Columns["DataOwner"].Width = 120;
                dgv_DataIOHistory.Columns["ReviewDate"].Width = 100;
                dgv_DataIOHistory.Columns["RequestType"].Width = 95;
                dgv_DataIOHistory.Columns["FileName"].Width = 200;
                dgv_DataIOHistory.Columns["AssetGroup"].Width = 200;
                dgv_DataIOHistory.Columns["FilePath"].Width = 130;
                dgv_DataIOHistory.Columns["RepoPath"].Width = 130;
                dgv_DataIOHistory.Columns["TransferMethod"].Width = 110;
                dgv_DataIOHistory.Columns["TransferFrom"].Width = 120;
                dgv_DataIOHistory.Columns["TransferTo"].Width = 120;
                dgv_DataIOHistory.Columns["RequestedBy"].Width = 105;
                dgv_DataIOHistory.Columns["ReviewedBy"].Width = 95;
                dgv_DataIOHistory.Columns["DsaReviewed"].Width = 130;
                dgv_DataIOHistory.Columns["ChangeAccepted"].Width = 120;
                dgv_DataIOHistory.RowHeadersWidth = 15;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create assets history view." + Environment.NewLine + 
                                ex.Message + Environment.NewLine + 
                                Environment.NewLine +
                                ex.StackTrace);
            }
        }

        public void RefreshView()
        {
            PopulateIODataset();
            UpdateDataViewBinding();
        }

        private void btn_RefreshAssetsHistoryView_Click(object sender, EventArgs e)
        {
            UpdateChangeTypesWanted();
            UpdateApprovalsWanted();
            UpdateTransferMethodsWanted();
            UpdateDataViewBinding();
        }

        private void btn_NewImportRequest_Click(object sender, EventArgs e)
        {
            using (frm_FileTransfersAdd TransferAdd = new frm_FileTransfersAdd())
            {
                TransferAdd.ShowDialog();
                if (TransferAdd.insertSuccessful == true)
                {
                    RefreshView();
                }
            }
        }

        //private void btn_NewImportRequest_Click(object sender, EventArgs e)
        //{
        //    frm_DataTransferAdd NewTransfer = new frm_DataTransferAdd();
        //    NewTransfer.FormClosing += new FormClosingEventHandler(this.UpdateDataViewBinding);
        //    NewTransfer.Show();
        //}
    }
}
