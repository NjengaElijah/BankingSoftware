namespace Moshi_Bank.Views
{
    partial class TransactionCharges
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
            this.label10 = new global::System.Windows.Forms.Label();
            this.lblSystem = new global::System.Windows.Forms.Label();
            this.label1 = new global::System.Windows.Forms.Label();
            this.cboTransactionType = new global::System.Windows.Forms.ComboBox();
            this.label9 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label4 = new global::System.Windows.Forms.Label();
            this.txtMinVal = new global::System.Windows.Forms.TextBox();
            this.txtMaxVal = new global::System.Windows.Forms.TextBox();
            this.txtCharge = new global::System.Windows.Forms.TextBox();
            this.btnNewCharge = new global::System.Windows.Forms.Button();
            this.btnUpdateExisting = new global::System.Windows.Forms.Button();
            this.tabControl1 = new global::System.Windows.Forms.TabControl();
            this.tabPage1 = new global::System.Windows.Forms.TabPage();
            this.tabPage2 = new global::System.Windows.Forms.TabPage();
            this.label6 = new global::System.Windows.Forms.Label();
            this.label5 = new global::System.Windows.Forms.Label();
            this.cboPercentageRange = new global::System.Windows.Forms.ComboBox();
            this.btnSavePercentage = new global::System.Windows.Forms.Button();
            this.numPercentage = new global::System.Windows.Forms.NumericUpDown();
            this.cboChargingSystem = new global::System.Windows.Forms.ComboBox();
            this.label7 = new global::System.Windows.Forms.Label();
            this.btnUpdateChargingSystem = new global::System.Windows.Forms.Button();
            this.dgvTransactionCharges = new Moshi_Bank.Controls.Datagrid();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.numPercentage)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvTransactionCharges)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblSystem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size((System.Int32)919, (System.Int32)67);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size((System.Int32)919, (System.Int32)1);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)26.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label10.Location = new global::System.Drawing.Point((System.Int32)332, (System.Int32)9);
            this.label10.Name = "label10";
            this.label10.Size = new global::System.Drawing.Size((System.Int32)33, (System.Int32)47);
            this.label10.TabIndex = 0;
            this.label10.Text = "/";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)18F);
            this.lblSystem.Location = new global::System.Drawing.Point((System.Int32)371, (System.Int32)21);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new global::System.Drawing.Size((System.Int32)216, (System.Int32)32);
            this.lblSystem.TabIndex = 0;
            this.lblSystem.Text = "Transaction Charges";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)26.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label1.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)9);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size((System.Int32)323, (System.Int32)47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Charges";
            // 
            // cboTransactionType
            // 
            this.cboTransactionType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransactionType.FormattingEnabled = true;
            this.cboTransactionType.Location = new global::System.Drawing.Point((System.Int32)25, (System.Int32)40);
            this.cboTransactionType.Name = "cboTransactionType";
            this.cboTransactionType.Size = new global::System.Drawing.Size((System.Int32)317, (System.Int32)25);
            this.cboTransactionType.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)11.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label9.Location = new global::System.Drawing.Point((System.Int32)21, (System.Int32)17);
            this.label9.Name = "label9";
            this.label9.Size = new global::System.Drawing.Size((System.Int32)112, (System.Int32)20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Transaction Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)11.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label2.Location = new global::System.Drawing.Point((System.Int32)21, (System.Int32)82);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size((System.Int32)67, (System.Int32)20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)11.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label3.Location = new global::System.Drawing.Point((System.Int32)21, (System.Int32)212);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size((System.Int32)54, (System.Int32)20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Charge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)11.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label4.Location = new global::System.Drawing.Point((System.Int32)21, (System.Int32)145);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size((System.Int32)69, (System.Int32)20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Maximum";
            // 
            // txtMinVal
            // 
            this.txtMinVal.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)13F);
            this.txtMinVal.Location = new global::System.Drawing.Point((System.Int32)25, (System.Int32)105);
            this.txtMinVal.Name = "txtMinVal";
            this.txtMinVal.Size = new global::System.Drawing.Size((System.Int32)317, (System.Int32)31);
            this.txtMinVal.TabIndex = 39;
            // 
            // txtMaxVal
            // 
            this.txtMaxVal.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)13F);
            this.txtMaxVal.Location = new global::System.Drawing.Point((System.Int32)25, (System.Int32)168);
            this.txtMaxVal.Name = "txtMaxVal";
            this.txtMaxVal.Size = new global::System.Drawing.Size((System.Int32)317, (System.Int32)31);
            this.txtMaxVal.TabIndex = 40;
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)13F);
            this.txtCharge.Location = new global::System.Drawing.Point((System.Int32)25, (System.Int32)235);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new global::System.Drawing.Size((System.Int32)317, (System.Int32)31);
            this.txtCharge.TabIndex = 41;
            // 
            // btnNewCharge
            // 
            this.btnNewCharge.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnNewCharge.Location = new global::System.Drawing.Point((System.Int32)25, (System.Int32)286);
            this.btnNewCharge.Name = "btnNewCharge";
            this.btnNewCharge.Size = new global::System.Drawing.Size((System.Int32)156, (System.Int32)34);
            this.btnNewCharge.TabIndex = 42;
            this.btnNewCharge.Text = "Create New";
            this.btnNewCharge.UseVisualStyleBackColor = true;
            this.btnNewCharge.Click += new global::System.EventHandler(this.btnNewCharge_Click);
            // 
            // btnUpdateExisting
            // 
            this.btnUpdateExisting.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnUpdateExisting.Location = new global::System.Drawing.Point((System.Int32)211, (System.Int32)286);
            this.btnUpdateExisting.Name = "btnUpdateExisting";
            this.btnUpdateExisting.Size = new global::System.Drawing.Size((System.Int32)131, (System.Int32)34);
            this.btnUpdateExisting.TabIndex = 43;
            this.btnUpdateExisting.Text = "Update Existing";
            this.btnUpdateExisting.UseVisualStyleBackColor = true;
            this.btnUpdateExisting.Click += new global::System.EventHandler(this.btnUpdateExisting_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new global::System.Drawing.Point((System.Int32)526, (System.Int32)73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new global::System.Drawing.Size((System.Int32)381, (System.Int32)367);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnUpdateExisting);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnNewCharge);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCharge);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtMaxVal);
            this.tabPage1.Controls.Add(this.cboTransactionType);
            this.tabPage1.Controls.Add(this.txtMinVal);
            this.tabPage1.Location = new global::System.Drawing.Point((System.Int32)4, (System.Int32)26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new global::System.Windows.Forms.Padding((System.Int32)3);
            this.tabPage1.Size = new global::System.Drawing.Size((System.Int32)373, (System.Int32)337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Value";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cboPercentageRange);
            this.tabPage2.Controls.Add(this.btnSavePercentage);
            this.tabPage2.Controls.Add(this.numPercentage);
            this.tabPage2.Location = new global::System.Drawing.Point((System.Int32)4, (System.Int32)26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new global::System.Windows.Forms.Padding((System.Int32)3);
            this.tabPage2.Size = new global::System.Drawing.Size((System.Int32)373, (System.Int32)337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Percentage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)11.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label6.Location = new global::System.Drawing.Point((System.Int32)39, (System.Int32)127);
            this.label6.Name = "label6";
            this.label6.Size = new global::System.Drawing.Size((System.Int32)79, (System.Int32)20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Percentage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)11.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label5.Location = new global::System.Drawing.Point((System.Int32)39, (System.Int32)66);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size((System.Int32)89, (System.Int32)20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Select Range";
            // 
            // cboPercentageRange
            // 
            this.cboPercentageRange.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPercentageRange.FormattingEnabled = true;
            this.cboPercentageRange.Location = new global::System.Drawing.Point((System.Int32)43, (System.Int32)89);
            this.cboPercentageRange.Name = "cboPercentageRange";
            this.cboPercentageRange.Size = new global::System.Drawing.Size((System.Int32)299, (System.Int32)25);
            this.cboPercentageRange.TabIndex = 2;
            this.cboPercentageRange.SelectedIndexChanged += new global::System.EventHandler(this.cboPercentageRange_SelectedIndexChanged);
            // 
            // btnSavePercentage
            // 
            this.btnSavePercentage.Location = new global::System.Drawing.Point((System.Int32)267, (System.Int32)191);
            this.btnSavePercentage.Name = "btnSavePercentage";
            this.btnSavePercentage.Size = new global::System.Drawing.Size((System.Int32)75, (System.Int32)32);
            this.btnSavePercentage.TabIndex = 1;
            this.btnSavePercentage.Text = "Save";
            this.btnSavePercentage.UseVisualStyleBackColor = true;
            this.btnSavePercentage.Click += new global::System.EventHandler(this.btnSavePercentage_Click);
            // 
            // numPercentage
            // 
            this.numPercentage.DecimalPlaces = 4;
            this.numPercentage.Location = new global::System.Drawing.Point((System.Int32)43, (System.Int32)150);
            this.numPercentage.Name = "numPercentage";
            this.numPercentage.Size = new global::System.Drawing.Size((System.Int32)299, (System.Int32)25);
            this.numPercentage.TabIndex = 0;
            // 
            // cboChargingSystem
            // 
            this.cboChargingSystem.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChargingSystem.FormattingEnabled = true;
            this.cboChargingSystem.Items.AddRange(new object[] {
            "Value",
            "Percentage"});
            this.cboChargingSystem.Location = new global::System.Drawing.Point((System.Int32)526, (System.Int32)477);
            this.cboChargingSystem.Name = "cboChargingSystem";
            this.cboChargingSystem.Size = new global::System.Drawing.Size((System.Int32)230, (System.Int32)25);
            this.cboChargingSystem.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)11.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label7.Location = new global::System.Drawing.Point((System.Int32)526, (System.Int32)454);
            this.label7.Name = "label7";
            this.label7.Size = new global::System.Drawing.Size((System.Int32)164, (System.Int32)20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Current Charging System";
            // 
            // btnUpdateChargingSystem
            // 
            this.btnUpdateChargingSystem.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnUpdateChargingSystem.Location = new global::System.Drawing.Point((System.Int32)772, (System.Int32)470);
            this.btnUpdateChargingSystem.Name = "btnUpdateChargingSystem";
            this.btnUpdateChargingSystem.Size = new global::System.Drawing.Size((System.Int32)131, (System.Int32)34);
            this.btnUpdateChargingSystem.TabIndex = 43;
            this.btnUpdateChargingSystem.Text = "Update";
            this.btnUpdateChargingSystem.UseVisualStyleBackColor = true;
            this.btnUpdateChargingSystem.Click += new global::System.EventHandler(this.btnUpdateChargingSystem_Click);
            // 
            // dgvTransactionCharges
            // 
            this.dgvTransactionCharges.AllowUserToAddRows = false;
            this.dgvTransactionCharges.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.Linen;
            dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.Black;
            this.dgvTransactionCharges.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransactionCharges.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTransactionCharges.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactionCharges.BackgroundColor = global::System.Drawing.Color.WhiteSmoke;
            this.dgvTransactionCharges.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
            this.dgvTransactionCharges.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionCharges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTransactionCharges.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = global::System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            dataGridViewCellStyle6.ForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = global::System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = global::System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactionCharges.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransactionCharges.EnableHeadersVisualStyles = false;
            this.dgvTransactionCharges.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)10F);
            this.dgvTransactionCharges.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)73);
            this.dgvTransactionCharges.MultiSelect = false;
            this.dgvTransactionCharges.Name = "dgvTransactionCharges";
            this.dgvTransactionCharges.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransactionCharges.RowHeadersVisible = false;
            this.dgvTransactionCharges.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionCharges.Size = new global::System.Drawing.Size((System.Int32)508, (System.Int32)463);
            this.dgvTransactionCharges.TabIndex = 35;
            this.dgvTransactionCharges.RowEnter += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionCharges_RowEnter);
            // 
            // TransactionCharges
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)7F, (System.Single)17F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)919, (System.Int32)548);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdateChargingSystem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTransactionCharges);
            this.Controls.Add(this.cboChargingSystem);
            this.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)9.75F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new global::System.Windows.Forms.Padding((System.Int32)3, (System.Int32)4, (System.Int32)3, (System.Int32)4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionCharges";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Charges";
            this.Load += new global::System.EventHandler(this.TransactionCharges_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.numPercentage)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.dgvTransactionCharges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Datagrid dgvTransactionCharges;
        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.ComboBox cboTransactionType;
        private global::System.Windows.Forms.Label label9;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.TextBox txtMinVal;
        private global::System.Windows.Forms.TextBox txtMaxVal;
        private global::System.Windows.Forms.TextBox txtCharge;
        private global::System.Windows.Forms.Button btnNewCharge;
        private global::System.Windows.Forms.Button btnUpdateExisting;
        private global::System.Windows.Forms.TabControl tabControl1;
        private global::System.Windows.Forms.TabPage tabPage1;
        private global::System.Windows.Forms.TabPage tabPage2;
        private global::System.Windows.Forms.NumericUpDown numPercentage;
        private global::System.Windows.Forms.ComboBox cboPercentageRange;
        private global::System.Windows.Forms.Button btnSavePercentage;
        private global::System.Windows.Forms.Label label6;
        private global::System.Windows.Forms.Label label5;
        private global::System.Windows.Forms.ComboBox cboChargingSystem;
        private global::System.Windows.Forms.Label label7;
        private global::System.Windows.Forms.Button btnUpdateChargingSystem;
        private global::System.Windows.Forms.Label label10;
        private global::System.Windows.Forms.Label lblSystem;
    }
}