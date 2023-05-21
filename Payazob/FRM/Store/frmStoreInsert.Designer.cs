
namespace MIS.FRM.Store
{
    partial class frmStoreInsert
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
            this.cmb_xCustomer_ = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_xCustomerTitle = new ControlLibrary.uc_txtBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_xDate = new System.Windows.Forms.MaskedTextBox();
            this.cmb_xSellerUser_ = new System.Windows.Forms.ComboBox();
            this.cmb_xGenStatus_ = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_xIntroduced = new ControlLibrary.uc_txtBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_xCustomer_
            // 
            this.cmb_xCustomer_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_xCustomer_.FormattingEnabled = true;
            this.cmb_xCustomer_.Location = new System.Drawing.Point(211, 12);
            this.cmb_xCustomer_.MaxDropDownItems = 20;
            this.cmb_xCustomer_.Name = "cmb_xCustomer_";
            this.cmb_xCustomer_.Size = new System.Drawing.Size(107, 21);
            this.cmb_xCustomer_.TabIndex = 1;
            this.cmb_xCustomer_.Tag = "FAITH";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(324, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 55;
            this.label20.Text = "مشتری";
            // 
            // txt_xCustomerTitle
            // 
            this.txt_xCustomerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xCustomerTitle.IsInteger = false;
            this.txt_xCustomerTitle.IsNumber = false;
            this.txt_xCustomerTitle.IsTime = false;
            this.txt_xCustomerTitle.Location = new System.Drawing.Point(23, 14);
            this.txt_xCustomerTitle.Name = "txt_xCustomerTitle";
            this.txt_xCustomerTitle.Size = new System.Drawing.Size(107, 21);
            this.txt_xCustomerTitle.TabIndex = 2;
            this.txt_xCustomerTitle.textWithcomma = null;
            this.txt_xCustomerTitle.textWithoutcomma = null;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "عنوان مشتری";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(18, 82);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 47);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "انصراف";
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
            this.splitContainer1.Panel2.Controls.Add(this.txt_xDate);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_xSellerUser_);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_xGenStatus_);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_xCustomer_);
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xIntroduced);
            this.splitContainer1.Panel2.Controls.Add(this.txt_xCustomerTitle);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(731, 135);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_insert.Location = new System.Drawing.Point(18, 26);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 47);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "ثبت";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_xDate
            // 
            this.txt_xDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xDate.Location = new System.Drawing.Point(462, 12);
            this.txt_xDate.Mask = "0000/00/00";
            this.txt_xDate.Name = "txt_xDate";
            this.txt_xDate.Size = new System.Drawing.Size(66, 21);
            this.txt_xDate.TabIndex = 0;
            // 
            // cmb_xSellerUser_
            // 
            this.cmb_xSellerUser_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_xSellerUser_.FormattingEnabled = true;
            this.cmb_xSellerUser_.Location = new System.Drawing.Point(421, 44);
            this.cmb_xSellerUser_.MaxDropDownItems = 20;
            this.cmb_xSellerUser_.Name = "cmb_xSellerUser_";
            this.cmb_xSellerUser_.Size = new System.Drawing.Size(107, 21);
            this.cmb_xSellerUser_.TabIndex = 8;
            this.cmb_xSellerUser_.Tag = "FAITH";
            // 
            // cmb_xGenStatus_
            // 
            this.cmb_xGenStatus_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_xGenStatus_.FormattingEnabled = true;
            this.cmb_xGenStatus_.Location = new System.Drawing.Point(23, 44);
            this.cmb_xGenStatus_.MaxDropDownItems = 20;
            this.cmb_xGenStatus_.Name = "cmb_xGenStatus_";
            this.cmb_xGenStatus_.Size = new System.Drawing.Size(107, 21);
            this.cmb_xGenStatus_.TabIndex = 10;
            this.cmb_xGenStatus_.Tag = "FAITH";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "کارشناس فروش";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "وضعیت";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "معرف";
            // 
            // txt_xIntroduced
            // 
            this.txt_xIntroduced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xIntroduced.IsInteger = false;
            this.txt_xIntroduced.IsNumber = false;
            this.txt_xIntroduced.IsTime = false;
            this.txt_xIntroduced.Location = new System.Drawing.Point(211, 45);
            this.txt_xIntroduced.Name = "txt_xIntroduced";
            this.txt_xIntroduced.Size = new System.Drawing.Size(107, 21);
            this.txt_xIntroduced.TabIndex = 9;
            this.txt_xIntroduced.textWithcomma = null;
            this.txt_xIntroduced.textWithoutcomma = null;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(534, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "تاریخ";
            // 
            // frmStoreInsert
            // 
            this.AcceptButton = this.btn_insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(731, 135);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStoreInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_xCustomer_;
        private System.Windows.Forms.Label label20;
        private ControlLibrary.uc_txtBox txt_xCustomerTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.MaskedTextBox txt_xDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ComboBox cmb_xSellerUser_;
        private System.Windows.Forms.ComboBox cmb_xGenStatus_;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private ControlLibrary.uc_txtBox txt_xIntroduced;
    }
}