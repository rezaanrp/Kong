namespace MIS.FRM.Company
{
    partial class frmCompanyAdd
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_xBusinessNumber = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xSupplyManagerTel = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xSupplyManager = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xRegistrationNumber = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xDirectorFactorTel = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xDirectorFactor = new ControlLibrary.uc_txtBox(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lalalla = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_xAddress = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xComment = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xNationalCode = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xWebsite = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xGradeDate = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xEvaluationPerson = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xGrade = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xZipCode = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xEmail = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xTel = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xFax = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xCompanyName = new ControlLibrary.uc_txtBox(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_insert.Location = new System.Drawing.Point(18, 97);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 47);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "ثبت";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Cancel.Location = new System.Drawing.Point(18, 153);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 47);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "بازگشت";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Plum;
            this.splitContainer1.Panel1.Controls.Add(this.btn_insert);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Cancel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_xBusinessNumber);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xSupplyManagerTel);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xSupplyManager);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xRegistrationNumber);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xDirectorFactorTel);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xDirectorFactor);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.label18);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.lalalla);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xComment);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xNationalCode);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xWebsite);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xGradeDate);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xEvaluationPerson);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xGrade);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xZipCode);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xEmail);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xTel);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xFax);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xCompanyName);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(896, 220);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 61;
            // 
            // txt_xBusinessNumber
            // 
            this.txt_xBusinessNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xBusinessNumber.IsInteger = false;
            this.txt_xBusinessNumber.IsNumber = false;
            this.txt_xBusinessNumber.IsTime = false;
            this.txt_xBusinessNumber.Location = new System.Drawing.Point(411, 12);
            this.txt_xBusinessNumber.Name = "txt_xBusinessNumber";
            this.txt_xBusinessNumber.Size = new System.Drawing.Size(109, 21);
            this.txt_xBusinessNumber.TabIndex = 1;
            this.txt_xBusinessNumber.textWithcomma = null;
            this.txt_xBusinessNumber.textWithoutcomma = null;
            // 
            // txt_xSupplyManagerTel
            // 
            this.txt_xSupplyManagerTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xSupplyManagerTel.IsInteger = false;
            this.txt_xSupplyManagerTel.IsNumber = false;
            this.txt_xSupplyManagerTel.IsTime = false;
            this.txt_xSupplyManagerTel.Location = new System.Drawing.Point(25, 39);
            this.txt_xSupplyManagerTel.Name = "txt_xSupplyManagerTel";
            this.txt_xSupplyManagerTel.Size = new System.Drawing.Size(109, 21);
            this.txt_xSupplyManagerTel.TabIndex = 7;
            this.txt_xSupplyManagerTel.textWithcomma = null;
            this.txt_xSupplyManagerTel.textWithoutcomma = null;
            // 
            // txt_xSupplyManager
            // 
            this.txt_xSupplyManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xSupplyManager.IsInteger = false;
            this.txt_xSupplyManager.IsNumber = false;
            this.txt_xSupplyManager.IsTime = false;
            this.txt_xSupplyManager.Location = new System.Drawing.Point(225, 39);
            this.txt_xSupplyManager.Name = "txt_xSupplyManager";
            this.txt_xSupplyManager.Size = new System.Drawing.Size(109, 21);
            this.txt_xSupplyManager.TabIndex = 6;
            this.txt_xSupplyManager.textWithcomma = null;
            this.txt_xSupplyManager.textWithoutcomma = null;
            // 
            // txt_xRegistrationNumber
            // 
            this.txt_xRegistrationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xRegistrationNumber.IsInteger = false;
            this.txt_xRegistrationNumber.IsNumber = false;
            this.txt_xRegistrationNumber.IsTime = false;
            this.txt_xRegistrationNumber.Location = new System.Drawing.Point(25, 13);
            this.txt_xRegistrationNumber.Name = "txt_xRegistrationNumber";
            this.txt_xRegistrationNumber.Size = new System.Drawing.Size(109, 21);
            this.txt_xRegistrationNumber.TabIndex = 3;
            this.txt_xRegistrationNumber.textWithcomma = null;
            this.txt_xRegistrationNumber.textWithoutcomma = null;
            // 
            // txt_xDirectorFactorTel
            // 
            this.txt_xDirectorFactorTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xDirectorFactorTel.IsInteger = false;
            this.txt_xDirectorFactorTel.IsNumber = false;
            this.txt_xDirectorFactorTel.IsTime = false;
            this.txt_xDirectorFactorTel.Location = new System.Drawing.Point(411, 39);
            this.txt_xDirectorFactorTel.Name = "txt_xDirectorFactorTel";
            this.txt_xDirectorFactorTel.Size = new System.Drawing.Size(109, 21);
            this.txt_xDirectorFactorTel.TabIndex = 5;
            this.txt_xDirectorFactorTel.textWithcomma = null;
            this.txt_xDirectorFactorTel.textWithoutcomma = null;
            // 
            // txt_xDirectorFactor
            // 
            this.txt_xDirectorFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xDirectorFactor.IsInteger = false;
            this.txt_xDirectorFactor.IsNumber = false;
            this.txt_xDirectorFactor.IsTime = false;
            this.txt_xDirectorFactor.Location = new System.Drawing.Point(610, 39);
            this.txt_xDirectorFactor.Name = "txt_xDirectorFactor";
            this.txt_xDirectorFactor.Size = new System.Drawing.Size(109, 21);
            this.txt_xDirectorFactor.TabIndex = 4;
            this.txt_xDirectorFactor.textWithcomma = null;
            this.txt_xDirectorFactor.textWithoutcomma = null;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "تلفن مدیر تامین ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "شماره اقتصادی ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "مدیر تامین ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "شماره ثبت ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "تلفن مدیر عامل";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "ادرس";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(723, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "توضیحات ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = " مدیر عامل";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "شماره ملی";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(141, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 73;
            this.label15.Text = "سایت";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(341, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 69;
            this.label17.Text = "تاریخ ارزیابی";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(526, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 72;
            this.label18.Text = "مسئول ارزیابی";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(726, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 71;
            this.label16.Text = "امتیاز";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(726, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 70;
            this.label14.Text = "کد پستی";
            // 
            // lalalla
            // 
            this.lalalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lalalla.AutoSize = true;
            this.lalalla.Location = new System.Drawing.Point(341, 71);
            this.lalalla.Name = "lalalla";
            this.lalalla.Size = new System.Drawing.Size(32, 13);
            this.lalalla.TabIndex = 74;
            this.lalalla.Text = "ایمیل";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(723, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "تلفن ثابت ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "فاکس";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "نام شرکت";
            // 
            // txt_xAddress
            // 
            this.txt_xAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xAddress.IsInteger = false;
            this.txt_xAddress.IsNumber = false;
            this.txt_xAddress.IsTime = false;
            this.txt_xAddress.Location = new System.Drawing.Point(25, 124);
            this.txt_xAddress.Multiline = true;
            this.txt_xAddress.Name = "txt_xAddress";
            this.txt_xAddress.Size = new System.Drawing.Size(495, 21);
            this.txt_xAddress.TabIndex = 16;
            this.txt_xAddress.textWithcomma = null;
            this.txt_xAddress.textWithoutcomma = null;
            // 
            // txt_xComment
            // 
            this.txt_xComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xComment.IsInteger = false;
            this.txt_xComment.IsNumber = false;
            this.txt_xComment.IsTime = false;
            this.txt_xComment.Location = new System.Drawing.Point(25, 153);
            this.txt_xComment.Multiline = true;
            this.txt_xComment.Name = "txt_xComment";
            this.txt_xComment.Size = new System.Drawing.Size(694, 21);
            this.txt_xComment.TabIndex = 17;
            this.txt_xComment.textWithcomma = null;
            this.txt_xComment.textWithoutcomma = null;
            // 
            // txt_xNationalCode
            // 
            this.txt_xNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xNationalCode.IsInteger = false;
            this.txt_xNationalCode.IsNumber = false;
            this.txt_xNationalCode.IsTime = false;
            this.txt_xNationalCode.Location = new System.Drawing.Point(225, 13);
            this.txt_xNationalCode.Name = "txt_xNationalCode";
            this.txt_xNationalCode.Size = new System.Drawing.Size(109, 21);
            this.txt_xNationalCode.TabIndex = 2;
            this.txt_xNationalCode.textWithcomma = null;
            this.txt_xNationalCode.textWithoutcomma = null;
            // 
            // txt_xWebsite
            // 
            this.txt_xWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xWebsite.IsInteger = false;
            this.txt_xWebsite.IsNumber = false;
            this.txt_xWebsite.IsTime = false;
            this.txt_xWebsite.Location = new System.Drawing.Point(25, 68);
            this.txt_xWebsite.Name = "txt_xWebsite";
            this.txt_xWebsite.Size = new System.Drawing.Size(109, 21);
            this.txt_xWebsite.TabIndex = 11;
            this.txt_xWebsite.textWithcomma = null;
            this.txt_xWebsite.textWithoutcomma = null;
            // 
            // txt_xGradeDate
            // 
            this.txt_xGradeDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xGradeDate.IsInteger = false;
            this.txt_xGradeDate.IsNumber = false;
            this.txt_xGradeDate.IsTime = false;
            this.txt_xGradeDate.Location = new System.Drawing.Point(225, 94);
            this.txt_xGradeDate.Name = "txt_xGradeDate";
            this.txt_xGradeDate.Size = new System.Drawing.Size(109, 21);
            this.txt_xGradeDate.TabIndex = 14;
            this.txt_xGradeDate.textWithcomma = null;
            this.txt_xGradeDate.textWithoutcomma = null;
            // 
            // txt_xEvaluationPerson
            // 
            this.txt_xEvaluationPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xEvaluationPerson.IsInteger = false;
            this.txt_xEvaluationPerson.IsNumber = false;
            this.txt_xEvaluationPerson.IsTime = false;
            this.txt_xEvaluationPerson.Location = new System.Drawing.Point(411, 94);
            this.txt_xEvaluationPerson.Name = "txt_xEvaluationPerson";
            this.txt_xEvaluationPerson.Size = new System.Drawing.Size(109, 21);
            this.txt_xEvaluationPerson.TabIndex = 13;
            this.txt_xEvaluationPerson.textWithcomma = null;
            this.txt_xEvaluationPerson.textWithoutcomma = null;
            // 
            // txt_xGrade
            // 
            this.txt_xGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xGrade.IsInteger = false;
            this.txt_xGrade.IsNumber = false;
            this.txt_xGrade.IsTime = false;
            this.txt_xGrade.Location = new System.Drawing.Point(610, 94);
            this.txt_xGrade.Name = "txt_xGrade";
            this.txt_xGrade.Size = new System.Drawing.Size(109, 21);
            this.txt_xGrade.TabIndex = 12;
            this.txt_xGrade.textWithcomma = null;
            this.txt_xGrade.textWithoutcomma = null;
            // 
            // txt_xZipCode
            // 
            this.txt_xZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xZipCode.IsInteger = false;
            this.txt_xZipCode.IsNumber = false;
            this.txt_xZipCode.IsTime = false;
            this.txt_xZipCode.Location = new System.Drawing.Point(610, 124);
            this.txt_xZipCode.Name = "txt_xZipCode";
            this.txt_xZipCode.Size = new System.Drawing.Size(109, 21);
            this.txt_xZipCode.TabIndex = 15;
            this.txt_xZipCode.textWithcomma = null;
            this.txt_xZipCode.textWithoutcomma = null;
            // 
            // txt_xEmail
            // 
            this.txt_xEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xEmail.IsInteger = false;
            this.txt_xEmail.IsNumber = false;
            this.txt_xEmail.IsTime = false;
            this.txt_xEmail.Location = new System.Drawing.Point(225, 67);
            this.txt_xEmail.Name = "txt_xEmail";
            this.txt_xEmail.Size = new System.Drawing.Size(109, 21);
            this.txt_xEmail.TabIndex = 10;
            this.txt_xEmail.textWithcomma = null;
            this.txt_xEmail.textWithoutcomma = null;
            // 
            // txt_xTel
            // 
            this.txt_xTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xTel.IsInteger = false;
            this.txt_xTel.IsNumber = false;
            this.txt_xTel.IsTime = false;
            this.txt_xTel.Location = new System.Drawing.Point(610, 67);
            this.txt_xTel.Name = "txt_xTel";
            this.txt_xTel.Size = new System.Drawing.Size(109, 21);
            this.txt_xTel.TabIndex = 8;
            this.txt_xTel.textWithcomma = null;
            this.txt_xTel.textWithoutcomma = null;
            // 
            // txt_xFax
            // 
            this.txt_xFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xFax.IsInteger = false;
            this.txt_xFax.IsNumber = false;
            this.txt_xFax.IsTime = false;
            this.txt_xFax.Location = new System.Drawing.Point(411, 67);
            this.txt_xFax.Name = "txt_xFax";
            this.txt_xFax.Size = new System.Drawing.Size(109, 21);
            this.txt_xFax.TabIndex = 9;
            this.txt_xFax.textWithcomma = null;
            this.txt_xFax.textWithoutcomma = null;
            // 
            // txt_xCompanyName
            // 
            this.txt_xCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xCompanyName.IsInteger = false;
            this.txt_xCompanyName.IsNumber = false;
            this.txt_xCompanyName.IsTime = false;
            this.txt_xCompanyName.Location = new System.Drawing.Point(610, 12);
            this.txt_xCompanyName.Name = "txt_xCompanyName";
            this.txt_xCompanyName.Size = new System.Drawing.Size(109, 21);
            this.txt_xCompanyName.TabIndex = 0;
            this.txt_xCompanyName.textWithcomma = null;
            this.txt_xCompanyName.textWithoutcomma = null;
            // 
            // frmCompanyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 220);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCompanyAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCompanyAdd";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ControlLibrary.uc_txtBox txt_xBusinessNumber;
        private ControlLibrary.uc_txtBox txt_xSupplyManagerTel;
        private ControlLibrary.uc_txtBox txt_xSupplyManager;
        private ControlLibrary.uc_txtBox txt_xRegistrationNumber;
        private ControlLibrary.uc_txtBox txt_xDirectorFactorTel;
        private ControlLibrary.uc_txtBox txt_xDirectorFactor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lalalla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private ControlLibrary.uc_txtBox txt_xAddress;
        private ControlLibrary.uc_txtBox txt_xComment;
        private ControlLibrary.uc_txtBox txt_xNationalCode;
        private ControlLibrary.uc_txtBox txt_xWebsite;
        private ControlLibrary.uc_txtBox txt_xGradeDate;
        private ControlLibrary.uc_txtBox txt_xEvaluationPerson;
        private ControlLibrary.uc_txtBox txt_xGrade;
        private ControlLibrary.uc_txtBox txt_xZipCode;
        private ControlLibrary.uc_txtBox txt_xEmail;
        private ControlLibrary.uc_txtBox txt_xTel;
        private ControlLibrary.uc_txtBox txt_xFax;
        private ControlLibrary.uc_txtBox txt_xCompanyName;
    }
}