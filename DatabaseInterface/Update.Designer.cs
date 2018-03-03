namespace DatabaseInterface
{
    partial class Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblIpaddress = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateShows = new System.Windows.Forms.Button();
            this.btnUpdateEmails = new System.Windows.Forms.Button();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.lblEmailPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.AcceptsTab = true;
            this.txtIpAddress.Location = new System.Drawing.Point(12, 140);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(260, 20);
            this.txtIpAddress.TabIndex = 18;
            // 
            // lblIpaddress
            // 
            this.lblIpaddress.AutoSize = true;
            this.lblIpaddress.Location = new System.Drawing.Point(9, 124);
            this.lblIpaddress.Name = "lblIpaddress";
            this.lblIpaddress.Size = new System.Drawing.Size(88, 13);
            this.lblIpaddress.TabIndex = 21;
            this.lblIpaddress.Text = "Sonarr IpAddress";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(260, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update Database";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateShows
            // 
            this.btnUpdateShows.Location = new System.Drawing.Point(135, 166);
            this.btnUpdateShows.Name = "btnUpdateShows";
            this.btnUpdateShows.Size = new System.Drawing.Size(137, 23);
            this.btnUpdateShows.TabIndex = 20;
            this.btnUpdateShows.Text = "Update Shows";
            this.btnUpdateShows.UseVisualStyleBackColor = true;
            this.btnUpdateShows.Click += new System.EventHandler(this.btnUpdateShows_Click);
            // 
            // btnUpdateEmails
            // 
            this.btnUpdateEmails.Location = new System.Drawing.Point(12, 166);
            this.btnUpdateEmails.Name = "btnUpdateEmails";
            this.btnUpdateEmails.Size = new System.Drawing.Size(117, 23);
            this.btnUpdateEmails.TabIndex = 19;
            this.btnUpdateEmails.Text = "Update Emails";
            this.btnUpdateEmails.UseVisualStyleBackColor = true;
            this.btnUpdateEmails.Click += new System.EventHandler(this.btnUpdateEmails_Click);
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.AcceptsTab = true;
            this.txtEmailPassword.Location = new System.Drawing.Point(12, 101);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(260, 20);
            this.txtEmailPassword.TabIndex = 17;
            // 
            // lblEmailPassword
            // 
            this.lblEmailPassword.AutoSize = true;
            this.lblEmailPassword.Location = new System.Drawing.Point(12, 85);
            this.lblEmailPassword.Name = "lblEmailPassword";
            this.lblEmailPassword.Size = new System.Drawing.Size(81, 13);
            this.lblEmailPassword.TabIndex = 16;
            this.lblEmailPassword.Text = "Email Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 46);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email Address";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(12, 23);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(260, 20);
            this.txtApiKey.TabIndex = 13;
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(12, 7);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(45, 13);
            this.lblApiKey.TabIndex = 12;
            this.lblApiKey.Text = "API Key";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(99, 84);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkShowPassword.TabIndex = 23;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 228);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.lblIpaddress);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpdateShows);
            this.Controls.Add(this.btnUpdateEmails);
            this.Controls.Add(this.txtEmailPassword);
            this.Controls.Add(this.lblEmailPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.lblApiKey);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lblIpaddress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateShows;
        private System.Windows.Forms.Button btnUpdateEmails;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label lblEmailPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}