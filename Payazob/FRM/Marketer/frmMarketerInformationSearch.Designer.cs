
namespace MIS.FRM.Marketer
{
    partial class frmMarketerInformationSearch
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
            this.txt_xBuildingOwnerTel = new ControlLibrary.uc_txtBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_xBuildingOwner = new ControlLibrary.uc_txtBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel_Pub = new System.Windows.Forms.Panel();
            this.chb_xBuildingOwnerTel = new System.Windows.Forms.CheckBox();
            this.chb_xBuildingOwner = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_Pub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_xBuildingOwnerTel
            // 
            this.txt_xBuildingOwnerTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xBuildingOwnerTel.Enabled = false;
            this.txt_xBuildingOwnerTel.IsInteger = false;
            this.txt_xBuildingOwnerTel.IsNumber = true;
            this.txt_xBuildingOwnerTel.IsTime = false;
            this.txt_xBuildingOwnerTel.Location = new System.Drawing.Point(59, 21);
            this.txt_xBuildingOwnerTel.MaxLength = 11;
            this.txt_xBuildingOwnerTel.Name = "txt_xBuildingOwnerTel";
            this.txt_xBuildingOwnerTel.Size = new System.Drawing.Size(128, 21);
            this.txt_xBuildingOwnerTel.TabIndex = 6;
            this.txt_xBuildingOwnerTel.Text = "0";
            this.txt_xBuildingOwnerTel.textWithcomma = null;
            this.txt_xBuildingOwnerTel.textWithoutcomma = null;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 224;
            this.label4.Text = "تلفن";
            // 
            // txt_xBuildingOwner
            // 
            this.txt_xBuildingOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xBuildingOwner.Enabled = false;
            this.txt_xBuildingOwner.IsInteger = false;
            this.txt_xBuildingOwner.IsNumber = false;
            this.txt_xBuildingOwner.IsTime = false;
            this.txt_xBuildingOwner.Location = new System.Drawing.Point(297, 20);
            this.txt_xBuildingOwner.Name = "txt_xBuildingOwner";
            this.txt_xBuildingOwner.Size = new System.Drawing.Size(128, 21);
            this.txt_xBuildingOwner.TabIndex = 0;
            this.txt_xBuildingOwner.textWithcomma = null;
            this.txt_xBuildingOwner.textWithoutcomma = null;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 224;
            this.label8.Text = "مالک ساختمان";
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_insert.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btn_insert.Location = new System.Drawing.Point(7, 79);
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
            this.btn_Cancel.Location = new System.Drawing.Point(7, 135);
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
            this.panel_Pub.Controls.Add(this.chb_xBuildingOwnerTel);
            this.panel_Pub.Controls.Add(this.chb_xBuildingOwner);
            this.panel_Pub.Controls.Add(this.txt_xBuildingOwnerTel);
            this.panel_Pub.Controls.Add(this.label4);
            this.panel_Pub.Controls.Add(this.txt_xBuildingOwner);
            this.panel_Pub.Controls.Add(this.label8);
            this.panel_Pub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Pub.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel_Pub.Location = new System.Drawing.Point(0, 0);
            this.panel_Pub.Name = "panel_Pub";
            this.panel_Pub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_Pub.Size = new System.Drawing.Size(509, 204);
            this.panel_Pub.TabIndex = 0;
            // 
            // chb_xBuildingOwnerTel
            // 
            this.chb_xBuildingOwnerTel.AutoSize = true;
            this.chb_xBuildingOwnerTel.Location = new System.Drawing.Point(38, 24);
            this.chb_xBuildingOwnerTel.Name = "chb_xBuildingOwnerTel";
            this.chb_xBuildingOwnerTel.Size = new System.Drawing.Size(15, 14);
            this.chb_xBuildingOwnerTel.TabIndex = 225;
            this.chb_xBuildingOwnerTel.UseVisualStyleBackColor = true;
            this.chb_xBuildingOwnerTel.CheckedChanged += new System.EventHandler(this.chb_xClientReferral_CheckedChanged);
            // 
            // chb_xBuildingOwner
            // 
            this.chb_xBuildingOwner.AutoSize = true;
            this.chb_xBuildingOwner.Location = new System.Drawing.Point(276, 23);
            this.chb_xBuildingOwner.Name = "chb_xBuildingOwner";
            this.chb_xBuildingOwner.Size = new System.Drawing.Size(15, 14);
            this.chb_xBuildingOwner.TabIndex = 225;
            this.chb_xBuildingOwner.UseVisualStyleBackColor = true;
            this.chb_xBuildingOwner.CheckedChanged += new System.EventHandler(this.chb_xClientReferral_CheckedChanged);
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
            // frmMarketerInformationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 204);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMarketerInformationSearch";
            this.panel_Pub.ResumeLayout(false);
            this.panel_Pub.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ControlLibrary.uc_txtBox txt_xBuildingOwnerTel;
        private System.Windows.Forms.Label label4;
        private ControlLibrary.uc_txtBox txt_xBuildingOwner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel_Pub;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chb_xBuildingOwnerTel;
        private System.Windows.Forms.CheckBox chb_xBuildingOwner;
    }
}