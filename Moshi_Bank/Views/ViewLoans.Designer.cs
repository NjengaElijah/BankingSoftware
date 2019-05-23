namespace Moshi_Bank.Views
{
    partial class ViewLoans
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
            this.cboAction = new global::System.Windows.Forms.ComboBox();
            this.panel4 = new global::System.Windows.Forms.Panel();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label1 = new global::System.Windows.Forms.Label();
            this.panel3 = new global::System.Windows.Forms.Panel();
            this.panel5 = new global::System.Windows.Forms.Panel();
            this.label2 = new global::System.Windows.Forms.Label();
            this.panel6 = new global::System.Windows.Forms.Panel();
            this.txtAccNo = new global::System.Windows.Forms.TextBox();
            this.txtLoanNo = new global::System.Windows.Forms.TextBox();
            this.btnAccNo = new global::System.Windows.Forms.Button();
            this.btnLoanNo = new global::System.Windows.Forms.Button();
            this.dgvLoans = new Moshi_Bank.Controls.Datagrid();
            this.panel1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size((System.Int32)790, (System.Int32)67);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size((System.Int32)790, (System.Int32)1);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)23F);
            this.label5.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)9);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size((System.Int32)168, (System.Int32)42);
            this.label5.TabIndex = 0;
            this.label5.Text = "View Loans";
            // 
            // cboAction
            // 
            this.cboAction.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Items.AddRange(new object[] {
            "ALL",
            "PENDING",
            "APPROVED",
            "REJECTED",
            "COMPLETED",
            "NOT_COMPLETED",
            "CRITICAL"});
            this.cboAction.Location = new global::System.Drawing.Point((System.Int32)19, (System.Int32)113);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new global::System.Drawing.Size((System.Int32)226, (System.Int32)28);
            this.cboAction.TabIndex = 1;
            this.cboAction.SelectedIndexChanged += new global::System.EventHandler(this.cboAction_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel4.Location = new global::System.Drawing.Point((System.Int32)267, (System.Int32)106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new global::System.Drawing.Size((System.Int32)200, (System.Int32)1);
            this.panel4.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.label3.ForeColor = global::System.Drawing.Color.Gray;
            this.label3.Location = new global::System.Drawing.Point((System.Int32)272, (System.Int32)82);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size((System.Int32)125, (System.Int32)21);
            this.label3.TabIndex = 102;
            this.label3.Text = "Account Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.label1.ForeColor = global::System.Drawing.Color.Gray;
            this.label1.Location = new global::System.Drawing.Point((System.Int32)539, (System.Int32)82);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size((System.Int32)102, (System.Int32)21);
            this.label1.TabIndex = 102;
            this.label1.Text = "Loan Number";
            // 
            // panel3
            // 
            this.panel3.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel3.Location = new global::System.Drawing.Point((System.Int32)534, (System.Int32)106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new global::System.Drawing.Size((System.Int32)200, (System.Int32)1);
            this.panel3.TabIndex = 103;
            // 
            // panel5
            // 
            this.panel5.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel5.Location = new global::System.Drawing.Point((System.Int32)19, (System.Int32)160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new global::System.Drawing.Size((System.Int32)742, (System.Int32)1);
            this.panel5.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.label2.ForeColor = global::System.Drawing.Color.Gray;
            this.label2.Location = new global::System.Drawing.Point((System.Int32)24, (System.Int32)82);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size((System.Int32)51, (System.Int32)21);
            this.label2.TabIndex = 102;
            this.label2.Text = "Status";
            // 
            // panel6
            // 
            this.panel6.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel6.Location = new global::System.Drawing.Point((System.Int32)19, (System.Int32)106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new global::System.Drawing.Size((System.Int32)200, (System.Int32)1);
            this.panel6.TabIndex = 103;
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new global::System.Drawing.Point((System.Int32)276, (System.Int32)113);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new global::System.Drawing.Size((System.Int32)167, (System.Int32)27);
            this.txtAccNo.TabIndex = 2;
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.Location = new global::System.Drawing.Point((System.Int32)543, (System.Int32)113);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.Size = new global::System.Drawing.Size((System.Int32)157, (System.Int32)27);
            this.txtLoanNo.TabIndex = 4;
            // 
            // btnAccNo
            // 
            this.btnAccNo.Location = new global::System.Drawing.Point((System.Int32)449, (System.Int32)113);
            this.btnAccNo.Name = "btnAccNo";
            this.btnAccNo.Size = new global::System.Drawing.Size((System.Int32)42, (System.Int32)26);
            this.btnAccNo.TabIndex = 3;
            this.btnAccNo.Text = "GO";
            this.btnAccNo.UseVisualStyleBackColor = true;
            this.btnAccNo.Click += new global::System.EventHandler(this.btnAccNo_Click);
            // 
            // btnLoanNo
            // 
            this.btnLoanNo.Location = new global::System.Drawing.Point((System.Int32)704, (System.Int32)113);
            this.btnLoanNo.Name = "btnLoanNo";
            this.btnLoanNo.Size = new global::System.Drawing.Size((System.Int32)42, (System.Int32)26);
            this.btnLoanNo.TabIndex = 5;
            this.btnLoanNo.Text = "GO";
            this.btnLoanNo.UseVisualStyleBackColor = true;
            this.btnLoanNo.Click += new global::System.EventHandler(this.btnLoanNo_Click);
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AllowUserToResizeColumns = false;
            this.dgvLoans.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = global::System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = global::System.Drawing.Color.Black;
            this.dgvLoans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoans.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoans.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoans.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoans.BackgroundColor = global::System.Drawing.Color.White;
            this.dgvLoans.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
            this.dgvLoans.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoans.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new global::System.Drawing.Font((System.String)"Microsoft Sans Serif", (System.Single)9.749999F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoans.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoans.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLoans.EnableHeadersVisualStyles = false;
            this.dgvLoans.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)10F);
            this.dgvLoans.Location = new global::System.Drawing.Point((System.Int32)37, (System.Int32)167);
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLoans.RowHeadersVisible = false;
            this.dgvLoans.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new global::System.Drawing.Size((System.Int32)709, (System.Int32)378);
            this.dgvLoans.TabIndex = 93;
            this.dgvLoans.CellContentDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellContentDoubleClick);
            // 
            // ViewLoans
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)8F, (System.Single)20F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)790, (System.Int32)544);
            this.Controls.Add(this.btnLoanNo);
            this.Controls.Add(this.btnAccNo);
            this.Controls.Add(this.txtLoanNo);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.panel1);
            this.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)11.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.Margin = new global::System.Windows.Forms.Padding((System.Int32)4, (System.Int32)5, (System.Int32)4, (System.Int32)5);
            this.MinimizeBox = false;
            this.Name = "ViewLoans";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Loans";
            this.Load += new global::System.EventHandler(this.ViewLoans_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label5;
        private Controls.Datagrid dgvLoans;
        private global::System.Windows.Forms.ComboBox cboAction;
        private global::System.Windows.Forms.Panel panel4;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Panel panel3;
        private global::System.Windows.Forms.Panel panel5;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Panel panel6;
        private global::System.Windows.Forms.TextBox txtAccNo;
        private global::System.Windows.Forms.TextBox txtLoanNo;
        private global::System.Windows.Forms.Button btnAccNo;
        private global::System.Windows.Forms.Button btnLoanNo;
    }
}