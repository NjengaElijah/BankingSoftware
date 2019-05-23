namespace Moshi_Bank.Views
{
    partial class MainAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(MainAccounts));
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.panel2 = new global::System.Windows.Forms.Panel();
            this.label5 = new global::System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
            this.btnNewAccounts = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBalances = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnStatements = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size((System.Int32)993, (System.Int32)67);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size((System.Int32)993, (System.Int32)1);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)23F);
            this.label5.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)9);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size((System.Int32)155, (System.Int32)42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Acccounts";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnNewAccounts);
            this.flowLayoutPanel1.Controls.Add(this.btnBalances);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnStatements);
            this.flowLayoutPanel1.Location = new global::System.Drawing.Point((System.Int32)206, (System.Int32)214);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new global::System.Drawing.Size((System.Int32)561, (System.Int32)243);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnNewAccounts
            // 
            this.btnNewAccounts.BackColor = global::System.Drawing.Color.SeaGreen;
            this.btnNewAccounts.color = global::System.Drawing.Color.SeaGreen;
            this.btnNewAccounts.colorActive = global::System.Drawing.Color.MediumSeaGreen;
            this.btnNewAccounts.Cursor = global::System.Windows.Forms.Cursors.Hand;
            this.btnNewAccounts.Font = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)15.75F);
            this.btnNewAccounts.ForeColor = global::System.Drawing.Color.White;
            this.btnNewAccounts.Image = ((global::System.Drawing.Image)(resources.GetObject((System.String)"btnNewAccounts.Image")));
            this.btnNewAccounts.ImagePosition = 20;
            this.btnNewAccounts.ImageZoom = 50;
            this.btnNewAccounts.LabelPosition = 41;
            this.btnNewAccounts.LabelText = "New";
            this.btnNewAccounts.Location = new global::System.Drawing.Point((System.Int32)6, (System.Int32)6);
            this.btnNewAccounts.Margin = new global::System.Windows.Forms.Padding((System.Int32)6);
            this.btnNewAccounts.Name = "btnNewAccounts";
            this.btnNewAccounts.Size = new global::System.Drawing.Size((System.Int32)128, (System.Int32)129);
            this.btnNewAccounts.TabIndex = 3;
            this.btnNewAccounts.Click += new global::System.EventHandler(this.btnNewAccounts_Click);
            // 
            // btnBalances
            // 
            this.btnBalances.BackColor = global::System.Drawing.Color.SeaGreen;
            this.btnBalances.color = global::System.Drawing.Color.SeaGreen;
            this.btnBalances.colorActive = global::System.Drawing.Color.MediumSeaGreen;
            this.btnBalances.Cursor = global::System.Windows.Forms.Cursors.Hand;
            this.btnBalances.Font = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)15.75F);
            this.btnBalances.ForeColor = global::System.Drawing.Color.White;
            this.btnBalances.Image = ((global::System.Drawing.Image)(resources.GetObject((System.String)"btnBalances.Image")));
            this.btnBalances.ImagePosition = 20;
            this.btnBalances.ImageZoom = 50;
            this.btnBalances.LabelPosition = 41;
            this.btnBalances.LabelText = "Balances";
            this.btnBalances.Location = new global::System.Drawing.Point((System.Int32)146, (System.Int32)6);
            this.btnBalances.Margin = new global::System.Windows.Forms.Padding((System.Int32)6);
            this.btnBalances.Name = "btnBalances";
            this.btnBalances.Size = new global::System.Drawing.Size((System.Int32)128, (System.Int32)129);
            this.btnBalances.TabIndex = 3;
            this.btnBalances.Click += new global::System.EventHandler(this.btnBalances_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = global::System.Drawing.Color.SeaGreen;
            this.btnSearch.color = global::System.Drawing.Color.SeaGreen;
            this.btnSearch.colorActive = global::System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Cursor = global::System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)15.75F);
            this.btnSearch.ForeColor = global::System.Drawing.Color.White;
            this.btnSearch.Image = global::Moshi_Bank.Properties.Resources.se;
            this.btnSearch.ImagePosition = 20;
            this.btnSearch.ImageZoom = 50;
            this.btnSearch.LabelPosition = 41;
            this.btnSearch.LabelText = "Search";
            this.btnSearch.Location = new global::System.Drawing.Point((System.Int32)286, (System.Int32)6);
            this.btnSearch.Margin = new global::System.Windows.Forms.Padding((System.Int32)6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new global::System.Drawing.Size((System.Int32)128, (System.Int32)129);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new global::System.EventHandler(this.btnSearch_Click);
            // 
            // btnStatements
            // 
            this.btnStatements.BackColor = global::System.Drawing.Color.SeaGreen;
            this.btnStatements.color = global::System.Drawing.Color.SeaGreen;
            this.btnStatements.colorActive = global::System.Drawing.Color.MediumSeaGreen;
            this.btnStatements.Cursor = global::System.Windows.Forms.Cursors.Hand;
            this.btnStatements.Font = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)15.75F);
            this.btnStatements.ForeColor = global::System.Drawing.Color.White;
            this.btnStatements.Image = global::Moshi_Bank.Properties.Resources.icon_stats;
            this.btnStatements.ImagePosition = 20;
            this.btnStatements.ImageZoom = 50;
            this.btnStatements.LabelPosition = 41;
            this.btnStatements.LabelText = "Statements";
            this.btnStatements.Location = new global::System.Drawing.Point((System.Int32)426, (System.Int32)6);
            this.btnStatements.Margin = new global::System.Windows.Forms.Padding((System.Int32)6);
            this.btnStatements.Name = "btnStatements";
            this.btnStatements.Size = new global::System.Drawing.Size((System.Int32)128, (System.Int32)129);
            this.btnStatements.TabIndex = 3;
            this.btnStatements.Click += new global::System.EventHandler(this.btnStatements_Click);
            // 
            // MainAccounts
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)6F, (System.Single)13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)993, (System.Int32)580);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)8.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainAccounts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAccounts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label5;
        private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuTileButton btnNewAccounts;
        private Bunifu.Framework.UI.BunifuTileButton btnBalances;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
        private Bunifu.Framework.UI.BunifuTileButton btnStatements;
    }
}