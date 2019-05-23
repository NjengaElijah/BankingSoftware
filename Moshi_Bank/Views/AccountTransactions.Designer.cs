namespace Moshi_Bank.Views
{
    partial class AccountTransactions
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
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.panel2 = new global::System.Windows.Forms.Panel();
            this.label1 = new global::System.Windows.Forms.Label();
            this.panel3 = new global::System.Windows.Forms.Panel();
            this.btnSearchTransactionCode = new global::System.Windows.Forms.Button();
            this.btnSearchTransactions = new global::System.Windows.Forms.Button();
            this.lblAccountNames = new global::System.Windows.Forms.Label();
            this.lblAccountBalance = new global::System.Windows.Forms.Label();
            this.txtTransactionCode = new global::System.Windows.Forms.TextBox();
            this.txtAccountNumber = new global::System.Windows.Forms.TextBox();
            this.panel4 = new global::System.Windows.Forms.Panel();
            this.label4 = new global::System.Windows.Forms.Label();
            this.label5 = new global::System.Windows.Forms.Label();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.dgvTransactions = new Moshi_Bank.Controls.Datagrid();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size((System.Int32)961, (System.Int32)67);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size((System.Int32)961, (System.Int32)1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)26.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label1.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)9);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size((System.Int32)337, (System.Int32)47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Transactions";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnSearchTransactionCode);
            this.panel3.Controls.Add(this.btnSearchTransactions);
            this.panel3.Controls.Add(this.lblAccountNames);
            this.panel3.Controls.Add(this.lblAccountBalance);
            this.panel3.Controls.Add(this.txtTransactionCode);
            this.panel3.Controls.Add(this.txtAccountNumber);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new global::System.Drawing.Size((System.Int32)961, (System.Int32)169);
            this.panel3.TabIndex = 13;
            // 
            // btnSearchTransactionCode
            // 
            this.btnSearchTransactionCode.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnSearchTransactionCode.Location = new global::System.Drawing.Point((System.Int32)251, (System.Int32)104);
            this.btnSearchTransactionCode.Name = "btnSearchTransactionCode";
            this.btnSearchTransactionCode.Size = new global::System.Drawing.Size((System.Int32)75, (System.Int32)34);
            this.btnSearchTransactionCode.TabIndex = 4;
            this.btnSearchTransactionCode.Text = "Search";
            this.btnSearchTransactionCode.UseVisualStyleBackColor = true;
            this.btnSearchTransactionCode.Click += new global::System.EventHandler(this.btnSearchTransactionCode_Click);
            // 
            // btnSearchTransactions
            // 
            this.btnSearchTransactions.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnSearchTransactions.Location = new global::System.Drawing.Point((System.Int32)251, (System.Int32)43);
            this.btnSearchTransactions.Name = "btnSearchTransactions";
            this.btnSearchTransactions.Size = new global::System.Drawing.Size((System.Int32)75, (System.Int32)34);
            this.btnSearchTransactions.TabIndex = 2;
            this.btnSearchTransactions.Text = "Search";
            this.btnSearchTransactions.UseVisualStyleBackColor = true;
            this.btnSearchTransactions.Click += new global::System.EventHandler(this.btnSearchTransactions_Click);
            // 
            // lblAccountNames
            // 
            this.lblAccountNames.AutoSize = true;
            this.lblAccountNames.BackColor = global::System.Drawing.Color.WhiteSmoke;
            this.lblAccountNames.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)24F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.lblAccountNames.ForeColor = global::System.Drawing.Color.SandyBrown;
            this.lblAccountNames.Location = new global::System.Drawing.Point((System.Int32)352, (System.Int32)38);
            this.lblAccountNames.Name = "lblAccountNames";
            this.lblAccountNames.Size = new global::System.Drawing.Size((System.Int32)29, (System.Int32)45);
            this.lblAccountNames.TabIndex = 3;
            this.lblAccountNames.Text = " ";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.BackColor = global::System.Drawing.Color.WhiteSmoke;
            this.lblAccountBalance.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)24F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.lblAccountBalance.ForeColor = global::System.Drawing.Color.SandyBrown;
            this.lblAccountBalance.Location = new global::System.Drawing.Point((System.Int32)356, (System.Int32)117);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new global::System.Drawing.Size((System.Int32)29, (System.Int32)45);
            this.lblAccountBalance.TabIndex = 3;
            this.lblAccountBalance.Text = " ";
            // 
            // txtTransactionCode
            // 
            this.txtTransactionCode.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)15F);
            this.txtTransactionCode.Location = new global::System.Drawing.Point((System.Int32)16, (System.Int32)104);
            this.txtTransactionCode.Name = "txtTransactionCode";
            this.txtTransactionCode.Size = new global::System.Drawing.Size((System.Int32)229, (System.Int32)34);
            this.txtTransactionCode.TabIndex = 3;
            this.txtTransactionCode.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtTransactionCode_KeyDown);
            this.txtTransactionCode.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtTransactionCode_KeyPress);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)15F);
            this.txtAccountNumber.Location = new global::System.Drawing.Point((System.Int32)16, (System.Int32)43);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new global::System.Drawing.Size((System.Int32)229, (System.Int32)34);
            this.txtAccountNumber.TabIndex = 1;
            this.txtAccountNumber.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtAccountNumber_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new global::System.Drawing.Size((System.Int32)961, (System.Int32)1);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)10F);
            this.label4.Location = new global::System.Drawing.Point((System.Int32)353, (System.Int32)13);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size((System.Int32)104, (System.Int32)19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account Names";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)10F);
            this.label5.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)82);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size((System.Int32)113, (System.Int32)19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Transaction Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)10F);
            this.label3.Location = new global::System.Drawing.Point((System.Int32)356, (System.Int32)92);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size((System.Int32)55, (System.Int32)19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)10F);
            this.label2.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)13);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size((System.Int32)112, (System.Int32)19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Number";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeColumns = false;
            this.dgvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.Black;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransactions.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactions.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTransactions.BackgroundColor = global::System.Drawing.Color.WhiteSmoke;
            this.dgvTransactions.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.Bisque;
            dataGridViewCellStyle5.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = global::System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle6.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = global::System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransactions.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)10F);
            this.dgvTransactions.Location = new global::System.Drawing.Point((System.Int32)5, (System.Int32)242);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new global::System.Drawing.Size((System.Int32)951, (System.Int32)247);
            this.dgvTransactions.TabIndex = 35;
            this.dgvTransactions.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellDoubleClick);
            // 
            // AccountTransactions
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)6F, (System.Single)13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)961, (System.Int32)495);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "AccountTransactions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountTransactions";
            this.Load += new global::System.EventHandler(this.AccountTransactions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Panel panel3;
        private global::System.Windows.Forms.Panel panel4;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox txtAccountNumber;
        private global::System.Windows.Forms.Label lblAccountBalance;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label lblAccountNames;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Button btnSearchTransactions;
        private Controls.Datagrid dgvTransactions;
        private global::System.Windows.Forms.Button btnSearchTransactionCode;
        private global::System.Windows.Forms.TextBox txtTransactionCode;
        private global::System.Windows.Forms.Label label5;
    }
}