namespace Moshi_Bank.Views
{
    partial class UI
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circle1 = new Moshi_Bank.Controls.Circle();
            this.title1 = new Moshi_Bank.Controls.Title();
            this.pnlAccounts = new Moshi_Bank.Contols.Panels();
            this.pnlStatements = new Moshi_Bank.Contols.Panels();
            this.pnlTransactions = new Moshi_Bank.Contols.Panels();
            this.pnlDeposits = new Moshi_Bank.Contols.Panels();
            this.pnlUsers = new Moshi_Bank.Contols.Panels();
            this.pnlSettings = new Moshi_Bank.Contols.Panels();
            this.panels2 = new Moshi_Bank.Contols.Panels();
            this.pnlTransfer = new Moshi_Bank.Contols.Panels();
            this.panels1 = new Moshi_Bank.Contols.Panels();
            this.pnlWithdraw = new Moshi_Bank.Contols.Panels();
            this.title2 = new Moshi_Bank.Controls.Title();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circle1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlAccounts);
            this.flowLayoutPanel1.Controls.Add(this.pnlStatements);
            this.flowLayoutPanel1.Controls.Add(this.pnlTransactions);
            this.flowLayoutPanel1.Controls.Add(this.pnlDeposits);
            this.flowLayoutPanel1.Controls.Add(this.pnlUsers);
            this.flowLayoutPanel1.Controls.Add(this.pnlSettings);
            this.flowLayoutPanel1.Controls.Add(this.panels2);
            this.flowLayoutPanel1.Controls.Add(this.pnlTransfer);
            this.flowLayoutPanel1.Controls.Add(this.panels1);
            this.flowLayoutPanel1.Controls.Add(this.pnlWithdraw);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 168);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(830, 343);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.splitContainer1.Panel1.Controls.Add(this.circle1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.title1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1130, 511);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 76);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(150, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 168);
            this.panel1.TabIndex = 3;
            // 
            // circle1
            // 
            this.circle1.BackColor = System.Drawing.Color.White;
            this.circle1.Image = global::Moshi_Bank.Properties.Resources.index3;
            this.circle1.Location = new System.Drawing.Point(56, 121);
            this.circle1.Name = "circle1";
            this.circle1.Size = new System.Drawing.Size(171, 171);
            this.circle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circle1.TabIndex = 8;
            this.circle1.TabStop = false;
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.LavenderBlush;
            this.title1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.title1.LineColor = System.Drawing.Color.Gray;
            this.title1.Location = new System.Drawing.Point(12, 12);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(265, 78);
            this.title1.TabIndex = 6;
            this.title1.TextColor = System.Drawing.Color.DarkGray;
            this.title1.TextFont = new System.Drawing.Font("Segoe UI Light", 31F);
            this.title1.TitleText = "User";
            // 
            // pnlAccounts
            // 
            this.pnlAccounts.BackgroundColor = System.Drawing.Color.White;
            this.pnlAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAccounts.Description = "Accounts";
            this.pnlAccounts.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.pnlAccounts.Icon = global::Moshi_Bank.Properties.Resources.index3;
            this.pnlAccounts.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlAccounts.Location = new System.Drawing.Point(3, 4);
            this.pnlAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAccounts.MouseHooverColor = System.Drawing.Color.Gray;
            this.pnlAccounts.Name = "pnlAccounts";
            this.pnlAccounts.Size = new System.Drawing.Size(173, 176);
            this.pnlAccounts.TabIndex = 1;
            this.pnlAccounts.TextColor = System.Drawing.SystemColors.ControlText;
            this.pnlAccounts.TitleColor = System.Drawing.Color.Khaki;
            // 
            // pnlStatements
            // 
            this.pnlStatements.BackgroundColor = System.Drawing.Color.White;
            this.pnlStatements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlStatements.Description = "Statements";
            this.pnlStatements.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.pnlStatements.Icon = global::Moshi_Bank.Properties.Resources.transactions;
            this.pnlStatements.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlStatements.Location = new System.Drawing.Point(182, 4);
            this.pnlStatements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStatements.MouseHooverColor = System.Drawing.Color.Gray;
            this.pnlStatements.Name = "pnlStatements";
            this.pnlStatements.Size = new System.Drawing.Size(173, 176);
            this.pnlStatements.TabIndex = 1;
            this.pnlStatements.TextColor = System.Drawing.SystemColors.ControlText;
            this.pnlStatements.TitleColor = System.Drawing.Color.LightSalmon;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.BackgroundColor = System.Drawing.Color.White;
            this.pnlTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTransactions.Description = "Transactions";
            this.pnlTransactions.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.pnlTransactions.Icon = global::Moshi_Bank.Properties.Resources.search;
            this.pnlTransactions.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlTransactions.Location = new System.Drawing.Point(361, 4);
            this.pnlTransactions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTransactions.MouseHooverColor = System.Drawing.Color.Gray;
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(173, 176);
            this.pnlTransactions.TabIndex = 1;
            this.pnlTransactions.TextColor = System.Drawing.SystemColors.ControlText;
            this.pnlTransactions.TitleColor = System.Drawing.Color.PaleGreen;
            // 
            // pnlDeposits
            // 
            this.pnlDeposits.BackgroundColor = System.Drawing.Color.White;
            this.pnlDeposits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDeposits.Description = "Deposit";
            this.pnlDeposits.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.pnlDeposits.Icon = global::Moshi_Bank.Properties.Resources.down;
            this.pnlDeposits.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlDeposits.Location = new System.Drawing.Point(540, 4);
            this.pnlDeposits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDeposits.MouseHooverColor = System.Drawing.Color.Gray;
            this.pnlDeposits.Name = "pnlDeposits";
            this.pnlDeposits.Size = new System.Drawing.Size(173, 176);
            this.pnlDeposits.TabIndex = 1;
            this.pnlDeposits.TextColor = System.Drawing.SystemColors.ControlText;
            this.pnlDeposits.TitleColor = System.Drawing.Color.YellowGreen;
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackgroundColor = System.Drawing.Color.Linen;
            this.pnlUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUsers.Description = "Users";
            this.pnlUsers.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.pnlUsers.Icon = global::Moshi_Bank.Properties.Resources.user;
            this.pnlUsers.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlUsers.Location = new System.Drawing.Point(3, 188);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUsers.MouseHooverColor = System.Drawing.Color.Gray;
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(173, 176);
            this.pnlUsers.TabIndex = 1;
            this.pnlUsers.TextColor = System.Drawing.SystemColors.ControlText;
            this.pnlUsers.TitleColor = System.Drawing.Color.NavajoWhite;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackgroundColor = System.Drawing.Color.White;
            this.pnlSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSettings.Description = "Settings";
            this.pnlSettings.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.pnlSettings.Icon = global::Moshi_Bank.Properties.Resources.sett;
            this.pnlSettings.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlSettings.Location = new System.Drawing.Point(182, 188);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSettings.MouseHooverColor = System.Drawing.Color.Gray;
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(173, 176);
            this.pnlSettings.TabIndex = 1;
            this.pnlSettings.TextColor = System.Drawing.SystemColors.ControlText;
            this.pnlSettings.TitleColor = System.Drawing.Color.DarkKhaki;
            // 
            // panels2
            // 
            this.panels2.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.panels2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panels2.Description = "Activate / Deactivate";
            this.panels2.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.panels2.Icon = global::Moshi_Bank.Properties.Resources.activdeactiv;
            this.panels2.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panels2.Location = new System.Drawing.Point(361, 188);
            this.panels2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panels2.MouseHooverColor = System.Drawing.Color.Gray;
            this.panels2.Name = "panels2";
            this.panels2.Size = new System.Drawing.Size(173, 176);
            this.panels2.TabIndex = 1;
            this.panels2.TextColor = System.Drawing.Color.White;
            this.panels2.TitleColor = System.Drawing.Color.DarkSlateGray;
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.BackgroundColor = System.Drawing.Color.White;
            this.pnlTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTransfer.Description = "Transfer";
            this.pnlTransfer.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.pnlTransfer.Icon = global::Moshi_Bank.Properties.Resources.up;
            this.pnlTransfer.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlTransfer.Location = new System.Drawing.Point(540, 188);
            this.pnlTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTransfer.MouseHooverColor = System.Drawing.Color.Gray;
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(173, 176);
            this.pnlTransfer.TabIndex = 1;
            this.pnlTransfer.TextColor = System.Drawing.SystemColors.ControlText;
            this.pnlTransfer.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // panels1
            // 
            this.panels1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.panels1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panels1.Description = "Statistics";
            this.panels1.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.panels1.Icon = global::Moshi_Bank.Properties.Resources.stat;
            this.panels1.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.panels1.Location = new System.Drawing.Point(3, 372);
            this.panels1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panels1.MouseHooverColor = System.Drawing.Color.Gray;
            this.panels1.Name = "panels1";
            this.panels1.Size = new System.Drawing.Size(173, 176);
            this.panels1.TabIndex = 1;
            this.panels1.TextColor = System.Drawing.SystemColors.ControlText;
            this.panels1.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.BackgroundColor = System.Drawing.Color.White;
            this.pnlWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlWithdraw.Description = "Withdraw";
            this.pnlWithdraw.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.pnlWithdraw.Icon = global::Moshi_Bank.Properties.Resources.up;
            this.pnlWithdraw.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlWithdraw.Location = new System.Drawing.Point(182, 372);
            this.pnlWithdraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWithdraw.MouseHooverColor = System.Drawing.Color.Gray;
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(173, 176);
            this.pnlWithdraw.TabIndex = 1;
            this.pnlWithdraw.TextColor = System.Drawing.SystemColors.ControlText;
            this.pnlWithdraw.TitleColor = System.Drawing.Color.LightCoral;
            // 
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.White;
            this.title2.LineColor = System.Drawing.Color.DarkGray;
            this.title2.Location = new System.Drawing.Point(22, 3);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(430, 87);
            this.title2.TabIndex = 6;
            this.title2.TextColor = System.Drawing.Color.Gray;
            this.title2.TextFont = new System.Drawing.Font("Segoe UI Light", 31F);
            this.title2.TitleText = "Navigate";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UI";
            this.Text = "UI";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circle1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Contols.Panels pnlUsers;
        private Contols.Panels pnlAccounts;
        private Contols.Panels pnlDeposits;
        private Contols.Panels pnlWithdraw;
        private Contols.Panels pnlTransactions;
        private Contols.Panels pnlTransfer;
        private Contols.Panels pnlStatements;
        private Contols.Panels panels1;
        private Contols.Panels pnlSettings;
        private Contols.Panels panels2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private Controls.Title title2;
        private Controls.Title title1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Controls.Circle circle1;
    }
}