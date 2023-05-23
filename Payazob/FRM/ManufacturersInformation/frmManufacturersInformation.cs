using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS.FRM.ManufacturersInformation
{
    public partial class frmManufacturersInformation : Form
    {
        public frmManufacturersInformation(bool showInProcessProject_)
        {
            InitializeComponent();
            CmbGiveValue();
            ShowData();
            ShowInProcessProject = showInProcessProject_;
            splitContainer2.Panel1Collapsed = !showInProcessProject_;
        }
        bool ShowInProcessProject= false;
        void CmbGiveValue()
        {
     
            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            DataGridViewComboBoxColumn Columns3 = new DataGridViewComboBoxColumn()
            {
                DataSource =  csm.SlGenGroup("Education"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenEducation_",
                Name = "xGenEducation_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(Columns3);

            DataGridViewComboBoxColumn Columns4 = new DataGridViewComboBoxColumn()
            {
                DataSource =  csm.SlGenGroup("Marital"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenMarital_",
                Name = "xGenMarital_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(Columns4);

            DataGridViewComboBoxColumn xGenAnnualActivityVolume_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("AnnualActivityVolume"),
                DisplayMember = "xName",
                HeaderText = "xGenAnnualActivityVolume_",
                ValueMember = "x_",
                DataPropertyName = "xGenAnnualActivityVolume_",
                Name = "xGenAnnualActivityVolume_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenAnnualActivityVolume_);

            DataGridViewComboBoxColumn xGenAbilitiesBuyAndSell_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Abilities"),
                DisplayMember = "xName",
                HeaderText = "xGenAbilitiesBuyAndSell_",
                ValueMember = "x_",
                DataPropertyName = "xGenAbilitiesBuyAndSell_",
                Name = "xGenAbilitiesBuyAndSell_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenAbilitiesBuyAndSell_);

            DataGridViewComboBoxColumn xGenAbilitiesDesigning_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Abilities"),
                DisplayMember = "xName",
                HeaderText = "xGenAbilitiesDesigning_",
                ValueMember = "x_",
                DataPropertyName = "xGenAbilitiesDesigning_",
                Name = "xGenAbilitiesDesigning_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenAbilitiesDesigning_);
            DataGridViewComboBoxColumn xGenAbilitiesImplementation_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Abilities"),
                DisplayMember = "xName",
                HeaderText = "xGenAbilitiesImplementation_",
                ValueMember = "x_",
                DataPropertyName = "xGenAbilitiesImplementation_",
                Name = "xGenAbilitiesImplementation_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenAbilitiesImplementation_);
            DataGridViewComboBoxColumn xGenAbilitiesSupply_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Abilities"),
                DisplayMember = "xName",
                HeaderText = "xGenAbilitiesSupply_",
                ValueMember = "x_",
                DataPropertyName = "xGenAbilitiesSupply_",
                Name = "xGenAbilitiesSupply_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenAbilitiesSupply_);
            DataGridViewComboBoxColumn xGenAbilitiesPermissions_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("Abilities"),
                DisplayMember = "xName",
                HeaderText = "xGenAbilitiesPermissions_",
                ValueMember = "x_",
                DataPropertyName = "xGenAbilitiesPermissions_",
                Name = "xGenAbilitiesPermissions_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenAbilitiesPermissions_);

            DataGridViewComboBoxColumn xGenQualityStatus = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("QualityStatus"),
                DisplayMember = "xName",
                HeaderText = "xGenQualityStatus",
                ValueMember = "x_",
                DataPropertyName = "xGenQualityStatus",
                Name = "xGenQualityStatus",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(xGenQualityStatus);


        }
        DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationDataTable dt_P;
        DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationFinishProjectDataTable dt_P1;
        DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectDataTable dt_P2;
        void ShowData()
        {
            dt_P = new BLL.ManufacturersInformation.csManufacturersInformation().mManufacturersInformation(-1);
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
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.Miladidate;
            //dataGridView1.Columns["xManufacturersInformationProject_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;

            dataGridView1.Columns["FormGrid1"].DisplayIndex = 0;

            
            //dataGridView1.Columns["xUnitNumber"].HeaderText = "شماره واحد یا طبقه";
            //dataGridView1.Columns["xGenUnitType_"].HeaderText = "نوع کاربری";
            //dataGridView1.Columns["xUnitNumber"].Width = 150;
        }
        void ShowDataGrid2(int x_)
        {
            if (x_ > 0)
            {
                dt_P1 = new BLL.ManufacturersInformation.csManufacturersInformation().mManufacturersInformationFinishProject(x_);
                dataGridView2.ReadOnly = false;
                bindingNavigator2.Enabled = true;
            }
            else
            {
                dt_P1 = new DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationFinishProjectDataTable();
                dataGridView2.ReadOnly = true;
                bindingNavigator2.Enabled = false;
            }
            bindingSource2.DataSource = dt_P1;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P1.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView2.Columns[dc.ColumnName].DisplayIndex = dt_P1.Columns[dc.ColumnName].Ordinal;

                }
            }
            dt_P1.xManufacturersInformation_Column.DefaultValue = x_;
            dt_P1.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xManufacturersInformation_"].Visible = false;
            dataGridView2.Columns["xDateTime"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xComment"].Width = 250;
            dataGridView2.Columns["xAddress"].Width = 250;
        }
        void ShowDataGrid3(int x_)
        {
            if (ShowInProcessProject)
            {
               

                if (x_ > 0)
                {
                    dt_P2 = new BLL.ManufacturersInformation.csManufacturersInformation().mManufacturersInformationInProcessProject(x_);
                    dataGridView3.ReadOnly = false;
                    bindingNavigator3.Enabled = true;
                }
                else
                {
                    dt_P2 = new DAL.ManufacturersInformation.DataSet_ManufacturersInformation.mManufacturersInformationInProcessProjectDataTable();
                    dataGridView3.ReadOnly = true;
                    bindingNavigator3.Enabled = false;
                }

                bindingSource3.DataSource = dt_P2;
                dataGridView3.DataSource = bindingSource3;
                bindingNavigator3.BindingSource = bindingSource3;
                CS.csDic css = new CS.csDic();
                foreach (DataColumn dc in dt_P2.Columns)
                {
                    if (dataGridView3.Columns[dc.ColumnName] != null)
                    {
                        dataGridView3.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                        dataGridView3.Columns[dc.ColumnName].DisplayIndex = dt_P2.Columns[dc.ColumnName].Ordinal;

                    }
                }
                dt_P2.xManufacturersInformation_Column.DefaultValue = x_;
                dt_P2.xSupplier_Column.DefaultValue = BLL.authentication.x_;
                dataGridView3.Columns["x_"].Visible = false;
                dataGridView3.Columns["xManufacturersInformation_"].Visible = false;
                dataGridView3.Columns["xDate"].Visible = false;
                dataGridView3.Columns["xSupplier_"].Visible = false;
                dataGridView3.Columns["xComment"].Width = 250;
                dataGridView3.Columns["xAddress"].Width = 250;
                dataGridView3.Columns["FormGrid3"].DisplayIndex = 0;
            }

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && (int?)dataGridView1["x_", e.RowIndex].Value > 0)
            {
                ShowDataGrid2((int)dataGridView1["x_", e.RowIndex].Value);
                ShowDataGrid3((int)dataGridView1["x_", e.RowIndex].Value);
            } 
            else
            {
                ShowDataGrid2(-1);
                ShowDataGrid3(-1);
            }
        }
        private void toolStripButton_Bottom_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.dataGridView2.EndEdit();
            this.dataGridView3.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ManufacturersInformation.csManufacturersInformation().UdManufacturersInformationFinishProject(dt_P1));
                if (dataGridView1.SelectedRows.Count > 0)
                    ShowDataGrid2((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
            }
        }
        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.dataGridView3.EndEdit();
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ManufacturersInformation.csManufacturersInformation().UdManufacturersInformationInProcessProject(dt_P2));
                if (dataGridView1.SelectedRows.Count > 0)
                    ShowDataGrid3((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
            }
        }
        private void saveToolStripButton_Top_Click_1(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.dataGridView3.EndEdit();
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.ManufacturersInformation.csManufacturersInformation().UdManufacturersInformation(dt_P));
                ShowData();
            }
        }
        private void toolStripButton_Add1_Click(object sender, EventArgs e)
        {
            new FRM.ManufacturersInformation.frmManufacturersInformationInsert(-1,true).ShowDialog();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex> -1 && e.ColumnIndex> -1 && dataGridView1.Columns[e.ColumnIndex].Name == "FormGrid1")
            {
                new FRM.ManufacturersInformation.frmManufacturersInformationInsert((int)dataGridView1["x_", e.RowIndex].Value, false).ShowDialog();
                ShowData();
            }
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 
                && e.ColumnIndex > -1 
                && dataGridView3.Columns[e.ColumnIndex].Name == "FormGrid3"
                && (int?)dataGridView3["x_", e.RowIndex].Value > 1
                )
            {
                new FRM.ManufacturersInformation.frmManufacturersInformationInProcessProjectNeeds((int)dataGridView3["x_", e.RowIndex].Value).ShowDialog();
               // ShowData();
            }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
