﻿namespace MIS.FRM.Customer
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ucStatusBar1 = new ControlLibrary.ucStatusBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uc_txtBox1 = new ControlLibrary.uc_txtBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xBirthDay = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.cmb_Section = new System.Windows.Forms.ComboBox();
            this.cmb_Sex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lalalla = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_txtBox_xAddress = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_xNationalCode = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_xIdentity = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_FatherName = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_xEmail = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_xTel = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_xMob = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_xFamily = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBoxName = new ControlLibrary.uc_txtBox(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton_Add = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucStatusBar1
            // 
            this.ucStatusBar1.DgvCell = null;
            this.ucStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucStatusBar1.Location = new System.Drawing.Point(0, 31);
            this.ucStatusBar1.Name = "ucStatusBar1";
            this.ucStatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucStatusBar1.Size = new System.Drawing.Size(897, 24);
            this.ucStatusBar1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(69, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // uc_txtBox1
            // 
            this.uc_txtBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBox1.IsInteger = false;
            this.uc_txtBox1.IsNumber = false;
            this.uc_txtBox1.IsTime = false;
            this.uc_txtBox1.Location = new System.Drawing.Point(95, 14);
            this.uc_txtBox1.Name = "uc_txtBox1";
            this.uc_txtBox1.Size = new System.Drawing.Size(168, 21);
            this.uc_txtBox1.TabIndex = 8;
            this.uc_txtBox1.textWithcomma = null;
            this.uc_txtBox1.textWithoutcomma = null;
            this.uc_txtBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uc_txtBox1_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.uc_txtBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 41);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_Section);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_Sex);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.lalalla);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBox_xAddress);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBox_xNationalCode);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBox_xIdentity);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBox_FatherName);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBox_xEmail);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBox_xTel);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBox_xMob);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBox_xFamily);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBoxName);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(897, 402);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xBirthDay});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(897, 215);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            // 
            // xBirthDay
            // 
            this.xBirthDay.DataPropertyName = "xBirthDay";
            this.xBirthDay.HeaderText = "تاریخ تولد";
            this.xBirthDay.Mask = "0000/00/00";
            this.xBirthDay.Name = "xBirthDay";
            this.xBirthDay.Width = 80;
            // 
            // cmb_Section
            // 
            this.cmb_Section.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Section.FormattingEnabled = true;
            this.cmb_Section.Location = new System.Drawing.Point(432, 118);
            this.cmb_Section.MaxDropDownItems = 20;
            this.cmb_Section.Name = "cmb_Section";
            this.cmb_Section.Size = new System.Drawing.Size(135, 21);
            this.cmb_Section.TabIndex = 33;
            // 
            // cmb_Sex
            // 
            this.cmb_Sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Sex.FormattingEnabled = true;
            this.cmb_Sex.Location = new System.Drawing.Point(670, 92);
            this.cmb_Sex.MaxDropDownItems = 20;
            this.cmb_Sex.Name = "cmb_Sex";
            this.cmb_Sex.Size = new System.Drawing.Size(130, 21);
            this.cmb_Sex.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "ادرس";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "قسمت";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(806, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "کد ملی";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "جنسیت";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(573, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "شماره شناسنامه";
            // 
            // lalalla
            // 
            this.lalalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lalalla.AutoSize = true;
            this.lalalla.Location = new System.Drawing.Point(806, 124);
            this.lalalla.Name = "lalalla";
            this.lalalla.Size = new System.Drawing.Size(32, 13);
            this.lalalla.TabIndex = 31;
            this.lalalla.Text = "ایمیل";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "نام پدر";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "تلفن ثابت";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "نام خانوادگی";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "تلفن همراه";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "نام";
            // 
            // uc_txtBox_xAddress
            // 
            this.uc_txtBox_xAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_xAddress.IsInteger = false;
            this.uc_txtBox_xAddress.IsNumber = false;
            this.uc_txtBox_xAddress.IsTime = false;
            this.uc_txtBox_xAddress.Location = new System.Drawing.Point(20, 10);
            this.uc_txtBox_xAddress.Multiline = true;
            this.uc_txtBox_xAddress.Name = "uc_txtBox_xAddress";
            this.uc_txtBox_xAddress.Size = new System.Drawing.Size(358, 102);
            this.uc_txtBox_xAddress.TabIndex = 14;
            this.uc_txtBox_xAddress.textWithcomma = null;
            this.uc_txtBox_xAddress.textWithoutcomma = null;
            // 
            // uc_txtBox_xNationalCode
            // 
            this.uc_txtBox_xNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_xNationalCode.IsInteger = false;
            this.uc_txtBox_xNationalCode.IsNumber = false;
            this.uc_txtBox_xNationalCode.IsTime = false;
            this.uc_txtBox_xNationalCode.Location = new System.Drawing.Point(670, 65);
            this.uc_txtBox_xNationalCode.Name = "uc_txtBox_xNationalCode";
            this.uc_txtBox_xNationalCode.Size = new System.Drawing.Size(130, 21);
            this.uc_txtBox_xNationalCode.TabIndex = 15;
            this.uc_txtBox_xNationalCode.textWithcomma = null;
            this.uc_txtBox_xNationalCode.textWithoutcomma = null;
            // 
            // uc_txtBox_xIdentity
            // 
            this.uc_txtBox_xIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_xIdentity.IsInteger = false;
            this.uc_txtBox_xIdentity.IsNumber = false;
            this.uc_txtBox_xIdentity.IsTime = false;
            this.uc_txtBox_xIdentity.Location = new System.Drawing.Point(432, 91);
            this.uc_txtBox_xIdentity.Name = "uc_txtBox_xIdentity";
            this.uc_txtBox_xIdentity.Size = new System.Drawing.Size(135, 21);
            this.uc_txtBox_xIdentity.TabIndex = 13;
            this.uc_txtBox_xIdentity.textWithcomma = null;
            this.uc_txtBox_xIdentity.textWithoutcomma = null;
            // 
            // uc_txtBox_FatherName
            // 
            this.uc_txtBox_FatherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_FatherName.IsInteger = false;
            this.uc_txtBox_FatherName.IsNumber = false;
            this.uc_txtBox_FatherName.IsTime = false;
            this.uc_txtBox_FatherName.Location = new System.Drawing.Point(432, 64);
            this.uc_txtBox_FatherName.Name = "uc_txtBox_FatherName";
            this.uc_txtBox_FatherName.Size = new System.Drawing.Size(135, 21);
            this.uc_txtBox_FatherName.TabIndex = 11;
            this.uc_txtBox_FatherName.textWithcomma = null;
            this.uc_txtBox_FatherName.textWithoutcomma = null;
            // 
            // uc_txtBox_xEmail
            // 
            this.uc_txtBox_xEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_xEmail.IsInteger = false;
            this.uc_txtBox_xEmail.IsNumber = false;
            this.uc_txtBox_xEmail.IsTime = false;
            this.uc_txtBox_xEmail.Location = new System.Drawing.Point(670, 121);
            this.uc_txtBox_xEmail.Name = "uc_txtBox_xEmail";
            this.uc_txtBox_xEmail.Size = new System.Drawing.Size(130, 21);
            this.uc_txtBox_xEmail.TabIndex = 12;
            this.uc_txtBox_xEmail.textWithcomma = null;
            this.uc_txtBox_xEmail.textWithoutcomma = null;
            // 
            // uc_txtBox_xTel
            // 
            this.uc_txtBox_xTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_xTel.IsInteger = false;
            this.uc_txtBox_xTel.IsNumber = false;
            this.uc_txtBox_xTel.IsTime = false;
            this.uc_txtBox_xTel.Location = new System.Drawing.Point(432, 37);
            this.uc_txtBox_xTel.Name = "uc_txtBox_xTel";
            this.uc_txtBox_xTel.Size = new System.Drawing.Size(135, 21);
            this.uc_txtBox_xTel.TabIndex = 19;
            this.uc_txtBox_xTel.textWithcomma = null;
            this.uc_txtBox_xTel.textWithoutcomma = null;
            // 
            // uc_txtBox_xMob
            // 
            this.uc_txtBox_xMob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_xMob.IsInteger = false;
            this.uc_txtBox_xMob.IsNumber = false;
            this.uc_txtBox_xMob.IsTime = false;
            this.uc_txtBox_xMob.Location = new System.Drawing.Point(432, 10);
            this.uc_txtBox_xMob.Name = "uc_txtBox_xMob";
            this.uc_txtBox_xMob.Size = new System.Drawing.Size(135, 21);
            this.uc_txtBox_xMob.TabIndex = 18;
            this.uc_txtBox_xMob.textWithcomma = null;
            this.uc_txtBox_xMob.textWithoutcomma = null;
            // 
            // uc_txtBox_xFamily
            // 
            this.uc_txtBox_xFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_xFamily.IsInteger = false;
            this.uc_txtBox_xFamily.IsNumber = false;
            this.uc_txtBox_xFamily.IsTime = false;
            this.uc_txtBox_xFamily.Location = new System.Drawing.Point(670, 37);
            this.uc_txtBox_xFamily.Name = "uc_txtBox_xFamily";
            this.uc_txtBox_xFamily.Size = new System.Drawing.Size(130, 21);
            this.uc_txtBox_xFamily.TabIndex = 16;
            this.uc_txtBox_xFamily.textWithcomma = null;
            this.uc_txtBox_xFamily.textWithoutcomma = null;
            // 
            // uc_txtBoxName
            // 
            this.uc_txtBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxName.IsInteger = false;
            this.uc_txtBoxName.IsNumber = false;
            this.uc_txtBoxName.IsTime = false;
            this.uc_txtBoxName.Location = new System.Drawing.Point(670, 10);
            this.uc_txtBoxName.Name = "uc_txtBoxName";
            this.uc_txtBoxName.Size = new System.Drawing.Size(130, 21);
            this.uc_txtBoxName.TabIndex = 17;
            this.uc_txtBoxName.textWithcomma = null;
            this.uc_txtBoxName.textWithoutcomma = null;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ucStatusBar1);
            this.splitContainer2.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(897, 461);
            this.splitContainer2.SplitterDistance = 402;
            this.splitContainer2.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton_Add;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton_Add,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(897, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton_Add
            // 
            this.toolStripButton_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Add.Image")));
            this.toolStripButton_Add.Name = "toolStripButton_Add";
            this.toolStripButton_Add.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_Add.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Add.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "EXCEL";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 461);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private ControlLibrary.ucStatusBar ucStatusBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControlLibrary.uc_txtBox uc_txtBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Section;
        private System.Windows.Forms.ComboBox cmb_Sex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lalalla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private ControlLibrary.uc_txtBox uc_txtBox_xAddress;
        private ControlLibrary.uc_txtBox uc_txtBox_xNationalCode;
        private ControlLibrary.uc_txtBox uc_txtBox_xIdentity;
        private ControlLibrary.uc_txtBox uc_txtBox_FatherName;
        private ControlLibrary.uc_txtBox uc_txtBox_xEmail;
        private ControlLibrary.uc_txtBox uc_txtBox_xTel;
        private ControlLibrary.uc_txtBox uc_txtBox_xMob;
        private ControlLibrary.uc_txtBox uc_txtBox_xFamily;
        private ControlLibrary.uc_txtBox uc_txtBoxName;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Add;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private JThomas.Controls.DataGridViewMaskedTextColumn xBirthDay;
    }
}