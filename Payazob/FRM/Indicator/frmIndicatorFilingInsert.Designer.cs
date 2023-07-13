
namespace MIS.FRM.Indicator
{
    partial class frmIndicatorFilingInsert
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
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_filing_date = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_insert = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_gen_how_refer_ = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmb_gen_transaction_type_ = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_filing_expert = new ControlLibrary.uc_txtBox(this.components);
            this.txt_reason = new ControlLibrary.uc_txtBox(this.components);
            this.txt_serial = new ControlLibrary.uc_txtBox(this.components);
            this.txt_owner_tel = new ControlLibrary.uc_txtBox(this.components);
            this.txt_owner_name = new ControlLibrary.uc_txtBox(this.components);
            this.txt_building_type = new ControlLibrary.uc_txtBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_filing_date
            // 
            this.txt_filing_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filing_date.Location = new System.Drawing.Point(247, 40);
            this.txt_filing_date.Mask = "0000/00/00";
            this.txt_filing_date.Name = "txt_filing_date";
            this.txt_filing_date.Size = new System.Drawing.Size(85, 21);
            this.txt_filing_date.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(338, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "تاریخ فایلینگ";
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_insert.Location = new System.Drawing.Point(18, 67);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 47);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "ثبت";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_filing_date);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_gen_how_refer_);
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_gen_transaction_type_);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.txt_filing_expert);
            this.splitContainer1.Panel2.Controls.Add(this.txt_reason);
            this.splitContainer1.Panel2.Controls.Add(this.txt_serial);
            this.splitContainer1.Panel2.Controls.Add(this.txt_owner_tel);
            this.splitContainer1.Panel2.Controls.Add(this.txt_owner_name);
            this.splitContainer1.Panel2.Controls.Add(this.txt_building_type);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(734, 197);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 61;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(18, 123);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 47);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "انصراف";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "کارشناس فایلینگ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "علت بایگانی";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "سریال";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "تلفن مالک";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "نام مالک";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "نوع ملک";
            // 
            // cmb_gen_how_refer_
            // 
            this.cmb_gen_how_refer_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_gen_how_refer_.FormattingEnabled = true;
            this.cmb_gen_how_refer_.Location = new System.Drawing.Point(420, 74);
            this.cmb_gen_how_refer_.MaxDropDownItems = 20;
            this.cmb_gen_how_refer_.Name = "cmb_gen_how_refer_";
            this.cmb_gen_how_refer_.Size = new System.Drawing.Size(134, 21);
            this.cmb_gen_how_refer_.TabIndex = 8;
            this.cmb_gen_how_refer_.Tag = "FAITH";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(555, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 55;
            this.label20.Text = "نحوه مراجعه";
            // 
            // cmb_gen_transaction_type_
            // 
            this.cmb_gen_transaction_type_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_gen_transaction_type_.FormattingEnabled = true;
            this.cmb_gen_transaction_type_.Location = new System.Drawing.Point(420, 40);
            this.cmb_gen_transaction_type_.MaxDropDownItems = 20;
            this.cmb_gen_transaction_type_.Name = "cmb_gen_transaction_type_";
            this.cmb_gen_transaction_type_.Size = new System.Drawing.Size(134, 21);
            this.cmb_gen_transaction_type_.TabIndex = 2;
            this.cmb_gen_transaction_type_.Tag = "FAITH";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "نوع معامله";
            // 
            // txt_filing_expert
            // 
            this.txt_filing_expert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filing_expert.IsInteger = false;
            this.txt_filing_expert.IsNumber = false;
            this.txt_filing_expert.IsTime = false;
            this.txt_filing_expert.Location = new System.Drawing.Point(56, 42);
            this.txt_filing_expert.MaxLength = 50;
            this.txt_filing_expert.Name = "txt_filing_expert";
            this.txt_filing_expert.Size = new System.Drawing.Size(85, 21);
            this.txt_filing_expert.TabIndex = 0;
            this.txt_filing_expert.textWithcomma = null;
            this.txt_filing_expert.textWithoutcomma = null;
            // 
            // txt_reason
            // 
            this.txt_reason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_reason.IsInteger = false;
            this.txt_reason.IsNumber = false;
            this.txt_reason.IsTime = false;
            this.txt_reason.Location = new System.Drawing.Point(55, 137);
            this.txt_reason.MaxLength = 50;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(450, 21);
            this.txt_reason.TabIndex = 0;
            this.txt_reason.textWithcomma = null;
            this.txt_reason.textWithoutcomma = null;
            // 
            // txt_serial
            // 
            this.txt_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_serial.IsInteger = false;
            this.txt_serial.IsNumber = false;
            this.txt_serial.IsTime = false;
            this.txt_serial.Location = new System.Drawing.Point(247, 73);
            this.txt_serial.MaxLength = 50;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(85, 21);
            this.txt_serial.TabIndex = 0;
            this.txt_serial.textWithcomma = null;
            this.txt_serial.textWithoutcomma = null;
            // 
            // txt_owner_tel
            // 
            this.txt_owner_tel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_owner_tel.IsInteger = false;
            this.txt_owner_tel.IsNumber = true;
            this.txt_owner_tel.IsTime = false;
            this.txt_owner_tel.Location = new System.Drawing.Point(56, 109);
            this.txt_owner_tel.MaxLength = 50;
            this.txt_owner_tel.Name = "txt_owner_tel";
            this.txt_owner_tel.Size = new System.Drawing.Size(85, 21);
            this.txt_owner_tel.TabIndex = 0;
            this.txt_owner_tel.Text = "0";
            this.txt_owner_tel.textWithcomma = null;
            this.txt_owner_tel.textWithoutcomma = null;
            // 
            // txt_owner_name
            // 
            this.txt_owner_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_owner_name.IsInteger = false;
            this.txt_owner_name.IsNumber = false;
            this.txt_owner_name.IsTime = false;
            this.txt_owner_name.Location = new System.Drawing.Point(247, 110);
            this.txt_owner_name.MaxLength = 50;
            this.txt_owner_name.Name = "txt_owner_name";
            this.txt_owner_name.Size = new System.Drawing.Size(85, 21);
            this.txt_owner_name.TabIndex = 0;
            this.txt_owner_name.textWithcomma = null;
            this.txt_owner_name.textWithoutcomma = null;
            // 
            // txt_building_type
            // 
            this.txt_building_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_building_type.IsInteger = false;
            this.txt_building_type.IsNumber = false;
            this.txt_building_type.IsTime = false;
            this.txt_building_type.Location = new System.Drawing.Point(420, 110);
            this.txt_building_type.MaxLength = 50;
            this.txt_building_type.Name = "txt_building_type";
            this.txt_building_type.Size = new System.Drawing.Size(85, 21);
            this.txt_building_type.TabIndex = 0;
            this.txt_building_type.textWithcomma = null;
            this.txt_building_type.textWithoutcomma = null;
            // 
            // frmIndicatorFilingInsert
            // 
            this.AcceptButton = this.btn_insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(734, 197);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIndicatorFilingInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.MaskedTextBox txt_filing_date;
        private ControlLibrary.uc_txtBox txt_building_type;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_gen_how_refer_;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmb_gen_transaction_type_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ControlLibrary.uc_txtBox txt_filing_expert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private ControlLibrary.uc_txtBox txt_reason;
        private ControlLibrary.uc_txtBox txt_serial;
        private ControlLibrary.uc_txtBox txt_owner_tel;
        private ControlLibrary.uc_txtBox txt_owner_name;
    }
}