using System;
using System.Data;
using System.Windows.Forms;

namespace MIS.FRM.Renovation
{
    public partial class frmRenovation : Form
    {
        public frmRenovation(CS.csEnum.RebuildingUser rebuildingUser)
        {
            InitializeComponent();
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Sex_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("SEX"),
                DisplayMember = "xName",
                HeaderText = "جنسیت",
                ValueMember = "x_",
                DataPropertyName = "xGenSex_",
                Name = "xGenSex_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

            dataGridView1.Columns.Add(combobox_Sex_);
            CmbGiveValue();
            ShowData("*");
            rebuildingUser_ = rebuildingUser;
        }
        CS.csEnum.RebuildingUser rebuildingUser_;
        void CmbGiveValue()
        {
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn xGenUsageType_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("UsageType"),
                DisplayMember = "xName",
                HeaderText = "xGenUsageType_",
                ValueMember = "x_",
                DataPropertyName = "xGenUsageType_",
                Name = "xGenUsageType_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenUsageType_);
            DataGridViewComboBoxColumn combobox_xGenBuldingStatus_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("BuldingStatus"),
                DisplayMember = "xName",
                HeaderText = "xBuldingStatus_",
                ValueMember = "x_",
                DataPropertyName = "xBuldingStatus_",
                Name = "xBuldingStatus_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(combobox_xGenBuldingStatus_);

            DataGridViewComboBoxColumn combobox_xGenContractType_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("ContractType"),
                DisplayMember = "xName",
                HeaderText = "xGenContractType_",
                ValueMember = "x_",
                DataPropertyName = "xGenContractType_",
                Name = "xGenContractType_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(combobox_xGenContractType_);
            DataGridViewComboBoxColumn combobox_xGenPosition_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("PositionBuilding"),
                DisplayMember = "xName",
                HeaderText = "xGenPosition_",
                ValueMember = "x_",
                DataPropertyName = "xGenPosition_",
                Name = "xGenPosition_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(combobox_xGenPosition_);






        }

        DAL.Customer.DataSet_Customer.mCustomer_SrchDataTable dt_P;
        DAL.Renovation.DataSet_Renovation.mRenovationDataTable dt_R;
        DAL.Renovation.DataSet_Renovation.mRenovationUnitDataTable dt_RU;
        void ShowData(string Srch)
        {

            BLL.Customer.csCustomer cs = new BLL.Customer.csCustomer();
            dt_P = cs.mCustomer_Srch(Srch);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_P.Columns[dc.ColumnName].Ordinal;

            }
            dataGridView1.Columns["xName"].HeaderText = "نام";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xLastName"].HeaderText = "نام خانوادگی";
            dataGridView1.Columns["xBirthDay"].DisplayIndex = dt_P.Columns["xBirthDay"].Ordinal;

            dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }
        void ShowDataDetails(int x_)
        {
            dt_R = new BLL.Renovation.csRenovation().mRenovation(x_);
            bindingSource2.DataSource = dt_R;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_R.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_R.Columns[dc.ColumnName].Ordinal;
            }
            dt_R.xCustomer_Column.DefaultValue = x_;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xCustomer_"].Visible = false;
            dataGridView2.Columns["xFloorsNumber_Ckm"].Visible = false;
            dataGridView2.Columns["xFloorsNumber_Remark"].Visible = false;
            dataGridView2.Columns["xBuildingUnitsNumberRequest_Ckm"].Visible = false;
            dataGridView2.Columns["xBuildingUnitsNumberRequest_Remark"].Visible = false;
            dataGridView2.Columns["xParkingNumber_CkM"].Visible = false;
            dataGridView2.Columns["xParkingNumber_Remark"].Visible = false;
            dataGridView2.Columns["xStorageNumber_CkM"].Visible = false;
            dataGridView2.Columns["xStorageNumber_Remark"].Visible = false;
            dataGridView2.Columns["xRoofGarden_CkM"].Visible = false;
            dataGridView2.Columns["xRoofGarden_Remark"].Visible = false;
            dataGridView2.Columns["xWeightDestruction"].Visible = false;
            dataGridView2.Columns["xGenTransportDestructionMetod_"].Visible = false;
            dataGridView2.Columns["xGenAccessDestructionMetod_"].Visible = false;
            dataGridView2.Columns["xRiskNeighborsComplaints"].Visible = false;
            dataGridView2.Columns["xRiskMunicipalityPrevent"].Visible = false;
            dataGridView2.Columns["xRiskDamageBuildingNeighbors"].Visible = false;
            dataGridView2.Columns["xDestructionDurationDay"].Visible = false;
            dataGridView2.Columns["xGenReasonsRenovation_"].Visible = false;
        }
        void ShowDataRenovationUnit(int? x_)
        {
            dt_RU = new BLL.Renovation.csRenovation().mRenovationUnit(x_);
            bindingSource3.DataSource = dt_RU;
            dataGridView3.DataSource = bindingSource3;
            bindingNavigator3.BindingSource = bindingSource3;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_RU.Columns)
            {
                if (dataGridView3.Columns[dc.ColumnName] != null)
                    dataGridView3.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView3.Columns[dc.ColumnName].DisplayIndex = dt_RU.Columns[dc.ColumnName].Ordinal;
            }
            dataGridView3.Columns["x_"].Visible = false;
            dataGridView3.Columns["xRenovation_"].Visible = false;
            dataGridView3.Columns["x_"].Visible = false;
            dataGridView3.Columns["xGenCoolingSystem_CkM"].Visible = false;
            dataGridView3.Columns["xGenCoolingSystem_Remark"].Visible = false;
            dataGridView3.Columns["xGenHeatingSystem_CkM"].Visible = false;
            dataGridView3.Columns["xGenHeatingSystem_Remark"].Visible = false;
            dataGridView3.Columns["xBedroomsNumber_CkM"].Visible = false;
            dataGridView3.Columns["xBedroomsNumber_Remark"].Visible = false;
            dataGridView3.Columns["xBathroomNumber_CkM"].Visible = false;
            dataGridView3.Columns["xBathroomNumber_Remark"].Visible = false;
            dataGridView3.Columns["xToiletNumber_CkM"].Visible = false;
            dataGridView3.Columns["xToiletNumber_Remark"].Visible = false;
            dataGridView3.Columns["xBathroomNumber_Remark"].Visible = false;
            dataGridView3.Columns["xToiletNumber_CkM"].Visible = false;
            dataGridView3.Columns["xToiletNumber_Remark"].Visible = false;
            dataGridView3.Columns["xGenFlooring_CkM"].Visible = false;
            dataGridView3.Columns["xGenFlooring_Remark"].Visible = false;
            dataGridView3.Columns["xGenKitchenCupboards_CkM"].Visible = false;
            dataGridView3.Columns["xGenKitchenCupboards_Remark"].Visible = false;
            dataGridView3.Columns["xBathtub_CkM"].Visible = false;
            dataGridView3.Columns["xBathtub_Remark"].Visible = false;

            dataGridView3.Columns["xJacuzzi_Ckm"].Visible = false;
            dataGridView3.Columns["xJacuzzi_Remark"].Visible = false;
            dataGridView3.Columns["xSauna_Ckm"].Visible = false;
            dataGridView3.Columns["xSauna_Remark"].Visible = false;
        }
        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(txt_Search.Text);
        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);
                ShowDataRenovationUnit(-1);

            }
        }
        private void ToolStripButton_Add_Rebuilding_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                new FRM.Renovation.frmRenovationRegister((int)dataGridView1.SelectedRows[0].Cells["x_"].Value, -1, CS.csEnum.RebuildingUser.User).ShowDialog();
                ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            }
        }
        private void DataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridView2["x_", e.RowIndex].Value != DBNull.Value && (int)dataGridView2["x_", e.RowIndex].Value > 0)
            {
                new FRM.Renovation.frmRenovationRegister(-1, (int)dataGridView2["x_", e.RowIndex].Value, CS.csEnum.RebuildingUser.User).ShowDialog();
                if (dataGridView1.SelectedCells.Count > 0)
                    ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            }
        }
        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dataGridView2["x_", e.RowIndex].Value != DBNull.Value)
                    ShowDataRenovationUnit((int?)dataGridView2["x_", e.RowIndex].Value);
                else
                    ShowDataRenovationUnit(-1);

            }
        }
        private void ToolStripButton_Unit_Save_Click(object sender, EventArgs e)
        {
            this.dataGridView3.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Renovation.csRenovation().UdxRenovationUnit_(dt_RU));
                if (dataGridView2.SelectedCells.Count > 0)
                    ShowDataDetails((int)dataGridView2["x_", dataGridView2.SelectedCells[0].RowIndex].Value);
            }
        }
        private void DataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridView3["x_", e.RowIndex].Value != DBNull.Value && (int)dataGridView3["x_", e.RowIndex].Value > 0)
            {
                new FRM.Renovation.frmRenovationUnit(-1, (int)dataGridView3["x_", e.RowIndex].Value).ShowDialog();
                if (dataGridView2.SelectedCells.Count > 0)
                    ShowDataRenovationUnit((int)dataGridView2["x_", dataGridView2.SelectedCells[0].RowIndex].Value);
            }
        }

        private void ToolStripButton_Save_BR_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Renovation.csRenovation().UdRenovation(dt_R));
                if (dataGridView1.SelectedCells.Count > 0)
                    ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            }
        }

        private void ToolStripButton_Add_BL_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int t = dataGridView2.SelectedCells[0].RowIndex;
                new FRM.Renovation.frmRenovationUnit((int)dataGridView2.Rows[t].Cells["x_"].Value, -1).ShowDialog();
            }

        }
    }
}
