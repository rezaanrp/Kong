using System;
using System.Windows.Forms;

namespace MIS
{
    public partial class frmWorkYear : Form
    {
        public frmWorkYear()
        {
            InitializeComponent();
            lbl_WorkYear.Text = " سال کاری " + Properties.Settings.Default.WorkYear.Substring(0, 4);
            int y = int.Parse(BLL.csshamsidate.shamsidate.Substring(0, 4));
            for (int i = 1399; i <= y; i++)
            {
                this.cmb_Year.Items.AddRange(new object[] { i.ToString() });
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cmb_Year.SelectedIndex > -1)
            {
                Properties.Settings.Default.WorkYear = cmb_Year.SelectedItem + "/01/01";
                Properties.Settings.Default.Save();
                MessageBox.Show("تغییر سال کاری با موفقیت انجام شد",
                    "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show("سال کاری به درستی انتخاب نشده است",
                                "خطا",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);

            lbl_WorkYear.Text = " سال کاری " + Properties.Settings.Default.WorkYear.Substring(0, 4);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWorkYear_Load(object sender, EventArgs e)
        {

        }


    }
}
