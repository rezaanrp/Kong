
namespace MIS.FRM.ClientReferral
{
    partial class frmClientReferralSearch
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_xGenResultOfReferral_ = new System.Windows.Forms.ComboBox();
            this.txt_xRequestedGoods = new ControlLibrary.uc_txtBox(this.components);
            this.txt_xTel = new ControlLibrary.uc_txtBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_xClientReferral = new ControlLibrary.uc_txtBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel_Pub = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chb_xClientReferral = new System.Windows.Forms.CheckBox();
            this.chb_xTel = new System.Windows.Forms.CheckBox();
            this.chb_xGenResultOfReferral_ = new System.Windows.Forms.CheckBox();
            this.chb_xRequestedGoods = new System.Windows.Forms.CheckBox();
            this.panel_Pub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 203;
            this.label3.Text = "نتیجه مراجعه";
            // 
            // cmb_xGenResultOfReferral_
            // 
            this.cmb_xGenResultOfReferral_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_xGenResultOfReferral_.Enabled = false;
            this.cmb_xGenResultOfReferral_.FormattingEnabled = true;
            this.cmb_xGenResultOfReferral_.Location = new System.Drawing.Point(47, 58);
            this.cmb_xGenResultOfReferral_.MaxDropDownItems = 20;
            this.cmb_xGenResultOfReferral_.Name = "cmb_xGenResultOfReferral_";
            this.cmb_xGenResultOfReferral_.Size = new System.Drawing.Size(128, 21);
            this.cmb_xGenResultOfReferral_.TabIndex = 4;
            // 
            // txt_xRequestedGoods
            // 
            this.txt_xRequestedGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xRequestedGoods.Enabled = false;
            this.txt_xRequestedGoods.IsInteger = false;
            this.txt_xRequestedGoods.IsNumber = false;
            this.txt_xRequestedGoods.IsTime = false;
            this.txt_xRequestedGoods.Location = new System.Drawing.Point(47, 20);
            this.txt_xRequestedGoods.Name = "txt_xRequestedGoods";
            this.txt_xRequestedGoods.Size = new System.Drawing.Size(128, 21);
            this.txt_xRequestedGoods.TabIndex = 1;
            this.txt_xRequestedGoods.textWithcomma = null;
            this.txt_xRequestedGoods.textWithoutcomma = null;
            // 
            // txt_xTel
            // 
            this.txt_xTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xTel.Enabled = false;
            this.txt_xTel.IsInteger = false;
            this.txt_xTel.IsNumber = true;
            this.txt_xTel.IsTime = false;
            this.txt_xTel.Location = new System.Drawing.Point(297, 58);
            this.txt_xTel.MaxLength = 11;
            this.txt_xTel.Name = "txt_xTel";
            this.txt_xTel.Size = new System.Drawing.Size(128, 21);
            this.txt_xTel.TabIndex = 6;
            this.txt_xTel.Text = "0";
            this.txt_xTel.textWithcomma = null;
            this.txt_xTel.textWithoutcomma = null;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 224;
            this.label4.Text = "تلفن";
            // 
            // txt_xClientReferral
            // 
            this.txt_xClientReferral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xClientReferral.Enabled = false;
            this.txt_xClientReferral.IsInteger = false;
            this.txt_xClientReferral.IsNumber = false;
            this.txt_xClientReferral.IsTime = false;
            this.txt_xClientReferral.Location = new System.Drawing.Point(297, 20);
            this.txt_xClientReferral.Name = "txt_xClientReferral";
            this.txt_xClientReferral.Size = new System.Drawing.Size(128, 21);
            this.txt_xClientReferral.TabIndex = 0;
            this.txt_xClientReferral.textWithcomma = null;
            this.txt_xClientReferral.textWithoutcomma = null;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 224;
            this.label6.Text = "کالا درخواستی";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 224;
            this.label8.Text = "مراجعه کننده";
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_insert.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btn_insert.Location = new System.Drawing.Point(7, 110);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btn_Cancel.Location = new System.Drawing.Point(7, 166);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Cancel.Size = new System.Drawing.Size(75, 47);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "انصراف";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel_Pub
            // 
            this.panel_Pub.Controls.Add(this.chb_xRequestedGoods);
            this.panel_Pub.Controls.Add(this.chb_xGenResultOfReferral_);
            this.panel_Pub.Controls.Add(this.chb_xTel);
            this.panel_Pub.Controls.Add(this.chb_xClientReferral);
            this.panel_Pub.Controls.Add(this.label3);
            this.panel_Pub.Controls.Add(this.cmb_xGenResultOfReferral_);
            this.panel_Pub.Controls.Add(this.txt_xRequestedGoods);
            this.panel_Pub.Controls.Add(this.txt_xTel);
            this.panel_Pub.Controls.Add(this.label4);
            this.panel_Pub.Controls.Add(this.txt_xClientReferral);
            this.panel_Pub.Controls.Add(this.label6);
            this.panel_Pub.Controls.Add(this.label8);
            this.panel_Pub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Pub.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel_Pub.Location = new System.Drawing.Point(0, 0);
            this.panel_Pub.Name = "panel_Pub";
            this.panel_Pub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_Pub.Size = new System.Drawing.Size(509, 204);
            this.panel_Pub.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(598, 204);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.TabIndex = 115;
            // 
            // chb_xClientReferral
            // 
            this.chb_xClientReferral.AutoSize = true;
            this.chb_xClientReferral.Location = new System.Drawing.Point(276, 23);
            this.chb_xClientReferral.Name = "chb_xClientReferral";
            this.chb_xClientReferral.Size = new System.Drawing.Size(15, 14);
            this.chb_xClientReferral.TabIndex = 225;
            this.chb_xClientReferral.UseVisualStyleBackColor = true;
            this.chb_xClientReferral.CheckedChanged += new System.EventHandler(this.chb_xClientReferral_CheckedChanged);
            // 
            // chb_xTel
            // 
            this.chb_xTel.AutoSize = true;
            this.chb_xTel.Location = new System.Drawing.Point(276, 61);
            this.chb_xTel.Name = "chb_xTel";
            this.chb_xTel.Size = new System.Drawing.Size(15, 14);
            this.chb_xTel.TabIndex = 225;
            this.chb_xTel.UseVisualStyleBackColor = true;
            this.chb_xTel.CheckedChanged += new System.EventHandler(this.chb_xClientReferral_CheckedChanged);
            // 
            // chb_xGenResultOfReferral_
            // 
            this.chb_xGenResultOfReferral_.AutoSize = true;
            this.chb_xGenResultOfReferral_.Location = new System.Drawing.Point(26, 61);
            this.chb_xGenResultOfReferral_.Name = "chb_xGenResultOfReferral_";
            this.chb_xGenResultOfReferral_.Size = new System.Drawing.Size(15, 14);
            this.chb_xGenResultOfReferral_.TabIndex = 225;
            this.chb_xGenResultOfReferral_.UseVisualStyleBackColor = true;
            this.chb_xGenResultOfReferral_.CheckedChanged += new System.EventHandler(this.chb_xClientReferral_CheckedChanged);
            // 
            // chb_xRequestedGoods
            // 
            this.chb_xRequestedGoods.AutoSize = true;
            this.chb_xRequestedGoods.Location = new System.Drawing.Point(26, 23);
            this.chb_xRequestedGoods.Name = "chb_xRequestedGoods";
            this.chb_xRequestedGoods.Size = new System.Drawing.Size(15, 14);
            this.chb_xRequestedGoods.TabIndex = 225;
            this.chb_xRequestedGoods.UseVisualStyleBackColor = true;
            this.chb_xRequestedGoods.CheckedChanged += new System.EventHandler(this.chb_xClientReferral_CheckedChanged);
            // 
            // frmClientReferralSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 204);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmClientReferralSearch";
            this.panel_Pub.ResumeLayout(false);
            this.panel_Pub.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_xGenResultOfReferral_;
        private ControlLibrary.uc_txtBox txt_xRequestedGoods;
        private ControlLibrary.uc_txtBox txt_xTel;
        private System.Windows.Forms.Label label4;
        private ControlLibrary.uc_txtBox txt_xClientReferral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel_Pub;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chb_xRequestedGoods;
        private System.Windows.Forms.CheckBox chb_xGenResultOfReferral_;
        private System.Windows.Forms.CheckBox chb_xTel;
        private System.Windows.Forms.CheckBox chb_xClientReferral;
    }
}