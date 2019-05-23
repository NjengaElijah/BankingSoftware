namespace Moshi_Bank.Views
{
    partial class AD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAD = new System.Windows.Forms.Button();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblDebit = new System.Windows.Forms.Label();
            this.title6 = new Moshi_Bank.Controls.Title();
            this.title5 = new Moshi_Bank.Controls.Title();
            this.title2 = new Moshi_Bank.Controls.Title();
            this.title1 = new Moshi_Bank.Controls.Title();
            this.datagrid1 = new Moshi_Bank.Controls.Datagrid();
            this.findUser1 = new Moshi_Bank.Controls.FindUser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 67);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activate Deactivate";
            // 
            // btnAD
            // 
            this.btnAD.Location = new System.Drawing.Point(338, 465);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(108, 38);
            this.btnAD.TabIndex = 44;
            this.btnAD.Text = "Deactivate";
            this.btnAD.UseVisualStyleBackColor = true;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.lblNames.ForeColor = System.Drawing.Color.Olive;
            this.lblNames.Location = new System.Drawing.Point(360, 142);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(17, 25);
            this.lblNames.TabIndex = 51;
            this.lblNames.Text = " ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.lblBalance.ForeColor = System.Drawing.Color.Olive;
            this.lblBalance.Location = new System.Drawing.Point(360, 233);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(17, 25);
            this.lblBalance.TabIndex = 51;
            this.lblBalance.Text = " ";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.lblCredit.ForeColor = System.Drawing.Color.Olive;
            this.lblCredit.Location = new System.Drawing.Point(360, 330);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(17, 25);
            this.lblCredit.TabIndex = 51;
            this.lblCredit.Text = " ";
            // 
            // lblDebit
            // 
            this.lblDebit.AutoSize = true;
            this.lblDebit.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.lblDebit.ForeColor = System.Drawing.Color.Olive;
            this.lblDebit.Location = new System.Drawing.Point(360, 417);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(17, 25);
            this.lblDebit.TabIndex = 51;
            this.lblDebit.Text = " ";
            // 
            // title6
            // 
            this.title6.BackColor = System.Drawing.Color.Transparent;
            this.title6.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.title6.LineColor = System.Drawing.Color.SlateGray;
            this.title6.Location = new System.Drawing.Point(338, 266);
            this.title6.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.title6.Name = "title6";
            this.title6.Size = new System.Drawing.Size(355, 56);
            this.title6.TabIndex = 50;
            this.title6.TextColor = System.Drawing.Color.SlateGray;
            this.title6.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.title6.TitleText = "Total Credit";
            // 
            // title5
            // 
            this.title5.BackColor = System.Drawing.Color.Transparent;
            this.title5.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.title5.LineColor = System.Drawing.Color.SlateGray;
            this.title5.Location = new System.Drawing.Point(338, 363);
            this.title5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.title5.Name = "title5";
            this.title5.Size = new System.Drawing.Size(355, 57);
            this.title5.TabIndex = 49;
            this.title5.TextColor = System.Drawing.Color.SlateGray;
            this.title5.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.title5.TitleText = "Total Debit";
            this.title5.Load += new System.EventHandler(this.title5_Load);
            // 
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.Transparent;
            this.title2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.title2.LineColor = System.Drawing.Color.SlateGray;
            this.title2.Location = new System.Drawing.Point(338, 172);
            this.title2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(355, 56);
            this.title2.TabIndex = 46;
            this.title2.TextColor = System.Drawing.Color.SlateGray;
            this.title2.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.title2.TitleText = "Account Balance";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.Transparent;
            this.title1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.title1.LineColor = System.Drawing.Color.SlateGray;
            this.title1.Location = new System.Drawing.Point(338, 75);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(355, 52);
            this.title1.TabIndex = 45;
            this.title1.TextColor = System.Drawing.Color.SlateGray;
            this.title1.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.title1.TitleText = "Account Names";
            this.title1.Load += new System.EventHandler(this.title1_Load);
            // 
            // datagrid1
            // 
            this.datagrid1.AllowUserToAddRows = false;
            this.datagrid1.AllowUserToDeleteRows = false;
            this.datagrid1.AllowUserToResizeColumns = false;
            this.datagrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datagrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid1.BackgroundColor = System.Drawing.Color.White;
            this.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid1.EnableHeadersVisualStyles = false;
            this.datagrid1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.datagrid1.Location = new System.Drawing.Point(324, 518);
            this.datagrid1.MultiSelect = false;
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.ReadOnly = true;
            this.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagrid1.RowHeadersVisible = false;
            this.datagrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid1.Size = new System.Drawing.Size(546, 86);
            this.datagrid1.TabIndex = 43;
            this.datagrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_CellContentClick);
            this.datagrid1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_CellContentDoubleClick);
            this.datagrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_CellContentDoubleClick);
            this.datagrid1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_RowEnter);
            // 
            // findUser1
            // 
            this.findUser1.Account = null;
            this.findUser1.AdvancedFind = false;
            this.findUser1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.findUser1.Connection = null;
            this.findUser1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findUser1.Location = new System.Drawing.Point(0, 66);
            this.findUser1.Name = "findUser1";
            this.findUser1.Size = new System.Drawing.Size(318, 551);
            this.findUser1.TabIndex = 0;
            this.findUser1.User = null;
            this.findUser1.FoundUser += new Moshi_Bank.Controls.FindUser.FindUserEvents(this.findUser1_FoundUser);
            this.findUser1.SearchStarted += new Moshi_Bank.Controls.FindUser.SearchStartedEvents(this.findUser1_SearchStarted);
            // 
            // AD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 616);
            this.Controls.Add(this.lblDebit);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.title6);
            this.Controls.Add(this.title5);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.datagrid1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.findUser1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activate Deactivate";
            this.Load += new System.EventHandler(this.AD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.FindUser findUser1;
        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Button btnAD;
        private Controls.Datagrid datagrid1;
        private Controls.Title title1;
        private Controls.Title title2;
        private Controls.Title title5;
        private Controls.Title title6;
        private global::System.Windows.Forms.Label lblNames;
        private global::System.Windows.Forms.Label lblBalance;
        private global::System.Windows.Forms.Label lblCredit;
        private global::System.Windows.Forms.Label lblDebit;
    }
}