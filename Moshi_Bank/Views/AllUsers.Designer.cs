namespace Moshi_Bank.Views
{
    partial class AllUsers
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
            this.lblCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNatId = new System.Windows.Forms.TextBox();
            this.btnNatIdGo = new System.Windows.Forms.Button();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.btnNamesGo = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEmailGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.title3 = new Moshi_Bank.Controls.Title();
            this.title2 = new Moshi_Bank.Controls.Title();
            this.title1 = new Moshi_Bank.Controls.Title();
            this.dgvUserAccounts = new Moshi_Bank.Controls.Datagrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 85);
            this.panel1.TabIndex = 94;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 1);
            this.panel2.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.lblCount.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCount.Location = new System.Drawing.Point(364, 6);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(44, 54);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(140, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(323, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(181, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Users";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 54);
            this.label5.TabIndex = 0;
            this.label5.Text = "Users";
            // 
            // txtNatId
            // 
            this.txtNatId.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txtNatId.Location = new System.Drawing.Point(41, 169);
            this.txtNatId.Name = "txtNatId";
            this.txtNatId.Size = new System.Drawing.Size(180, 31);
            this.txtNatId.TabIndex = 1;
            this.txtNatId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNatId_KeyDown);
            // 
            // btnNatIdGo
            // 
            this.btnNatIdGo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnNatIdGo.Location = new System.Drawing.Point(227, 170);
            this.btnNatIdGo.Name = "btnNatIdGo";
            this.btnNatIdGo.Size = new System.Drawing.Size(56, 30);
            this.btnNatIdGo.TabIndex = 2;
            this.btnNatIdGo.Text = "GO";
            this.btnNatIdGo.UseVisualStyleBackColor = true;
            this.btnNatIdGo.Click += new System.EventHandler(this.btnNatIdGo_Click);
            // 
            // txtNames
            // 
            this.txtNames.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txtNames.Location = new System.Drawing.Point(41, 262);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(180, 31);
            this.txtNames.TabIndex = 3;
            this.txtNames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNames_KeyDown);
            // 
            // btnNamesGo
            // 
            this.btnNamesGo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnNamesGo.Location = new System.Drawing.Point(227, 263);
            this.btnNamesGo.Name = "btnNamesGo";
            this.btnNamesGo.Size = new System.Drawing.Size(56, 30);
            this.btnNamesGo.TabIndex = 4;
            this.btnNamesGo.Text = "GO";
            this.btnNamesGo.UseVisualStyleBackColor = true;
            this.btnNamesGo.Click += new System.EventHandler(this.btnNamesGo_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txtEmail.Location = new System.Drawing.Point(37, 354);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 31);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // btnEmailGo
            // 
            this.btnEmailGo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnEmailGo.Location = new System.Drawing.Point(223, 355);
            this.btnEmailGo.Name = "btnEmailGo";
            this.btnEmailGo.Size = new System.Drawing.Size(56, 30);
            this.btnEmailGo.TabIndex = 6;
            this.btnEmailGo.Text = "GO";
            this.btnEmailGo.UseVisualStyleBackColor = true;
            this.btnEmailGo.Click += new System.EventHandler(this.btnEmailGo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(335, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sort : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALL",
            "WITH ACCOUNTS",
            "WITHOUT ACCOUNTS"});
            this.comboBox1.Location = new System.Drawing.Point(391, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 29);
            this.comboBox1.TabIndex = 98;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // title3
            // 
            this.title3.BackColor = System.Drawing.Color.White;
            this.title3.LineColor = System.Drawing.Color.DarkGray;
            this.title3.Location = new System.Drawing.Point(19, 307);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(295, 41);
            this.title3.TabIndex = 97;
            this.title3.TextColor = System.Drawing.Color.Gray;
            this.title3.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.title3.TitleText = "Email";
            // 
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.White;
            this.title2.LineColor = System.Drawing.Color.DarkGray;
            this.title2.Location = new System.Drawing.Point(23, 215);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(295, 41);
            this.title2.TabIndex = 97;
            this.title2.TextColor = System.Drawing.Color.Gray;
            this.title2.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.title2.TitleText = "Names";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.White;
            this.title1.LineColor = System.Drawing.Color.Silver;
            this.title1.Location = new System.Drawing.Point(23, 122);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(295, 41);
            this.title1.TabIndex = 96;
            this.title1.TextColor = System.Drawing.Color.DimGray;
            this.title1.TextFont = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.title1.TitleText = "National Id";
            // 
            // dgvUserAccounts
            // 
            this.dgvUserAccounts.AllowUserToAddRows = false;
            this.dgvUserAccounts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvUserAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUserAccounts.EnableHeadersVisualStyles = false;
            this.dgvUserAccounts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvUserAccounts.Location = new System.Drawing.Point(334, 170);
            this.dgvUserAccounts.MultiSelect = false;
            this.dgvUserAccounts.Name = "dgvUserAccounts";
            this.dgvUserAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUserAccounts.RowHeadersVisible = false;
            this.dgvUserAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAccounts.Size = new System.Drawing.Size(616, 402);
            this.dgvUserAccounts.TabIndex = 95;
            this.dgvUserAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserAccounts_CellContentClick);
            this.dgvUserAccounts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserAccounts_CellContentDoubleClick);
            this.dgvUserAccounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserAccounts_CellContentDoubleClick);
            // 
            // AllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 584);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.btnEmailGo);
            this.Controls.Add(this.btnNamesGo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNatIdGo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.txtNatId);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.dgvUserAccounts);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.Name = "AllUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Users";
            this.Load += new System.EventHandler(this.AllUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 
        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label5;
        private Controls.Datagrid dgvUserAccounts;
        private Controls.Title title1;
        private global::System.Windows.Forms.TextBox txtNatId;
        private global::System.Windows.Forms.Button btnNatIdGo;
        private global::System.Windows.Forms.Label lblCount;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox txtNames;
        private global::System.Windows.Forms.Button btnNamesGo;
        private Controls.Title title2;
        private global::System.Windows.Forms.TextBox txtEmail;
        private global::System.Windows.Forms.Button btnEmailGo;
        private Controls.Title title3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}