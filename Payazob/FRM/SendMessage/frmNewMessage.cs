using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MIS.FRM.SendMessage
{
    public partial class frmNewMessage : Form
    {
        public frmNewMessage(bool IsReply, bool Isforward, string ReplyFrom,
            int ReplyUser_, string ReplyName, string MessageSubject, string textMessage,
                string richtxtbox_rtf)
        {
            InitializeComponent();
            dt_m = new DAL.Message.DataSet_Message.SlMessageDataTable();
            uc_txtBoxDate.Text = BLL.csshamsidate.shamsidate;
            IsRe = IsReply;
            IsFr = Isforward;
            RepFrm = ReplyFrom;
            msgbox = textMessage;
            if (ReplyUser_ != -1)
            {
                rec = new List<int>();
                rec.Add(ReplyUser_);
                uc_txtBox_reciver.Text = ReplyName;
                uc_txtBox_Subject.Text = "پاسخ به " + MessageSubject;
            }
            if (IsFr)
            {
                uc_txtBox_Context.Text = msgbox;
                uc_txtBox_Context.Rtf = richtxtbox_rtf;
                uc_txtBox_Subject.Text = MessageSubject;
            }

        }
        bool IsRe;
        bool IsFr;
        string RepFrm;
        string msgbox;
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
                if ((fsI.Length / 1024 / 1024) > 15)
                {
                    MessageBox.Show("حداکثر حجم مجاز فایل 14 مگابایت می باشد");
                    return null;
                }
                FileStream fs = new FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read);
                byte[] file = new byte[fs.Length];
                fs.Read(file, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                FillFileClass fh = new FillFileClass();
                fh.fileName = dlgOpen.SafeFileName;
                fh.file = file;
                fh.fileSize = (fsI.Length / 1024 / 1024).ToString() + " MB";
                return fh;

            }
            return null;
        }

        DAL.Message.DataSet_Message.SlMessageDataTable dt_m;
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (uc_txtBox_reciver.Text == "")
                return;
            string stl = BLL.authentication.x_.ToString() + DateTime.Now.Year + DateTime.Now.DayOfYear + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            //   dt_mt.AddSlMessageToRow(5,

            int ix = -1;
            if (ffs != null)
                ix = (int)new BLL.Message.csMessage().SendMessageByFile(ffs.fileName, ffs.file);
            foreach (int item in rec)
            {
                dt_m.AddSlMessageRow(BLL.csshamsidate.shamsidate, BLL.authentication.x_,
                    "", uc_txtBox_Subject.Text, "", uc_txtBox_Context.Text, null,
                    item, "", "E", false, null, stl, RepFrm, "",
                    uc_txtBox_reciver.Text, false, ix);
            }
            MessageBox.Show(new BLL.Message.csMessage().UdMessage(dt_m));
            this.Close();

        }
        List<int> rec;
        private void btn_AddReciver_Click(object sender, EventArgs e)
        {
            if (IsRe == false)
            {
                FRM.SendMessage.frmMessageReciver frm = new frmMessageReciver();

                frm.ShowDialog();
                rec = frm.itm;
                uc_txtBox_reciver.Text = frm.listName;
            }

        }
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            foreach (Button item in panel1.Controls.OfType<Button>())
            {
                item.Visible = true;
            }
        }
        private void btn_abadan_Click(object sender, EventArgs e)
        {
            string st = (sender as Button).Name;
            switch (st)
            {
                case "btn_abadan":
                    uc_txtBox_Context.Text += "B-)";

                    break;
                case "btn_akh":
                    uc_txtBox_Context.Text += "#-o";

                    break;
                case "btn_asabani":
                    uc_txtBox_Context.Text += "X(";

                    break;
                case "btn_cheshmak":
                    uc_txtBox_Context.Text += ";-)";

                    break;
                case "btn_cry":
                    uc_txtBox_Context.Text += ":((";

                    break;
                case "btn_khande":
                    uc_txtBox_Context.Text += ":)";

                    break;
                case "btn_labkhand":
                    uc_txtBox_Context.Text += ":-)";

                    break;
                case "btn_like":
                    uc_txtBox_Context.Text += "LIKE";

                    break;
                case "btn_narahat":
                    uc_txtBox_Context.Text += ":-(";

                    break;
            }

        }
        FillFileClass ffs;
        private void btn_File_Click(object sender, EventArgs e)
        {
            ffs = fnGetFile();
            if (ffs != null)
                txt_File.Text = ffs.fileName;
        }
    }
}
