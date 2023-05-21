using BLL.ManufacturersInformation;
using System;
using System.Windows.Forms;

namespace MIS
{
    static class Program
    {
        static System.Threading.Mutex _mutex = new System.Threading.Mutex(false, "kfco");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            if (!_mutex.WaitOne(1000, false))
            {
                MessageBox.Show("نرم افزار هم اکنون در حال اجرا می باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frm.EnterSuccess)
            {
            //   new Form2().ShowDialog();
           // new FRM.RealEstate.frmStatementRefer( CS.csEnum.ReferTo.mali).ShowDialog();
                Application.Run(new Main());
            }
        }

    }
}
