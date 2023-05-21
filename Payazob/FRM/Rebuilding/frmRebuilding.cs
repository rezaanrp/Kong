using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.Rebuilding
{
    public partial class frmRebuilding : Form
    {
        public frmRebuilding(CS.csEnum.RebuildingUser rebuildingUser)
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
            DataGridViewComboBoxColumn cmb_xGenRoof_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Roof"),
                DisplayMember = "xName",
                HeaderText = "xGenRoof_",
                ValueMember = "x_",
                DataPropertyName = "xGenRoof_",
                Name = "xGenRoof_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(cmb_xGenRoof_);

            DataGridViewComboBoxColumn xGenRoof_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Roof"),
                DisplayMember = "xName",
                HeaderText = "xGenRoof_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenRoof_Ch_",
                Name = "xGenRoof_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenRoof_Ch_);
            DataGridViewComboBoxColumn cmb_xGenWall_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Wall"),
                DisplayMember = "xName",
                HeaderText = "xGenWall_",
                ValueMember = "x_",
                DataPropertyName = "xGenWall_",
                Name = "xGenWall_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(cmb_xGenWall_);

            DataGridViewComboBoxColumn cmb_xGenWall_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Wall"),
                DisplayMember = "xName",
                HeaderText = "xGenWall_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenWall_Ch_",
                Name = "xGenWall_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(cmb_xGenWall_Ch_);

            DataGridViewComboBoxColumn cmb_xGenBuildingSkeleton_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("BuildingSkeleton"),
                DisplayMember = "xName",
                HeaderText = "xGenBuildingSkeleton_",
                ValueMember = "x_",
                DataPropertyName = "xGenBuildingSkeleton_",
                Name = "xGenBuildingSkeleton_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(cmb_xGenBuildingSkeleton_);
            DataGridViewComboBoxColumn xGenBuildingSkeleton_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("BuildingSkeleton"),
                DisplayMember = "xName",
                HeaderText = "xGenBuildingSkeleton_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenBuildingSkeleton_Ch_",
                Name = "xGenBuildingSkeleton_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenBuildingSkeleton_Ch_);

            DataGridViewComboBoxColumn cmb_xGenFoundation_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Foundation"),
                DisplayMember = "xName",
                HeaderText = "xGenFoundation_",
                ValueMember = "x_",
                DataPropertyName = "xGenFoundation_",
                Name = "xGenFoundation_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(cmb_xGenFoundation_);
            DataGridViewComboBoxColumn xGenFoundation_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Foundation"),
                DisplayMember = "xName",
                HeaderText = "xGenFoundation_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenFoundation_Ch_",
                Name = "xGenFoundation_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenFoundation_Ch_);

            DataGridViewComboBoxColumn xGenHeatingSystem_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("HeatingSystem"),
                DisplayMember = "xName",
                HeaderText = "xGenHeatingSystem_",
                ValueMember = "x_",
                DataPropertyName = "xGenHeatingSystem_",
                Name = "xGenHeatingSystem_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenHeatingSystem_);

            DataGridViewComboBoxColumn xGenHeatingSystem_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("HeatingSystem"),
                DisplayMember = "xName",
                HeaderText = "xGenHeatingSystem_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenHeatingSystem_Ch_",
                Name = "xGenHeatingSystem_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenHeatingSystem_Ch_);

            DataGridViewComboBoxColumn xGenWaterPiping_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("WaterPiping"),
                DisplayMember = "xName",
                HeaderText = "xGenWaterPiping_",
                ValueMember = "x_",
                DataPropertyName = "xGenWaterPiping_",
                Name = "xGenWaterPiping_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenWaterPiping_);

            DataGridViewComboBoxColumn xGenWaterPiping_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("WaterPiping"),
                DisplayMember = "xName",
                HeaderText = "xGenWaterPiping_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenWaterPiping_Ch_",
                Name = "xGenWaterPiping_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenWaterPiping_Ch_);

            DataGridViewComboBoxColumn xGenGasPiping_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("GasPiping"),
                DisplayMember = "xName",
                HeaderText = "xGenGasPiping_",
                ValueMember = "x_",
                DataPropertyName = "xGenGasPiping_",
                Name = "xGenGasPiping_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenGasPiping_);
            DataGridViewComboBoxColumn xGenGasPiping_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("GasPiping"),
                DisplayMember = "xName",
                HeaderText = "xGenGasPiping_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenGasPiping_Ch_",
                Name = "xGenGasPiping_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenGasPiping_Ch_);


            DataGridViewComboBoxColumn xGenBathroomPiping_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("BathroomPiping"),
                DisplayMember = "xName",
                HeaderText = "xGenBathroomPiping_",
                ValueMember = "x_",
                DataPropertyName = "xGenBathroomPiping_",
                Name = "xGenBathroomPiping_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenBathroomPiping_);
            DataGridViewComboBoxColumn xGenBathroomPiping_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("BathroomPiping"),
                DisplayMember = "xName",
                HeaderText = "xGenBathroomPiping_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenBathroomPiping_Ch_",
                Name = "xGenBathroomPiping_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenBathroomPiping_Ch_);

            DataGridViewComboBoxColumn xGenCoolingSystem_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("CoolingSystem"),
                DisplayMember = "xName",
                HeaderText = "xGenCoolingSystem_",
                ValueMember = "x_",
                DataPropertyName = "xGenCoolingSystem_",
                Name = "xGenCoolingSystem_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenCoolingSystem_);
            DataGridViewComboBoxColumn xGenCoolingSystem_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("CoolingSystem"),
                DisplayMember = "xName",
                HeaderText = "xGenCoolingSystem_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenCoolingSystem_Ch_",
                Name = "xGenCoolingSystem_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenCoolingSystem_Ch_);

            DataGridViewComboBoxColumn xGenFlooring_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Flooring"),
                DisplayMember = "xName",
                HeaderText = "xGenFlooring_",
                ValueMember = "x_",
                DataPropertyName = "xGenFlooring_",
                Name = "xGenFlooring_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenFlooring_);
            DataGridViewComboBoxColumn xGenFlooring_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Flooring"),
                DisplayMember = "xName",
                HeaderText = "xGenFlooring_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenFlooring_Ch_",
                Name = "xGenFlooring_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenFlooring_Ch_);

            DataGridViewComboBoxColumn xGenKitchenFloor_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("KitchenFloor"),
                DisplayMember = "xName",
                HeaderText = "xGenKitchenFloor_",
                ValueMember = "x_",
                DataPropertyName = "xGenKitchenFloor_",
                Name = "xGenKitchenFloor_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenKitchenFloor_);

            DataGridViewComboBoxColumn xGenKitchenFloor_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("KitchenFloor"),
                DisplayMember = "xName",
                HeaderText = "xGenKitchenFloor_",
                ValueMember = "x_",
                DataPropertyName = "xGenKitchenFloor_Ch_",
                Name = "xGenKitchenFloor_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenKitchenFloor_Ch_);

            DataGridViewComboBoxColumn xGenKitchenWall_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("KitchenWall"),
                DisplayMember = "xName",
                HeaderText = "xGenKitchenWall_",
                ValueMember = "x_",
                DataPropertyName = "xGenKitchenWall_",
                Name = "xGenKitchenWall_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenKitchenWall_);
            DataGridViewComboBoxColumn xGenKitchenWall_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("KitchenWall"),
                DisplayMember = "xName",
                HeaderText = "xGenKitchenWall_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenKitchenWall_Ch_",
                Name = "xGenKitchenWall_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenKitchenWall_Ch_);

            DataGridViewComboBoxColumn xGenKitchenCupboards_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("KitchenCupboards"),
                DisplayMember = "xName",
                HeaderText = "xGenKitchenCupboards_",
                ValueMember = "x_",
                DataPropertyName = "xGenKitchenCupboards_",
                Name = "xGenKitchenCupboards_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenKitchenCupboards_);
            DataGridViewComboBoxColumn xGenKitchenCupboards_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("KitchenCupboards"),
                DisplayMember = "xName",
                HeaderText = "xGenKitchenCupboards_",
                ValueMember = "x_",
                DataPropertyName = "xGenKitchenCupboards_Ch_",
                Name = "xGenKitchenCupboards_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenKitchenCupboards_Ch_);

            DataGridViewComboBoxColumn xGenReasonsRebuilding_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("ReasonsRebuilding"),
                DisplayMember = "xName",
                HeaderText = "xGenReasonsRebuilding_",
                ValueMember = "x_",
                DataPropertyName = "xGenReasonsRebuilding_",
                Name = "xGenReasonsRebuilding_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenReasonsRebuilding_);
            DataGridViewComboBoxColumn xGenReasonsRebuilding_Ch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("ReasonsRebuilding"),
                DisplayMember = "xName",
                HeaderText = "xGenReasonsRebuilding_Ch_",
                ValueMember = "x_",
                DataPropertyName = "xGenReasonsRebuilding_Ch_",
                Name = "xGenReasonsRebuilding_Ch_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenReasonsRebuilding_Ch_);
        }

        DAL.Customer.DataSet_Customer.mCustomer_SrchDataTable dt_P;
        DAL.Rebuilding.DataSet_Rebuilding.mRebuildingDataTable dt_R;
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
            dt_R = new BLL.Rebuilding.csRebuilding().mRebuilding(x_);
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
            }
        }

        private void ToolStripButton_Add_Rebuilding_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                new FRM.Rebuilding.frmRebuildingRegister((int)dataGridView1.SelectedRows[0].Cells["x_"].Value, -1,CS.csEnum.RebuildingUser.User).ShowDialog();
        }

        private void DataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FRM.Rebuilding.frmRebuildingRegister(-1, (int)dataGridView2.SelectedRows[0].Cells["x_"].Value ,rebuildingUser_).ShowDialog();
            if (dataGridView1.SelectedCells.Count > 0)
                ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);

        }

        private void ToolStripButton11_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Rebuilding.csRebuilding().UdRebuilding(dt_R));
                if (dataGridView1.SelectedCells.Count > 0)
                    ShowDataDetails((int)dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value);
            }
        }
    }
}
