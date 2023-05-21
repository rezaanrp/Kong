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
    public partial class frmRealEstate_GeneralReport : Form
    {
        public frmRealEstate_GeneralReport()
        {
            InitializeComponent();
            uc_Filter_Date1.Visible = false;
            splitContainer3.Panel2Collapsed = true;

        }

        DataTable dt_P;
        void ShowData(int CmbIndex)
        {
            uc_Filter_Date1.Visible = true;
            splitContainer3.Panel2Collapsed = false;

            if (CmbIndex == 0)
            {
                dt_P = new BLL.RealEstate.csRealEstate().SlRealEstate_RentSaleCountHiraAndMis(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);

                uc_Filter_Date1.Visible = false;
                splitContainer3.Panel2Collapsed = true;



            }
            else if(CmbIndex == 1)
            {
                dt_P = new BLL.RealEstate.csRealEstate().SlRealEstate_NumberFileByTypeAndMoon(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);

                uc_Filter_Date1.Visible = false;
                splitContainer3.Panel2Collapsed = true;
            }
            else if (CmbIndex == 2)
            {
                dt_P = new BLL.RealEstate.csRealEstate().SlRealEstate_NumberFileByUser(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);

                uc_Filter_Date1.Visible = false;
                splitContainer3.Panel2Collapsed = true;
            }
            else
            {
                dt_P = new DataTable();
                uc_Filter_Date1.Visible = false;
                splitContainer3.Panel2Collapsed = true;
            }
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
        }
   

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {

            if(uc_cmbAuto_ChartType.SelectedIndex > -1)
         
                ShowData(uc_cmbAuto_ChartType.SelectedIndex);

        }
    }
}
