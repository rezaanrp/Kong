namespace MIS.FRM.Contractor
{
    partial class frmContractorNew
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel_Pub = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_xAddress = new ControlLibrary.uc_txtBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_xGenJob_ = new System.Windows.Forms.ComboBox();
            this.txt_xFatherName = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xFamily = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xZone = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xTel = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xMobile = new ControlLibrary.uc_txtBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txt_xNationalCode = new ControlLibrary.uc_txtBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_xName = new ControlLibrary.uc_txtBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Pub.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Beige;
            this.splitContainer1.Panel1.Controls.Add(this.btn_insert);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Cancel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Pub);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(716, 185);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.TabIndex = 114;
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_insert.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btn_insert.Location = new System.Drawing.Point(7, 74);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 47);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "ثبت";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.Btn_insert_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btn_Cancel.Location = new System.Drawing.Point(7, 130);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 47);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "انصراف";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // panel_Pub
            // 
            this.panel_Pub.Controls.Add(this.label7);
            this.panel_Pub.Controls.Add(this.txt_xAddress);
            this.panel_Pub.Controls.Add(this.label3);
            this.panel_Pub.Controls.Add(this.cmb_xGenJob_);
            this.panel_Pub.Controls.Add(this.txt_xFatherName);
            this.panel_Pub.Controls.Add(this.txt_xFamily);
            this.panel_Pub.Controls.Add(this.txt_xZone);
            this.panel_Pub.Controls.Add(this.txt_xTel);
            this.panel_Pub.Controls.Add(this.txt_xMobile);
            this.panel_Pub.Controls.Add(this.label5);
            this.panel_Pub.Controls.Add(this.txt_xNationalCode);
            this.panel_Pub.Controls.Add(this.label4);
            this.panel_Pub.Controls.Add(this.txt_xName);
            this.panel_Pub.Controls.Add(this.label2);
            this.panel_Pub.Controls.Add(this.label12);
            this.panel_Pub.Controls.Add(this.label1);
            this.panel_Pub.Controls.Add(this.label6);
            this.panel_Pub.Controls.Add(this.label8);
            this.panel_Pub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Pub.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel_Pub.Location = new System.Drawing.Point(0, 0);
            this.panel_Pub.Name = "panel_Pub";
            this.panel_Pub.Size = new System.Drawing.Size(627, 185);
            this.panel_Pub.TabIndex = 0;
            this.panel_Pub.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Pub_Paint);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 212;
            this.label7.Text = "ادرس";
            // 
            // txt_xAddress
            // 
            this.txt_xAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xAddress.IsInteger = false;
            this.txt_xAddress.IsNumber = false;
            this.txt_xAddress.IsTime = false;
            this.txt_xAddress.Location = new System.Drawing.Point(39, 108);
            this.txt_xAddress.Multiline = true;
            this.txt_xAddress.Name = "txt_xAddress";
            this.txt_xAddress.Size = new System.Drawing.Size(512, 69);
            this.txt_xAddress.TabIndex = 8;
            this.txt_xAddress.textWithcomma = null;
            this.txt_xAddress.textWithoutcomma = null;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 203;
            this.label3.Text = "حوزه فعالیت";
            // 
            // cmb_xGenJob_
            // 
            this.cmb_xGenJob_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_xGenJob_.FormattingEnabled = true;
            this.cmb_xGenJob_.Location = new System.Drawing.Point(216, 44);
            this.cmb_xGenJob_.MaxDropDownItems = 20;
            this.cmb_xGenJob_.Name = "cmb_xGenJob_";
            this.cmb_xGenJob_.Size = new System.Drawing.Size(128, 21);
            this.cmb_xGenJob_.TabIndex = 4;
            // 
            // txt_xFatherName
            // 
            this.txt_xFatherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xFatherName.IsInteger = false;
            this.txt_xFatherName.IsNumber = false;
            this.txt_xFatherName.IsTime = false;
            this.txt_xFatherName.Location = new System.Drawing.Point(39, 13);
            this.txt_xFatherName.Name = "txt_xFatherName";
            this.txt_xFatherName.Size = new System.Drawing.Size(128, 21);
            this.txt_xFatherName.TabIndex = 2;
            this.txt_xFatherName.textWithcomma = null;
            this.txt_xFatherName.textWithoutcomma = null;
            // 
            // txt_xFamily
            // 
            this.txt_xFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xFamily.IsInteger = false;
            this.txt_xFamily.IsNumber = false;
            this.txt_xFamily.IsTime = false;
            this.txt_xFamily.Location = new System.Drawing.Point(216, 13);
            this.txt_xFamily.Name = "txt_xFamily";
            this.txt_xFamily.Size = new System.Drawing.Size(128, 21);
            this.txt_xFamily.TabIndex = 1;
            this.txt_xFamily.textWithcomma = null;
            this.txt_xFamily.textWithoutcomma = null;
            // 
            // txt_xZone
            // 
            this.txt_xZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xZone.IsInteger = false;
            this.txt_xZone.IsNumber = true;
            this.txt_xZone.IsTime = false;
            this.txt_xZone.Location = new System.Drawing.Point(120, 75);
            this.txt_xZone.MaxLength = 2;
            this.txt_xZone.Name = "txt_xZone";
            this.txt_xZone.Size = new System.Drawing.Size(47, 21);
            this.txt_xZone.TabIndex = 7;
            this.txt_xZone.Text = "0";
            this.txt_xZone.textWithcomma = null;
            this.txt_xZone.textWithoutcomma = null;
            // 
            // txt_xTel
            // 
            this.txt_xTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xTel.IsInteger = false;
            this.txt_xTel.IsNumber = true;
            this.txt_xTel.IsTime = false;
            this.txt_xTel.Location = new System.Drawing.Point(216, 74);
            this.txt_xTel.MaxLength = 11;
            this.txt_xTel.Name = "txt_xTel";
            this.txt_xTel.Size = new System.Drawing.Size(128, 21);
            this.txt_xTel.TabIndex = 6;
            this.txt_xTel.Text = "0";
            this.txt_xTel.textWithcomma = null;
            this.txt_xTel.textWithoutcomma = null;
            this.txt_xTel.TextChanged += new System.EventHandler(this.txt_Form_TextChanged);
            // 
            // txt_xMobile
            // 
            this.txt_xMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xMobile.IsInteger = false;
            this.txt_xMobile.IsNumber = true;
            this.txt_xMobile.IsTime = false;
            this.txt_xMobile.Location = new System.Drawing.Point(423, 74);
            this.txt_xMobile.MaxLength = 11;
            this.txt_xMobile.Name = "txt_xMobile";
            this.txt_xMobile.Size = new System.Drawing.Size(128, 21);
            this.txt_xMobile.TabIndex = 5;
            this.txt_xMobile.Text = "0";
            this.txt_xMobile.textWithcomma = null;
            this.txt_xMobile.textWithoutcomma = null;
            this.txt_xMobile.TextChanged += new System.EventHandler(this.txt_Form_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 224;
            this.label5.Text = "منطقه";
            // 
            // txt_xNationalCode
            // 
            this.txt_xNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xNationalCode.IsInteger = false;
            this.txt_xNationalCode.IsNumber = true;
            this.txt_xNationalCode.IsTime = false;
            this.txt_xNationalCode.Location = new System.Drawing.Point(423, 44);
            this.txt_xNationalCode.MaxLength = 10;
            this.txt_xNationalCode.Name = "txt_xNationalCode";
            this.txt_xNationalCode.Size = new System.Drawing.Size(128, 21);
            this.txt_xNationalCode.TabIndex = 3;
            this.txt_xNationalCode.Text = "0";
            this.txt_xNationalCode.textWithcomma = null;
            this.txt_xNationalCode.textWithoutcomma = null;
            this.txt_xNationalCode.TextChanged += new System.EventHandler(this.txt_Form_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 224;
            this.label4.Text = "تلفن";
            // 
            // txt_xName
            // 
            this.txt_xName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xName.IsInteger = false;
            this.txt_xName.IsNumber = false;
            this.txt_xName.IsTime = false;
            this.txt_xName.Location = new System.Drawing.Point(423, 13);
            this.txt_xName.Name = "txt_xName";
            this.txt_xName.Size = new System.Drawing.Size(128, 21);
            this.txt_xName.TabIndex = 0;
            this.txt_xName.textWithcomma = null;
            this.txt_xName.textWithoutcomma = null;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 224;
            this.label2.Text = "همراه";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 224;
            this.label12.Text = "نام پدر";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 224;
            this.label1.Text = "شماره ملی";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 224;
            this.label6.Text = "نام خانوادگی";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 224;
            this.label8.Text = "نام";
            // 
            // frmContractorNew
            // 
            this.AcceptButton = this.btn_insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(716, 185);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmContractorNew";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmContractorNew_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Pub.ResumeLayout(false);
            this.panel_Pub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel_Pub;
        private System.Windows.Forms.Label label7;
        private ControlLibrary.uc_txtBox txt_xAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_xGenJob_;
        private ControlLibrary.uc_txtBox txt_xFatherName;
        private ControlLibrary.uc_txtBox txt_xFamily;
        private ControlLibrary.uc_txtBox txt_xZone;
        private ControlLibrary.uc_txtBox txt_xTel;
        private ControlLibrary.uc_txtBox txt_xMobile;
        private System.Windows.Forms.Label label5;
        private ControlLibrary.uc_txtBox txt_xNationalCode;
        private System.Windows.Forms.Label label4;
        private ControlLibrary.uc_txtBox txt_xName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}