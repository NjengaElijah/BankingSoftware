namespace Moshi_Bank.Views
{
    partial class AccountOpeningFee
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
            this.label1 = new global::System.Windows.Forms.Label();
            this.cboAccType = new global::System.Windows.Forms.ComboBox();
            this.label2 = new global::System.Windows.Forms.Label();
            this.txtFee = new global::System.Windows.Forms.TextBox();
            this.btnSaveFee = new global::System.Windows.Forms.Button();
            this.panel3 = new global::System.Windows.Forms.Panel();
            this.panel4 = new global::System.Windows.Forms.Panel();
            this.datagridFees = new Moshi_Bank.Controls.Datagrid();
            this.panel1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.datagridFees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size((System.Int32)796, (System.Int32)85);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size((System.Int32)796, (System.Int32)1);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)23F);
            this.label5.ForeColor = global::System.Drawing.Color.Black;
            this.label5.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)21);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size((System.Int32)186, (System.Int32)42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Opening Fee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = global::System.Drawing.Color.White;
            this.label1.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)15.75F);
            this.label1.ForeColor = global::System.Drawing.Color.Gray;
            this.label1.Location = new global::System.Drawing.Point((System.Int32)44, (System.Int32)119);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size((System.Int32)132, (System.Int32)30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Account Type";
            // 
            // cboAccType
            // 
            this.cboAccType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccType.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)13F);
            this.cboAccType.FormattingEnabled = true;
            this.cboAccType.Location = new global::System.Drawing.Point((System.Int32)47, (System.Int32)174);
            this.cboAccType.Name = "cboAccType";
            this.cboAccType.Size = new global::System.Drawing.Size((System.Int32)308, (System.Int32)31);
            this.cboAccType.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = global::System.Drawing.Color.White;
            this.label2.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)15.75F);
            this.label2.ForeColor = global::System.Drawing.Color.Gray;
            this.label2.Location = new global::System.Drawing.Point((System.Int32)40, (System.Int32)227);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size((System.Int32)128, (System.Int32)30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opening Fee";
            // 
            // txtFee
            // 
            this.txtFee.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)15F);
            this.txtFee.Location = new global::System.Drawing.Point((System.Int32)49, (System.Int32)293);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new global::System.Drawing.Size((System.Int32)308, (System.Int32)34);
            this.txtFee.TabIndex = 12;
            // 
            // btnSaveFee
            // 
            this.btnSaveFee.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnSaveFee.Location = new global::System.Drawing.Point((System.Int32)253, (System.Int32)364);
            this.btnSaveFee.Name = "btnSaveFee";
            this.btnSaveFee.Size = new global::System.Drawing.Size((System.Int32)102, (System.Int32)38);
            this.btnSaveFee.TabIndex = 13;
            this.btnSaveFee.Text = "Save";
            this.btnSaveFee.UseVisualStyleBackColor = true;
            this.btnSaveFee.Click += new global::System.EventHandler(this.btnSaveFee_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel3.Location = new global::System.Drawing.Point((System.Int32)28, (System.Int32)156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new global::System.Drawing.Size((System.Int32)340, (System.Int32)1);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel4.Location = new global::System.Drawing.Point((System.Int32)28, (System.Int32)269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new global::System.Drawing.Size((System.Int32)340, (System.Int32)1);
            this.panel4.TabIndex = 32;
            // 
            // datagridFees
            // 
            this.datagridFees.AllowUserToAddRows = false;
            this.datagridFees.AllowUserToDeleteRows = false;
            this.datagridFees.AllowUserToResizeColumns = false;
            this.datagridFees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = global::System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = global::System.Drawing.Color.Black;
            this.datagridFees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridFees.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridFees.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridFees.BackgroundColor = global::System.Drawing.Color.White;
            this.datagridFees.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
            this.datagridFees.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
            this.datagridFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridFees.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new global::System.Drawing.Font((System.String)"Consolas", (System.Single)12F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
            this.datagridFees.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridFees.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridFees.EnableHeadersVisualStyles = false;
            this.datagridFees.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)10F);
            this.datagridFees.Location = new global::System.Drawing.Point((System.Int32)400, (System.Int32)119);
            this.datagridFees.MultiSelect = false;
            this.datagridFees.Name = "datagridFees";
            this.datagridFees.ReadOnly = true;
            this.datagridFees.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridFees.RowHeadersVisible = false;
            this.datagridFees.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridFees.Size = new global::System.Drawing.Size((System.Int32)362, (System.Int32)283);
            this.datagridFees.TabIndex = 42;
            // 
            // AccountOpeningFee
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)7F, (System.Single)17F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)796, (System.Int32)436);
            this.Controls.Add(this.datagridFees);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSaveFee);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAccType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new global::System.Windows.Forms.Padding((System.Int32)3, (System.Int32)4, (System.Int32)3, (System.Int32)4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountOpeningFee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Fee";
            this.Load += new global::System.EventHandler(this.AccountOpeningFee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.datagridFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label5;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox txtFee;
        private global::System.Windows.Forms.Button btnSaveFee;
        private global::System.Windows.Forms.Panel panel3;
        private global::System.Windows.Forms.Panel panel4;
        private global::System.Windows.Forms.ComboBox cboAccType;
        private Controls.Datagrid datagridFees;
    }
}