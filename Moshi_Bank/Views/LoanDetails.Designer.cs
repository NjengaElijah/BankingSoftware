namespace Moshi_Bank.Views
{
    partial class LoanDetails
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
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new global::System.Windows.Forms.DataGridViewCellStyle();
            this.datagridFixedDep = new Moshi_Bank.Controls.Datagrid();
            this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            ((global::System.ComponentModel.ISupportInitialize)(this.datagridFixedDep)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridFixedDep
            // 
            this.datagridFixedDep.AllowUserToAddRows = false;
            this.datagridFixedDep.AllowUserToDeleteRows = false;
            this.datagridFixedDep.AllowUserToResizeColumns = false;
            this.datagridFixedDep.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = global::System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.ForeColor = global::System.Drawing.Color.Black;
            this.datagridFixedDep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.datagridFixedDep.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.datagridFixedDep.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridFixedDep.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridFixedDep.BackgroundColor = global::System.Drawing.Color.White;
            this.datagridFixedDep.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
            this.datagridFixedDep.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = global::System.Drawing.Color.Bisque;
            dataGridViewCellStyle8.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle8.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
            this.datagridFixedDep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datagridFixedDep.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFixedDep.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle9.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = global::System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new global::System.Drawing.Font((System.String)"Consolas", (System.Single)12F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle9.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = global::System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
            this.datagridFixedDep.DefaultCellStyle = dataGridViewCellStyle9;
            this.datagridFixedDep.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridFixedDep.EnableHeadersVisualStyles = false;
            this.datagridFixedDep.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)10F);
            this.datagridFixedDep.Location = new global::System.Drawing.Point((System.Int32)34, (System.Int32)29);
            this.datagridFixedDep.MultiSelect = false;
            this.datagridFixedDep.Name = "datagridFixedDep";
            this.datagridFixedDep.ReadOnly = true;
            this.datagridFixedDep.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridFixedDep.RowHeadersVisible = false;
            this.datagridFixedDep.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridFixedDep.Size = new global::System.Drawing.Size((System.Int32)737, (System.Int32)426);
            this.datagridFixedDep.TabIndex = 102;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Period (Months)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Interest";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Loan Balance";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // LoanDetails
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)6F, (System.Single)13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)783, (System.Int32)510);
            this.Controls.Add(this.datagridFixedDep);
            this.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)8.25F);
            this.Name = "LoanDetails";
            this.Text = "LoanDetails";
            ((global::System.ComponentModel.ISupportInitialize)(this.datagridFixedDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.Datagrid datagridFixedDep;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}