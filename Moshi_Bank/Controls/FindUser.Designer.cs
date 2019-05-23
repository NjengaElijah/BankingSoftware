namespace Moshi_Bank.Controls
{
    partial class FindUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picDS = new System.Windows.Forms.PictureBox();
            this.picUserPhoto = new System.Windows.Forms.PictureBox();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccNames = new System.Windows.Forms.Label();
            this.lblNationalId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(12, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 21);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Advanced Find";
            // 
            // picDS
            // 
            this.picDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDS.Location = new System.Drawing.Point(16, 500);
            this.picDS.Name = "picDS";
            this.picDS.Size = new System.Drawing.Size(279, 41);
            this.picDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDS.TabIndex = 14;
            this.picDS.TabStop = false;
            // 
            // picUserPhoto
            // 
            this.picUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUserPhoto.Location = new System.Drawing.Point(16, 208);
            this.picUserPhoto.Name = "picUserPhoto";
            this.picUserPhoto.Size = new System.Drawing.Size(279, 286);
            this.picUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserPhoto.TabIndex = 15;
            this.picUserPhoto.TabStop = false;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAccount.Location = new System.Drawing.Point(220, 49);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(75, 24);
            this.btnSearchAccount.TabIndex = 13;
            this.btnSearchAccount.Text = "Search";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(16, 46);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(198, 29);
            this.txtAccountNumber.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Account Number ";
            // 
            // txtAccNames
            // 
            this.txtAccNames.AutoSize = true;
            this.txtAccNames.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.txtAccNames.Location = new System.Drawing.Point(25, 127);
            this.txtAccNames.Name = "txtAccNames";
            this.txtAccNames.Size = new System.Drawing.Size(0, 28);
            this.txtAccNames.TabIndex = 11;
            // 
            // lblNationalId
            // 
            this.lblNationalId.AutoSize = true;
            this.lblNationalId.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lblNationalId.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNationalId.Location = new System.Drawing.Point(25, 166);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(0, 28);
            this.lblNationalId.TabIndex = 11;
            // 
            // FindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picDS);
            this.Controls.Add(this.picUserPhoto);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblNationalId);
            this.Controls.Add(this.txtAccNames);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FindUser";
            this.Size = new System.Drawing.Size(318, 551);
            ((System.ComponentModel.ISupportInitialize)(this.picDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picDS;
        private System.Windows.Forms.PictureBox picUserPhoto;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtAccNames;
        private System.Windows.Forms.Label lblNationalId;
    }
}
