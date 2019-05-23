namespace Moshi_Bank.Views
{
    partial class Withdraw
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccountNames = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.findUser1 = new Moshi_Bank.Controls.FindUser();
            this.panel6 = new System.Windows.Forms.Panel();
            this.datagridFixedDep = new Moshi_Bank.Controls.Datagrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccType = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvRecentTransactions = new Moshi_Bank.Controls.Datagrid();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFixedDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnWithdraw.Location = new System.Drawing.Point(617, 370);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(83, 28);
            this.btnWithdraw.TabIndex = 25;
            this.btnWithdraw.Text = "Proceed";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWithdraw.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdraw.Location = new System.Drawing.Point(363, 359);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.ShortcutsEnabled = false;
            this.txtWithdraw.Size = new System.Drawing.Size(248, 43);
            this.txtWithdraw.TabIndex = 24;
            this.txtWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWithdraw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWithdraw_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(365, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount To Withdraw";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(365, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semilight", 25F);
            this.lblBalance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBalance.Location = new System.Drawing.Point(365, 266);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 46);
            this.lblBalance.TabIndex = 14;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lblDateCreated.Location = new System.Drawing.Point(365, 187);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(0, 28);
            this.lblDateCreated.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(365, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date Created";
            // 
            // lblAccountNames
            // 
            this.lblAccountNames.AutoSize = true;
            this.lblAccountNames.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lblAccountNames.Location = new System.Drawing.Point(365, 107);
            this.lblAccountNames.Name = "lblAccountNames";
            this.lblAccountNames.Size = new System.Drawing.Size(0, 28);
            this.lblAccountNames.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(365, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Account Names";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Withdraw";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 67);
            this.panel1.TabIndex = 11;
            // 
            // findUser1
            // 
            this.findUser1.Account = null;
            this.findUser1.AdvancedFind = true;
            this.findUser1.BackColor = System.Drawing.Color.White;
            this.findUser1.Connection = null;
            this.findUser1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findUser1.Location = new System.Drawing.Point(9, 73);
            this.findUser1.Name = "findUser1";
            this.findUser1.Size = new System.Drawing.Size(318, 551);
            this.findUser1.TabIndex = 1;
            this.findUser1.User = null;
            this.findUser1.FoundUser += new Moshi_Bank.Controls.FindUser.FindUserEvents(this.findUser1_FoundUser);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.datagridFixedDep);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(770, 247);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 119);
            this.panel6.TabIndex = 40;
            // 
            // datagridFixedDep
            // 
            this.datagridFixedDep.AllowUserToAddRows = false;
            this.datagridFixedDep.AllowUserToDeleteRows = false;
            this.datagridFixedDep.AllowUserToResizeColumns = false;
            this.datagridFixedDep.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datagridFixedDep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridFixedDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridFixedDep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridFixedDep.BackgroundColor = System.Drawing.Color.White;
            this.datagridFixedDep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridFixedDep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridFixedDep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridFixedDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFixedDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridFixedDep.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridFixedDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridFixedDep.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridFixedDep.EnableHeadersVisualStyles = false;
            this.datagridFixedDep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.datagridFixedDep.Location = new System.Drawing.Point(0, 34);
            this.datagridFixedDep.MultiSelect = false;
            this.datagridFixedDep.Name = "datagridFixedDep";
            this.datagridFixedDep.ReadOnly = true;
            this.datagridFixedDep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridFixedDep.RowHeadersVisible = false;
            this.datagridFixedDep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridFixedDep.Size = new System.Drawing.Size(238, 83);
            this.datagridFixedDep.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 34);
            this.label9.TabIndex = 11;
            this.label9.Text = "Constrains";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAccType
            // 
            this.txtAccType.AutoSize = true;
            this.txtAccType.Font = new System.Drawing.Font("Segoe UI Semilight", 25F);
            this.txtAccType.ForeColor = System.Drawing.Color.IndianRed;
            this.txtAccType.Location = new System.Drawing.Point(768, 174);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.Size = new System.Drawing.Size(0, 46);
            this.txtAccType.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(758, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(763, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 44;
            this.label2.Text = "Account Type";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(721, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 300);
            this.panel3.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(332, 467);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(740, 1);
            this.panel5.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(338, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 25);
            this.label14.TabIndex = 48;
            this.label14.Text = "Recent Transactions";
            // 
            // dgvRecentTransactions
            // 
            this.dgvRecentTransactions.AllowUserToAddRows = false;
            this.dgvRecentTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvRecentTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecentTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentTransactions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecentTransactions.EnableHeadersVisualStyles = false;
            this.dgvRecentTransactions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvRecentTransactions.Location = new System.Drawing.Point(343, 486);
            this.dgvRecentTransactions.MultiSelect = false;
            this.dgvRecentTransactions.Name = "dgvRecentTransactions";
            this.dgvRecentTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRecentTransactions.RowHeadersVisible = false;
            this.dgvRecentTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentTransactions.Size = new System.Drawing.Size(791, 121);
            this.dgvRecentTransactions.TabIndex = 47;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 630);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvRecentTransactions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.findUser1);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAccountNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Withdraw";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridFixedDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private global::System.Windows.Forms.Button btnWithdraw;
        private global::System.Windows.Forms.TextBox txtWithdraw;
        private global::System.Windows.Forms.Label label6;
        private global::System.Windows.Forms.Label label5;
        private global::System.Windows.Forms.Label lblBalance;
        private global::System.Windows.Forms.Label lblDateCreated;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Label lblAccountNames;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Panel panel1;
        private Controls.FindUser findUser1;
        private global::System.Windows.Forms.Panel panel6;
        private Controls.Datagrid datagridFixedDep;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private global::System.Windows.Forms.Label label9;
        private global::System.Windows.Forms.Label txtAccType;
        private global::System.Windows.Forms.Panel panel4;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Panel panel3;
        private global::System.Windows.Forms.Panel panel5;
        private global::System.Windows.Forms.Label label14;
        private Controls.Datagrid dgvRecentTransactions;
    }
}