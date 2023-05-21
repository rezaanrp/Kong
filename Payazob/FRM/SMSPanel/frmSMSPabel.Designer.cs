
namespace MIS.FRM.SMSPanel
{
    partial class frmSMSPabel
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
            this.btn_ClientAndStore = new System.Windows.Forms.Button();
            this.btn_BirthDayCustomerSetting = new System.Windows.Forms.Button();
            this.btn_ClientSetting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ClientAndStore
            // 
            this.btn_ClientAndStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClientAndStore.BackColor = System.Drawing.Color.Linen;
            this.btn_ClientAndStore.Location = new System.Drawing.Point(528, 12);
            this.btn_ClientAndStore.Name = "btn_ClientAndStore";
            this.btn_ClientAndStore.Size = new System.Drawing.Size(168, 65);
            this.btn_ClientAndStore.TabIndex = 0;
            this.btn_ClientAndStore.Text = "ارسال پیام به مراجعین ";
            this.btn_ClientAndStore.UseVisualStyleBackColor = false;
            this.btn_ClientAndStore.Click += new System.EventHandler(this.btn_ClientAndStore_Click);
            // 
            // btn_BirthDayCustomerSetting
            // 
            this.btn_BirthDayCustomerSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BirthDayCustomerSetting.BackColor = System.Drawing.Color.Moccasin;
            this.btn_BirthDayCustomerSetting.Location = new System.Drawing.Point(7, 12);
            this.btn_BirthDayCustomerSetting.Name = "btn_BirthDayCustomerSetting";
            this.btn_BirthDayCustomerSetting.Size = new System.Drawing.Size(168, 65);
            this.btn_BirthDayCustomerSetting.TabIndex = 0;
            this.btn_BirthDayCustomerSetting.Text = "تنظیمات پیام تولد به مشتری";
            this.btn_BirthDayCustomerSetting.UseVisualStyleBackColor = false;
            // 
            // btn_ClientSetting
            // 
            this.btn_ClientSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClientSetting.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_ClientSetting.Location = new System.Drawing.Point(181, 12);
            this.btn_ClientSetting.Name = "btn_ClientSetting";
            this.btn_ClientSetting.Size = new System.Drawing.Size(168, 65);
            this.btn_ClientSetting.TabIndex = 0;
            this.btn_ClientSetting.Text = "تنظیمات پیام مراجعین";
            this.btn_ClientSetting.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(354, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "ارسال پیام به  مشتری";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_ClientAndStore_Click);
            // 
            // frmSMSPabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 84);
            this.Controls.Add(this.btn_ClientSetting);
            this.Controls.Add(this.btn_BirthDayCustomerSetting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ClientAndStore);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSMSPabel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ClientAndStore;
        private System.Windows.Forms.Button btn_BirthDayCustomerSetting;
        private System.Windows.Forms.Button btn_ClientSetting;
        private System.Windows.Forms.Button button1;
    }
}