using System;
using System.Windows.Forms;

namespace MIS
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        public object GetReport;

        private void frmReport_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = GetReport;

        }


    }
}
