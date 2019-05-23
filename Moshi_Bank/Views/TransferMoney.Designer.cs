namespace Moshi_Bank.Views
{
    partial class TransferMoney
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.btnProcessTransaction = new System.Windows.Forms.Button();
            this.txtSourceAccNames = new System.Windows.Forms.TextBox();
            this.txtSourceAccNumber = new System.Windows.Forms.TextBox();
            this.txtSourceAccBalance = new System.Windows.Forms.TextBox();
            this.txtDestinationAccNames = new System.Windows.Forms.TextBox();
            this.txtDestinationAccNumber = new System.Windows.Forms.TextBox();
            this.findUserDestination = new Moshi_Bank.Controls.FindUser();
            this.findUserSource = new Moshi_Bank.Controls.FindUser();
            this.txtSenderAccPin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 67);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 1);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 23F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Transfer Money";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(365, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 1);
            this.panel3.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.label12.Location = new System.Drawing.Point(371, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Source Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.label1.Location = new System.Drawing.Point(371, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Destination Account";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(365, 362);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 1);
            this.panel4.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.Location = new System.Drawing.Point(386, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Account Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.Location = new System.Drawing.Point(386, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label4.Location = new System.Drawing.Point(386, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label6.Location = new System.Drawing.Point(386, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Account Names";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label7.Location = new System.Drawing.Point(386, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.label8.Location = new System.Drawing.Point(371, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Transaction";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(365, 530);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 1);
            this.panel5.TabIndex = 33;
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionAmount.Location = new System.Drawing.Point(387, 559);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(186, 43);
            this.txtTransactionAmount.TabIndex = 35;
            // 
            // btnProcessTransaction
            // 
            this.btnProcessTransaction.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnProcessTransaction.Location = new System.Drawing.Point(682, 608);
            this.btnProcessTransaction.Name = "btnProcessTransaction";
            this.btnProcessTransaction.Size = new System.Drawing.Size(83, 28);
            this.btnProcessTransaction.TabIndex = 36;
            this.btnProcessTransaction.Text = "Proceed";
            this.btnProcessTransaction.UseVisualStyleBackColor = true;
            this.btnProcessTransaction.Click += new System.EventHandler(this.btnProcessTransaction_Click);
            // 
            // txtSourceAccNames
            // 
            this.txtSourceAccNames.Location = new System.Drawing.Point(410, 183);
            this.txtSourceAccNames.Name = "txtSourceAccNames";
            this.txtSourceAccNames.ReadOnly = true;
            this.txtSourceAccNames.Size = new System.Drawing.Size(355, 22);
            this.txtSourceAccNames.TabIndex = 37;
            this.txtSourceAccNames.TabStop = false;
            // 
            // txtSourceAccNumber
            // 
            this.txtSourceAccNumber.Location = new System.Drawing.Point(410, 239);
            this.txtSourceAccNumber.Name = "txtSourceAccNumber";
            this.txtSourceAccNumber.ReadOnly = true;
            this.txtSourceAccNumber.Size = new System.Drawing.Size(355, 22);
            this.txtSourceAccNumber.TabIndex = 37;
            this.txtSourceAccNumber.TabStop = false;
            // 
            // txtSourceAccBalance
            // 
            this.txtSourceAccBalance.Location = new System.Drawing.Point(410, 295);
            this.txtSourceAccBalance.Name = "txtSourceAccBalance";
            this.txtSourceAccBalance.ReadOnly = true;
            this.txtSourceAccBalance.Size = new System.Drawing.Size(355, 22);
            this.txtSourceAccBalance.TabIndex = 37;
            this.txtSourceAccBalance.TabStop = false;
            // 
            // txtDestinationAccNames
            // 
            this.txtDestinationAccNames.Location = new System.Drawing.Point(410, 404);
            this.txtDestinationAccNames.Name = "txtDestinationAccNames";
            this.txtDestinationAccNames.ReadOnly = true;
            this.txtDestinationAccNames.Size = new System.Drawing.Size(355, 22);
            this.txtDestinationAccNames.TabIndex = 37;
            this.txtDestinationAccNames.TabStop = false;
            // 
            // txtDestinationAccNumber
            // 
            this.txtDestinationAccNumber.Location = new System.Drawing.Point(410, 457);
            this.txtDestinationAccNumber.Name = "txtDestinationAccNumber";
            this.txtDestinationAccNumber.ReadOnly = true;
            this.txtDestinationAccNumber.Size = new System.Drawing.Size(355, 22);
            this.txtDestinationAccNumber.TabIndex = 37;
            this.txtDestinationAccNumber.TabStop = false;
            // 
            // findUserDestination
            // 
            this.findUserDestination.Account = null;
            this.findUserDestination.AdvancedFind = true;
            this.findUserDestination.BackColor = System.Drawing.Color.Honeydew;
            this.findUserDestination.Connection = null;
            this.findUserDestination.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findUserDestination.Location = new System.Drawing.Point(860, 85);
            this.findUserDestination.Name = "findUserDestination";
            this.findUserDestination.Size = new System.Drawing.Size(318, 551);
            this.findUserDestination.TabIndex = 2;
            this.findUserDestination.User = null;
            this.findUserDestination.FoundUser += new Moshi_Bank.Controls.FindUser.FindUserEvents(this.findUserDestination_FoundUser);
            // 
            // findUserSource
            // 
            this.findUserSource.Account = null;
            this.findUserSource.AdvancedFind = true;
            this.findUserSource.BackColor = System.Drawing.Color.SeaShell;
            this.findUserSource.Connection = null;
            this.findUserSource.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findUserSource.Location = new System.Drawing.Point(12, 85);
            this.findUserSource.Name = "findUserSource";
            this.findUserSource.Size = new System.Drawing.Size(318, 551);
            this.findUserSource.TabIndex = 1;
            this.findUserSource.User = null;
            this.findUserSource.FoundUser += new Moshi_Bank.Controls.FindUser.FindUserEvents(this.findUserSource_FoundUser);
            // 
            // txtSenderAccPin
            // 
            this.txtSenderAccPin.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderAccPin.Location = new System.Drawing.Point(579, 559);
            this.txtSenderAccPin.Name = "txtSenderAccPin";
            this.txtSenderAccPin.Size = new System.Drawing.Size(186, 43);
            this.txtSenderAccPin.TabIndex = 35;
            this.txtSenderAccPin.UseSystemPasswordChar = true;
            this.txtSenderAccPin.TextChanged += new System.EventHandler(this.txtSenderAccPin_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label9.Location = new System.Drawing.Point(386, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label10.Location = new System.Drawing.Point(575, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Sender Account PIN";
            // 
            // TransferMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 648);
            this.Controls.Add(this.txtDestinationAccNumber);
            this.Controls.Add(this.txtDestinationAccNames);
            this.Controls.Add(this.txtSourceAccBalance);
            this.Controls.Add(this.txtSourceAccNumber);
            this.Controls.Add(this.txtSourceAccNames);
            this.Controls.Add(this.btnProcessTransaction);
            this.Controls.Add(this.txtSenderAccPin);
            this.Controls.Add(this.txtTransactionAmount);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.findUserDestination);
            this.Controls.Add(this.findUserSource);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferMoney";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Money";
            this.Load += new System.EventHandler(this.TransferMoney_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label5;
        private Controls.FindUser findUserSource;
        private Controls.FindUser findUserDestination;
        private global::System.Windows.Forms.Panel panel3;
        private global::System.Windows.Forms.Label label12;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Panel panel4;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Label label6;
        private global::System.Windows.Forms.Label label7;
        private global::System.Windows.Forms.Label label8;
        private global::System.Windows.Forms.Panel panel5;
        private global::System.Windows.Forms.TextBox txtTransactionAmount;
        private global::System.Windows.Forms.Button btnProcessTransaction;
        private global::System.Windows.Forms.TextBox txtSourceAccNames;
        private global::System.Windows.Forms.TextBox txtSourceAccNumber;
        private global::System.Windows.Forms.TextBox txtSourceAccBalance;
        private global::System.Windows.Forms.TextBox txtDestinationAccNames;
        private global::System.Windows.Forms.TextBox txtDestinationAccNumber;
        private System.Windows.Forms.TextBox txtSenderAccPin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}