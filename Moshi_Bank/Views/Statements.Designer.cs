namespace Moshi_Bank.Views
{
    partial class Statements
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
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.panel2 = new global::System.Windows.Forms.Panel();
            this.label5 = new global::System.Windows.Forms.Label();
            this.panel3 = new global::System.Windows.Forms.Panel();
            this.label4 = new global::System.Windows.Forms.Label();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.panel4 = new global::System.Windows.Forms.Panel();
            this.dgvTransactions = new Moshi_Bank.Controls.Datagrid();
            this.dtpStartDate = new global::System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new global::System.Windows.Forms.DateTimePicker();
            this.findUser1 = new Moshi_Bank.Controls.FindUser();
            this.btnProcess = new global::System.Windows.Forms.Button();
            this.checkBox1 = new global::System.Windows.Forms.CheckBox();
            this.txtAccountNames = new global::System.Windows.Forms.Label();
            this.txtAccountBalance = new global::System.Windows.Forms.Label();
            this.cboType = new global::System.Windows.Forms.ComboBox();
            this.panel5 = new global::System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size((System.Int32)1071, (System.Int32)55);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size((System.Int32)1071, (System.Int32)1);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)23F);
            this.label5.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)9);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size((System.Int32)285, (System.Int32)42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account Statements";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.cboType);
            this.panel3.Controls.Add(this.btnProcess);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.dtpEndDate);
            this.panel3.Controls.Add(this.dtpStartDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new global::System.Drawing.Point((System.Int32)331, (System.Int32)57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new global::System.Drawing.Size((System.Int32)728, (System.Int32)151);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)12F);
            this.label4.Location = new global::System.Drawing.Point((System.Int32)465, (System.Int32)12);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size((System.Int32)123, (System.Int32)21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Transaction Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)12F);
            this.label3.Location = new global::System.Drawing.Point((System.Int32)247, (System.Int32)14);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size((System.Int32)72, (System.Int32)21);
            this.label3.TabIndex = 0;
            this.label3.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)12F);
            this.label2.Location = new global::System.Drawing.Point((System.Int32)19, (System.Int32)14);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size((System.Int32)76, (System.Int32)21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new global::System.Drawing.Size((System.Int32)728, (System.Int32)1);
            this.panel4.TabIndex = 1;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeColumns = false;
            this.dgvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = global::System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = global::System.Drawing.Color.Black;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactions.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTransactions.BackgroundColor = global::System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactions.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)10F);
            this.dgvTransactions.Location = new global::System.Drawing.Point((System.Int32)331, (System.Int32)214);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new global::System.Drawing.Size((System.Int32)725, (System.Int32)400);
            this.dgvTransactions.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)9.75F);
            this.dtpStartDate.CalendarTitleBackColor = global::System.Drawing.Color.MistyRose;
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Font = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)9.75F);
            this.dtpStartDate.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new global::System.Drawing.Point((System.Int32)23, (System.Int32)47);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new global::System.Drawing.Size((System.Int32)211, (System.Int32)22);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)9.75F);
            this.dtpEndDate.CalendarTitleBackColor = global::System.Drawing.Color.MistyRose;
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Font = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)9.75F);
            this.dtpEndDate.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new global::System.Drawing.Point((System.Int32)251, (System.Int32)47);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new global::System.Drawing.Size((System.Int32)211, (System.Int32)22);
            this.dtpEndDate.TabIndex = 2;
            // 
            // findUser1
            // 
            this.findUser1.Account = null;
            this.findUser1.BackColor = global::System.Drawing.Color.Ivory;
            this.findUser1.Connection = null;
            this.findUser1.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)8.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.findUser1.Location = new global::System.Drawing.Point((System.Int32)7, (System.Int32)57);
            this.findUser1.Name = "findUser1";
            this.findUser1.Size = new global::System.Drawing.Size((System.Int32)318, (System.Int32)551);
            this.findUser1.TabIndex = 0;
            this.findUser1.User = null;
            this.findUser1.FoundUser += new Moshi_Bank.Controls.FindUser.FindUserEvents(this.findUser1_FoundUser);
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnProcess.Location = new global::System.Drawing.Point((System.Int32)121, (System.Int32)97);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new global::System.Drawing.Size((System.Int32)113, (System.Int32)32);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Search";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new global::System.EventHandler(this.btnProcess_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new global::System.Drawing.Point((System.Int32)23, (System.Int32)105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new global::System.Drawing.Size((System.Int32)81, (System.Int32)17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Date & Type";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtAccountNames
            // 
            this.txtAccountNames.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.txtAccountNames.Font = new global::System.Drawing.Font((System.String)"Raleway", (System.Single)12F);
            this.txtAccountNames.ForeColor = global::System.Drawing.Color.DarkGreen;
            this.txtAccountNames.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)0);
            this.txtAccountNames.Name = "txtAccountNames";
            this.txtAccountNames.Size = new global::System.Drawing.Size((System.Int32)174, (System.Int32)52);
            this.txtAccountNames.TabIndex = 0;
            this.txtAccountNames.Text = "Empty";
            this.txtAccountNames.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Dock = global::System.Windows.Forms.DockStyle.Right;
            this.txtAccountBalance.Font = new global::System.Drawing.Font((System.String)"Consolas", (System.Single)15F);
            this.txtAccountBalance.ForeColor = global::System.Drawing.Color.MediumVioletRed;
            this.txtAccountBalance.Location = new global::System.Drawing.Point((System.Int32)174, (System.Int32)0);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new global::System.Drawing.Size((System.Int32)298, (System.Int32)52);
            this.txtAccountBalance.TabIndex = 0;
            this.txtAccountBalance.Text = "0.00";
            this.txtAccountBalance.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboType
            // 
            this.cboType.BackColor = global::System.Drawing.Color.WhiteSmoke;
            this.cboType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new global::System.Drawing.Font((System.String)"Consolas", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "All",
            "Deposits",
            "Withdrawals",
            "SentReceived"});
            this.cboType.Location = new global::System.Drawing.Point((System.Int32)469, (System.Int32)47);
            this.cboType.Name = "cboType";
            this.cboType.Size = new global::System.Drawing.Size((System.Int32)181, (System.Int32)23);
            this.cboType.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtAccountNames);
            this.panel5.Controls.Add(this.txtAccountBalance);
            this.panel5.Location = new global::System.Drawing.Point((System.Int32)251, (System.Int32)90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new global::System.Drawing.Size((System.Int32)474, (System.Int32)54);
            this.panel5.TabIndex = 11;
            // 
            // Statements
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)7F, (System.Single)13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)1071, (System.Int32)615);
            this.Controls.Add(this.findUser1);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new global::System.Drawing.Font((System.String)"Raleway", (System.Single)8.249999F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "Statements";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Statements";
            this.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label5;
        private global::System.Windows.Forms.Panel panel3;
        private global::System.Windows.Forms.Panel panel4;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label2;
        private Controls.Datagrid dgvTransactions;
        private global::System.Windows.Forms.DateTimePicker dtpEndDate;
        private global::System.Windows.Forms.DateTimePicker dtpStartDate;
        private Controls.FindUser findUser1;
        private global::System.Windows.Forms.Button btnProcess;
        private global::System.Windows.Forms.CheckBox checkBox1;
        private global::System.Windows.Forms.Label txtAccountBalance;
        private global::System.Windows.Forms.Label txtAccountNames;
        private global::System.Windows.Forms.ComboBox cboType;
        private global::System.Windows.Forms.Panel panel5;
    }
}