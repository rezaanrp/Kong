using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            //checkedListBox1.DataSource = csm.SlGenGroup("UsageType");
            //checkedListBox1.DisplayMember = "xName";
            //checkedListBox1.ValueMember = "x_";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(new BLL.SMS.csSMS().SendSMS_EsfahanPayamak());
        }
        public class FillFileClass
        {
            public string fileName;
            public string fileSize;
            public byte[] file;
        }
        FillFileClass fnGetFile()
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter =
               "All File (*.*)|*.*";
            dlgOpen.Title = "انتخاب فایل";
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                FileInfo fsI = new FileInfo(dlgOpen.FileName);
                FileStream fs = new FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read);
                byte[] file = new byte[fs.Length];
                fs.Read(file, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                FillFileClass fh = new FillFileClass();
                fh.fileName = dlgOpen.SafeFileName;
                fh.file = file;
                fh.fileSize = (fsI.Length / 1024 / 1024).ToString() + " MB";
                return fh;
                //cs.INCustomerReturnImage(file, (int)dataGridView1["x_", e.RowIndex].Value);
                //  textBox1.Text = dlgOpen.SafeFileName + "  " + (fsI.Length / 1024 / 1024).ToString() + " MB";

            }
            return null;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
          //  label1.Text = BLL.csshamsidate.shamsidatAndDayOFWeek;

           // FillFileClass ff = fnGetFile();
           // textBox1.Text = ff.fileName;

           //MessageBox.Show( new BLL.Message.csMessage().SendMessageByFile(ff.fileName, ff.file).ToString() );
        }
    }
}
