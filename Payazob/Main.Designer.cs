namespace MIS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.btn_AccessRights = new System.Windows.Forms.Button();
            this.btn_EditObjectGroup = new System.Windows.Forms.Button();
            this.btn_ReportMan = new System.Windows.Forms.Button();
            this.btn_frmManager = new System.Windows.Forms.Button();
            this.btn_workYear = new System.Windows.Forms.Button();
            this.pnl_MailBox = new System.Windows.Forms.Panel();
            this.btn_MailBox = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.uc_Poem1 = new ControlLibrary.uc_Poem();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_MailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_exit);
            this.splitContainer1.Panel1.Controls.Add(this.btn_return);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ChangePass);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AccessRights);
            this.splitContainer1.Panel1.Controls.Add(this.btn_EditObjectGroup);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ReportMan);
            this.splitContainer1.Panel1.Controls.Add(this.btn_frmManager);
            this.splitContainer1.Panel1.Controls.Add(this.btn_workYear);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_MailBox);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(968, 461);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 88);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Azure;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::MIS.Properties.Resources.exit;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(0, 308);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(145, 36);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Azure;
            this.btn_return.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Image = global::MIS.Properties.Resources.edit_undo;
            this.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_return.Location = new System.Drawing.Point(0, 272);
            this.btn_return.Margin = new System.Windows.Forms.Padding(0);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(145, 36);
            this.btn_return.TabIndex = 7;
            this.btn_return.Text = "بازگشت";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Visible = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.BackColor = System.Drawing.Color.Azure;
            this.btn_ChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePass.Image = global::MIS.Properties.Resources.gnome_lockscreen1;
            this.btn_ChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChangePass.Location = new System.Drawing.Point(0, 236);
            this.btn_ChangePass.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(145, 36);
            this.btn_ChangePass.TabIndex = 6;
            this.btn_ChangePass.Text = "تغییر رمز عبور";
            this.btn_ChangePass.UseVisualStyleBackColor = false;
            this.btn_ChangePass.Visible = false;
            this.btn_ChangePass.Click += new System.EventHandler(this.tsmi_ChangePass_Click);
            // 
            // btn_AccessRights
            // 
            this.btn_AccessRights.BackColor = System.Drawing.Color.Azure;
            this.btn_AccessRights.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AccessRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccessRights.Image = global::MIS.Properties.Resources.attention;
            this.btn_AccessRights.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AccessRights.Location = new System.Drawing.Point(0, 200);
            this.btn_AccessRights.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AccessRights.Name = "btn_AccessRights";
            this.btn_AccessRights.Size = new System.Drawing.Size(145, 36);
            this.btn_AccessRights.TabIndex = 5;
            this.btn_AccessRights.Text = "دسترسی";
            this.btn_AccessRights.UseVisualStyleBackColor = false;
            this.btn_AccessRights.Visible = false;
            this.btn_AccessRights.Click += new System.EventHandler(this.btna_AccessRights_Click);
            // 
            // btn_EditObjectGroup
            // 
            this.btn_EditObjectGroup.BackColor = System.Drawing.Color.Azure;
            this.btn_EditObjectGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EditObjectGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditObjectGroup.Image = global::MIS.Properties.Resources.tree_diagramm;
            this.btn_EditObjectGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditObjectGroup.Location = new System.Drawing.Point(0, 164);
            this.btn_EditObjectGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btn_EditObjectGroup.Name = "btn_EditObjectGroup";
            this.btn_EditObjectGroup.Size = new System.Drawing.Size(145, 36);
            this.btn_EditObjectGroup.TabIndex = 4;
            this.btn_EditObjectGroup.Text = "درخت دسترسی";
            this.btn_EditObjectGroup.UseVisualStyleBackColor = false;
            this.btn_EditObjectGroup.Visible = false;
            this.btn_EditObjectGroup.Click += new System.EventHandler(this.btn_EditObjectGroup_Click);
            // 
            // btn_ReportMan
            // 
            this.btn_ReportMan.BackColor = System.Drawing.Color.Azure;
            this.btn_ReportMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ReportMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReportMan.Image = global::MIS.Properties.Resources.lists1;
            this.btn_ReportMan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ReportMan.Location = new System.Drawing.Point(0, 128);
            this.btn_ReportMan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ReportMan.Name = "btn_ReportMan";
            this.btn_ReportMan.Size = new System.Drawing.Size(145, 36);
            this.btn_ReportMan.TabIndex = 3;
            this.btn_ReportMan.Text = "گزارش وضعیت";
            this.btn_ReportMan.UseVisualStyleBackColor = false;
            this.btn_ReportMan.Visible = false;
            this.btn_ReportMan.Click += new System.EventHandler(this.btn_ReportMan_Click);
            // 
            // btn_frmManager
            // 
            this.btn_frmManager.BackColor = System.Drawing.Color.Azure;
            this.btn_frmManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_frmManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_frmManager.Image = global::MIS.Properties.Resources.decrease;
            this.btn_frmManager.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_frmManager.Location = new System.Drawing.Point(0, 92);
            this.btn_frmManager.Margin = new System.Windows.Forms.Padding(0);
            this.btn_frmManager.Name = "btn_frmManager";
            this.btn_frmManager.Size = new System.Drawing.Size(145, 36);
            this.btn_frmManager.TabIndex = 2;
            this.btn_frmManager.Text = "گزارش موجودی ";
            this.btn_frmManager.UseVisualStyleBackColor = false;
            this.btn_frmManager.Visible = false;
            this.btn_frmManager.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_workYear
            // 
            this.btn_workYear.BackColor = System.Drawing.Color.Azure;
            this.btn_workYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_workYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_workYear.Image = global::MIS.Properties.Resources.date_32;
            this.btn_workYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_workYear.Location = new System.Drawing.Point(0, 56);
            this.btn_workYear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_workYear.Name = "btn_workYear";
            this.btn_workYear.Size = new System.Drawing.Size(145, 36);
            this.btn_workYear.TabIndex = 1;
            this.btn_workYear.Text = "سال کاری";
            this.btn_workYear.UseVisualStyleBackColor = false;
            this.btn_workYear.Visible = false;
            this.btn_workYear.Click += new System.EventHandler(this.btn_workYear_Click);
            // 
            // pnl_MailBox
            // 
            this.pnl_MailBox.Controls.Add(this.btn_MailBox);
            this.pnl_MailBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MailBox.Location = new System.Drawing.Point(0, 0);
            this.pnl_MailBox.Name = "pnl_MailBox";
            this.pnl_MailBox.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnl_MailBox.Size = new System.Drawing.Size(145, 56);
            this.pnl_MailBox.TabIndex = 0;
            this.pnl_MailBox.Visible = false;
            // 
            // btn_MailBox
            // 
            this.btn_MailBox.BackColor = System.Drawing.Color.Azure;
            this.btn_MailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MailBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MailBox.Image = global::MIS.Properties.Resources.mailbox_1;
            this.btn_MailBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MailBox.Location = new System.Drawing.Point(0, 20);
            this.btn_MailBox.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MailBox.Name = "btn_MailBox";
            this.btn_MailBox.Size = new System.Drawing.Size(145, 36);
            this.btn_MailBox.TabIndex = 0;
            this.btn_MailBox.Text = "صندوق پیام";
            this.btn_MailBox.UseVisualStyleBackColor = false;
            this.btn_MailBox.Click += new System.EventHandler(this.btn_MailBox_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.Black;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.panel1);
            this.splitContainer4.Panel1.Controls.Add(this.treeView1);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer4.Panel2.Controls.Add(this.uc_Poem1);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer4_Panel2_Paint);
            this.splitContainer4.Size = new System.Drawing.Size(818, 461);
            this.splitContainer4.SplitterDistance = 273;
            this.splitContainer4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 25);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MIS.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(29, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.Black;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.ItemHeight = 23;
            this.treeView1.LineColor = System.Drawing.Color.LightBlue;
            this.treeView1.Location = new System.Drawing.Point(0, 20);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(273, 441);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView1_NodeMouseHover);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            this.treeView1.MouseLeave += new System.EventHandler(this.treeView1_MouseLeave);
            this.treeView1.MouseHover += new System.EventHandler(this.treeView1_MouseHover);
            // 
            // uc_Poem1
            // 
            this.uc_Poem1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uc_Poem1.ForeColor = System.Drawing.Color.White;
            this.uc_Poem1.Location = new System.Drawing.Point(0, 431);
            this.uc_Poem1.Name = "uc_Poem1";
            this.uc_Poem1.Size = new System.Drawing.Size(541, 30);
            this.uc_Poem1.TabIndex = 1;
            // 
            // lblMarquee
            // 
            this.lblMarquee.AutoSize = true;
            this.lblMarquee.ForeColor = System.Drawing.Color.White;
            this.lblMarquee.Location = new System.Drawing.Point(12, 4);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(0, 14);
            this.lblMarquee.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbl_Date);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(968, 519);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(781, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(31, 14);
            this.lbl_Date.TabIndex = 10;
            this.lbl_Date.Text = "***";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lblMarquee);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Panel2.DoubleClick += new System.EventHandler(this.splitContainer3_Panel2_DoubleClick);
            this.splitContainer3.Size = new System.Drawing.Size(968, 490);
            this.splitContainer3.SplitterDistance = 461;
            this.splitContainer3.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "نرم افزار مدیریت اطلاعات ";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(99, 22);
            this.tsmi_Exit.Text = "خروج";
            this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(968, 519);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_MailBox.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel pnl_MailBox;
        private System.Windows.Forms.Button btn_MailBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TreeView treeView1;
        private ControlLibrary.uc_Poem uc_Poem1;
        private System.Windows.Forms.Button btn_frmManager;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_EditObjectGroup;
        private System.Windows.Forms.Button btn_AccessRights;
        private System.Windows.Forms.Button btn_ChangePass;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_workYear;
        private System.Windows.Forms.Button btn_ReportMan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Date;
    }
}