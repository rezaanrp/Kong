using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.RealEstate
{
    public partial class frmStatementRefer : Form
    {
        public frmStatementRefer(CS.csEnum.StatementReferTo referTo)
        {
            InitializeComponent();
            ReferTo_ = referTo;
            //
            DataGridViewComboBoxColumn combobox_xConsultant_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xConsultant_",
                Name = "xConsultant_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xConsultant_);
            
            DataGridViewComboBoxColumn combobox_xSupplierReferFinanceConfirm_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplierReferFinanceConfirm_",
                Name = "xSupplierReferFinanceConfirm_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSupplierReferFinanceConfirm_);

            DataGridViewComboBoxColumn combobox_xReferConfirmSupplier_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xReferConfirmSupplier_",
                Name = "xReferConfirmSupplier_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xReferConfirmSupplier_);

            DataGridViewComboBoxColumn combobox_xSupplier1_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                Width = 100,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(combobox_xSupplier1_);

            DataGridViewComboBoxColumn xGenFollowUp_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("FollowUpFinalResult"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenFollowUpFinalResult_",
                Name = "xGenFollowUpFinalResult_",
                Width = 110,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenFollowUp_);

            DataGridViewComboBoxColumn xGenFollowUp2_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("FOLLOWUPTYPE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenFollowUp_",
                Name = "xGenFollowUp_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenFollowUp2_);

            if (referTo != CS.csEnum.StatementReferTo.amlak)
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dvg1_toolStripButton_Add.Enabled = false;
                dvg1_toolStripButton_delete.Enabled = false;
            }
            splitContainer4.Panel2Collapsed = true;

        }
        CS.csEnum.StatementReferTo ReferTo_;
        DAL.RealEstate.DataSet_StatementRefer.mStatementReferDataTable dt_P;
        DAL.RealEstate.DataSet_StatementRefer.mStatementReferFollowUpDataTable dt_D;
        void ShowData()
        {
            if (ReferTo_ == CS.csEnum.StatementReferTo.amlak)

                dt_P = new BLL.RealEstate.csRealEstate().mStatementRefer(BLL.authentication.x_,
                uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1

                );
            else
                dt_P = new BLL.RealEstate.csRealEstate().mStatementRefer(BLL.authentication.x_,
                uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (int)ReferTo_

                );
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_P.Columns[dc.ColumnName].Ordinal;
                }
            }
            dataGridView1.Columns["xBuildingAddress"].Width = 220;
            dataGridView1.Columns["xComment"].Width = 220;
            dataGridView1.Columns["xSuggestedItems"].Width = 220;
            dataGridView1.Columns["xSoldItems"].Width = 220;
            dataGridView1.Columns["xFailureConcludeContract"].Width = 220;
            dataGridView1.Columns["xFollowUpFinalResult"].Width = 220;

            dataGridView1.Columns["x_"].Visible = false;
            dt_P.xConsultant_Column.DefaultValue = BLL.authentication.x_;
            if (ReferTo_ == CS.csEnum.StatementReferTo.amlak)
            {
                dataGridView1.Columns["xSuggestedItems"].Visible = false;
                dataGridView1.Columns["xSoldItems"].Visible = false;
                dataGridView1.Columns["xContractCost"].Visible = false;
                dataGridView1.Columns["xConsultantCommission"].Visible = false;
                dataGridView1.Columns["xFollowUpComment"].Visible = false;
                dataGridView1.Columns["xReferFinanceConfirm"].Visible = false;
                dataGridView1.Columns["xSupplierReferFinanceConfirm_"].Visible = false;

                dataGridView1.Columns["xReferConfirm"].ReadOnly = true;
                dataGridView1.Columns["xReferConfirmSupplier_"].Visible = true;
                dataGridView1.Columns["xReferConfirmDate"].ReadOnly = true;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if(item.Cells["xReferConfirm"].Value != DBNull.Value && (bool ?)item.Cells["xReferConfirm"].Value == true)
                    {
                        item.ReadOnly = true;
                        item.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }

            }
            if (ReferTo_ == CS.csEnum.StatementReferTo.mali)
            {
                foreach (DataGridViewColumn dc in dataGridView1.Columns)
                {
                    if (dc.Name == "xContractCost"
                        || dc.Name == "xConsultantCommission"
                        || dc.Name == "xReferFinanceConfirm"
                        )
                    {
                        dc.ReadOnly = false;
                        dc.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                        dc.ReadOnly = true;

                }
                dataGridView1.Columns["xReferConfirm"].ReadOnly = true;
                dataGridView1.Columns["xReferConfirmSupplier_"].Visible = true;
                dataGridView1.Columns["xReferConfirmDate"].ReadOnly = true;
            }
            if (ReferTo_ == CS.csEnum.StatementReferTo.ejrae || 
                ReferTo_ == CS.csEnum.StatementReferTo.tarahi )
            {
                foreach (DataGridViewColumn dc in dataGridView1.Columns)
                {
                    if (dc.Name == "xSuggestedItems"
                        || dc.Name == "xFollowUpComment"
                        || dc.Name == "xSoldItems"
                        || dc.Name == "xReferConfirm"
                        )
                    {
                        dc.ReadOnly = false;
                        dc.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                        dc.ReadOnly = true;
                }
                dataGridView1.Columns["xReferConfirm"].ReadOnly = false;
                dataGridView1.Columns["xReferConfirmSupplier_"].Visible = true;
                dataGridView1.Columns["xReferConfirmDate"].ReadOnly = true;
            }
            // else
            //foreach (DataGridViewRow dr in dataGridView1.Rows)
            //{
            //    if (dr.Cells["xGenResultOfReferral_"].Value == null
            //        || dr.Cells["xGenResultOfReferral_"].Value == DBNull.Value)
            //        continue;
            //    if (
            //        dr.Cells["xReferFinanceConfirm"].Value != null
            //     && dr.Cells["xReferFinanceConfirm"].Value != DBNull.Value
            //     && (bool)dr.Cells["xReferFinanceConfirm"].Value == true
            //        )
            //    {
            //        dr.ReadOnly = true;
            //        dr.DefaultCellStyle.BackColor = Color.Gray;
            //        continue;

            //    }
            //    if ((int)dr.Cells["xGenResultOfReferral_"].Value == 284)
            //    {
            //        dr.DefaultCellStyle.BackColor = Color.LightGreen;
            //    }
            //    else if ((int)dr.Cells["xGenResultOfReferral_"].Value == 285)
            //    {
            //        dr.DefaultCellStyle.BackColor = Color.LightYellow;
            //    }
            //    else if ((int)dr.Cells["xGenResultOfReferral_"].Value == 286)
            //    {
            //        dr.DefaultCellStyle.BackColor = Color.LightPink;
            //    }
            //    else if ((int)dr.Cells["xGenResultOfReferral_"].Value == 287)
            //    {
            //        dr.DefaultCellStyle.BackColor = Color.LightBlue;
            //    }
            //}
        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.RealEstate.csRealEstate().UdStatementRefer(dt_P));
                ShowData();

            }
        }
        void ShowDataDetails(int x_)
        {
            if (x_ > 0)
            {
                dt_D = new BLL.RealEstate.csRealEstate().mStatementReferFollowUp(x_);
                dataGridView2.ReadOnly = false;
                bindingNavigator2.Enabled = true;
            }
            else
            {
                dt_D = new DAL.RealEstate.DataSet_StatementRefer.mStatementReferFollowUpDataTable();
                dataGridView2.ReadOnly = true;
                bindingNavigator2.Enabled = false;
            }
            bindingSource2.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_D.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_D.Columns[dc.ColumnName].Ordinal;
                }
            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xStatementRefer_"].Visible = false;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_D.xTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;
            dt_D.xStatementRefer_Column.DefaultValue = x_;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }
        void SaveDataBottom()
        {
            this.dataGridView2.EndEdit();
            this.dataGridView1.EndEdit();
            this.Validate();
            MessageBox.Show(new BLL.RealEstate.csRealEstate().UdStatementReferFollowUp(dt_D));
            ShowData();
        }
        private void frmClientReferralFollowUp_Load(object sender, EventArgs e)
        {
            ShowData();

            //if (dataGridView1.SelectedRows.Count > 0)

            //   ShowDataDetails((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);

            //else
            //    ShowDataDetails(-1);

        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData();

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            //uc.Fildvg = dataGridView1;
            //uc.RunExcel();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (ReferTo_ == CS.csEnum.StatementReferTo.amlak || ReferTo_ == CS.csEnum.StatementReferTo.mali)
            {
                splitContainer4.Panel2Collapsed = true;
            }
            else
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
                splitContainer4.Panel2Collapsed = false;
            }

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void toolStripButton_SMS_Click(object sender, EventArgs e)
        {
            //   new FRM.SMSPanel.frmSendSMS(ListMobForSMS(), "ClientReferral").ShowDialog();

        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //    splitContainer3.Panel2Collapsed = true;
        }
        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton_SaveTop_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.RealEstate.csRealEstate().UdStatementRefer(dt_P));
                ShowData();
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xReferConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xReferConfirmSupplier_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xReferConfirmDate", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xReferConfirmSupplier_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xReferConfirmDate", e.RowIndex].Value = DBNull.Value;

                }

            }
           else if (dataGridView1.Columns[e.ColumnIndex].Name == "xReferFinanceConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xSupplierReferFinanceConfirm_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                {
                    dataGridView1["xSupplierReferFinanceConfirm_", e.RowIndex].Value = DBNull.Value;

                }

            }
        }
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!this.dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly 
                && (
                this.dataGridView1.Columns[e.ColumnIndex].Name == "xFileDate"||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "xFollowUpDate"
                    )
                )
            {
                FRM.frmDate.frmDate date = new FRM.frmDate.frmDate
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                date.ShowDialog();
                if (date.accept)
                {
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = date.fDate;
                }
            }
        }
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            SaveDataBottom();
        }
    }
}
