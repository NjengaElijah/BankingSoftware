namespace Moshi_Bank.Views
{
    partial class Settings
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
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.panel2 = new global::System.Windows.Forms.Panel();
            this.label1 = new global::System.Windows.Forms.Label();
            this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
            this.btnStart = new global::System.Windows.Forms.Button();
            this.btnStop = new global::System.Windows.Forms.Button();
            this.btnBrowse = new global::System.Windows.Forms.Button();
            this.panel3 = new global::System.Windows.Forms.Panel();
            this.txtCurrPass = new global::System.Windows.Forms.TextBox();
            this.txtNewPass = new global::System.Windows.Forms.TextBox();
            this.txtConfPass = new global::System.Windows.Forms.TextBox();
            this.btnSave = new global::System.Windows.Forms.Button();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.title4 = new Moshi_Bank.Controls.Title();
            this.title3 = new Moshi_Bank.Controls.Title();
            this.title2 = new Moshi_Bank.Controls.Title();
            this.title1 = new Moshi_Bank.Controls.Title();
            this.panel1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size((System.Int32)637, (System.Int32)67);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new global::System.Drawing.Size((System.Int32)637, (System.Int32)1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font((System.String)"Segoe UI Semilight", (System.Single)26.25F, (global::System.Drawing.FontStyle)global::System.Drawing.FontStyle.Regular, (global::System.Drawing.GraphicsUnit)global::System.Drawing.GraphicsUnit.Point, (System.Byte)((byte)(0)));
            this.label1.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)9);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size((System.Int32)139, (System.Int32)47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new global::System.Drawing.Point((System.Int32)32, (System.Int32)131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new global::System.Drawing.Size((System.Int32)182, (System.Int32)181);
            this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnStart.Location = new global::System.Drawing.Point((System.Int32)32, (System.Int32)318);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new global::System.Drawing.Size((System.Int32)85, (System.Int32)35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnStop.Location = new global::System.Drawing.Point((System.Int32)123, (System.Int32)318);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new global::System.Drawing.Size((System.Int32)91, (System.Int32)35);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnBrowse.Location = new global::System.Drawing.Point((System.Int32)32, (System.Int32)355);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new global::System.Drawing.Size((System.Int32)182, (System.Int32)40);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new global::System.EventHandler(this.btnBrowse_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = global::System.Drawing.Color.DarkGray;
            this.panel3.Location = new global::System.Drawing.Point((System.Int32)0, (System.Int32)401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new global::System.Drawing.Size((System.Int32)637, (System.Int32)1);
            this.panel3.TabIndex = 8;
            // 
            // txtCurrPass
            // 
            this.txtCurrPass.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)12F);
            this.txtCurrPass.Location = new global::System.Drawing.Point((System.Int32)310, (System.Int32)133);
            this.txtCurrPass.Name = "txtCurrPass";
            this.txtCurrPass.Size = new global::System.Drawing.Size((System.Int32)281, (System.Int32)29);
            this.txtCurrPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)12F);
            this.txtNewPass.Location = new global::System.Drawing.Point((System.Int32)310, (System.Int32)217);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new global::System.Drawing.Size((System.Int32)281, (System.Int32)29);
            this.txtNewPass.TabIndex = 5;
            // 
            // txtConfPass
            // 
            this.txtConfPass.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)12F);
            this.txtConfPass.Location = new global::System.Drawing.Point((System.Int32)310, (System.Int32)297);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new global::System.Drawing.Size((System.Int32)281, (System.Int32)29);
            this.txtConfPass.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new global::System.Drawing.Font((System.String)"Segoe UI Light", (System.Single)12F);
            this.btnSave.Location = new global::System.Drawing.Point((System.Int32)483, (System.Int32)410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new global::System.Drawing.Size((System.Int32)109, (System.Int32)31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = global::System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((global::System.Drawing.Image)(resources.GetObject((System.String)"bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = global::System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new global::System.Drawing.Point((System.Int32)310, (System.Int32)355);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = global::System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new global::System.Drawing.Size((System.Int32)43, (System.Int32)25);
            this.bunifuiOSSwitch1.TabIndex = 9;
            this.bunifuiOSSwitch1.Value = false;
            this.bunifuiOSSwitch1.OnValueChange += new global::System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // title4
            // 
            this.title4.BackColor = global::System.Drawing.Color.White;
            this.title4.LineColor = global::System.Drawing.Color.DarkGray;
            this.title4.Location = new global::System.Drawing.Point((System.Int32)289, (System.Int32)255);
            this.title4.Name = "title4";
            this.title4.Size = new global::System.Drawing.Size((System.Int32)289, (System.Int32)41);
            this.title4.TabIndex = 5;
            this.title4.TextColor = global::System.Drawing.Color.Gray;
            this.title4.TitleText = "Confirm Password";
            // 
            // title3
            // 
            this.title3.BackColor = global::System.Drawing.Color.White;
            this.title3.LineColor = global::System.Drawing.Color.DarkGray;
            this.title3.Location = new global::System.Drawing.Point((System.Int32)289, (System.Int32)170);
            this.title3.Name = "title3";
            this.title3.Size = new global::System.Drawing.Size((System.Int32)289, (System.Int32)41);
            this.title3.TabIndex = 5;
            this.title3.TextColor = global::System.Drawing.Color.Gray;
            this.title3.TitleText = "New Password";
            // 
            // title2
            // 
            this.title2.BackColor = global::System.Drawing.Color.White;
            this.title2.LineColor = global::System.Drawing.Color.DarkGray;
            this.title2.Location = new global::System.Drawing.Point((System.Int32)289, (System.Int32)86);
            this.title2.Name = "title2";
            this.title2.Size = new global::System.Drawing.Size((System.Int32)289, (System.Int32)41);
            this.title2.TabIndex = 5;
            this.title2.TextColor = global::System.Drawing.Color.Gray;
            this.title2.TitleText = "Current Password";
            // 
            // title1
            // 
            this.title1.BackColor = global::System.Drawing.Color.White;
            this.title1.LineColor = global::System.Drawing.Color.DarkGray;
            this.title1.Location = new global::System.Drawing.Point((System.Int32)12, (System.Int32)86);
            this.title1.Name = "title1";
            this.title1.Size = new global::System.Drawing.Size((System.Int32)238, (System.Int32)41);
            this.title1.TabIndex = 5;
            this.title1.TextColor = global::System.Drawing.Color.Gray;
            this.title1.TitleText = "Photo";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF((System.Single)6F, (System.Single)13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.ClientSize = new global::System.Drawing.Size((System.Int32)637, (System.Int32)453);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.txtConfPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurrPass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title4);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.panel1);
            this.Font = new global::System.Drawing.Font((System.String)"Segoe UI", (System.Single)8.25F);
            this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new global::System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.Label label1;
        private Controls.Title title1;
        private Controls.Title title2;
        private Controls.Title title3;
        private Controls.Title title4;
        private global::System.Windows.Forms.PictureBox pictureBox1;
        private global::System.Windows.Forms.Button btnStart;
        private global::System.Windows.Forms.Button btnStop;
        private global::System.Windows.Forms.Button btnBrowse;
        private global::System.Windows.Forms.Panel panel3;
        private global::System.Windows.Forms.TextBox txtCurrPass;
        private global::System.Windows.Forms.TextBox txtNewPass;
        private global::System.Windows.Forms.TextBox txtConfPass;
        private global::System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
    }
}