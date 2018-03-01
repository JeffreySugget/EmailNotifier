namespace DatabaseInterface
{
    partial class Create
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
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.lblEmailPassword = new System.Windows.Forms.Label();
            this.btnAddEmails = new System.Windows.Forms.Button();
            this.btnAddShows = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblIpaddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(12, 10);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(45, 13);
            this.lblApiKey.TabIndex = 0;
            this.lblApiKey.Text = "API Key";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(12, 26);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(260, 20);
            this.txtApiKey.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email Address";
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.AcceptsTab = true;
            this.txtEmailPassword.Location = new System.Drawing.Point(12, 104);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(260, 20);
            this.txtEmailPassword.TabIndex = 7;
            // 
            // lblEmailPassword
            // 
            this.lblEmailPassword.AutoSize = true;
            this.lblEmailPassword.Location = new System.Drawing.Point(12, 88);
            this.lblEmailPassword.Name = "lblEmailPassword";
            this.lblEmailPassword.Size = new System.Drawing.Size(81, 13);
            this.lblEmailPassword.TabIndex = 6;
            this.lblEmailPassword.Text = "Email Password";
            // 
            // btnAddEmails
            // 
            this.btnAddEmails.Location = new System.Drawing.Point(12, 169);
            this.btnAddEmails.Name = "btnAddEmails";
            this.btnAddEmails.Size = new System.Drawing.Size(117, 23);
            this.btnAddEmails.TabIndex = 9;
            this.btnAddEmails.Text = "Add Emails";
            this.btnAddEmails.UseVisualStyleBackColor = true;
            this.btnAddEmails.Click += new System.EventHandler(this.btnAddEmails_Click);
            // 
            // btnAddShows
            // 
            this.btnAddShows.Location = new System.Drawing.Point(135, 169);
            this.btnAddShows.Name = "btnAddShows";
            this.btnAddShows.Size = new System.Drawing.Size(137, 23);
            this.btnAddShows.TabIndex = 10;
            this.btnAddShows.Text = "Add Shows";
            this.btnAddShows.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 198);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(260, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.AcceptsTab = true;
            this.txtIpAddress.Location = new System.Drawing.Point(12, 143);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(260, 20);
            this.txtIpAddress.TabIndex = 8;
            // 
            // lblIpaddress
            // 
            this.lblIpaddress.AutoSize = true;
            this.lblIpaddress.Location = new System.Drawing.Point(9, 127);
            this.lblIpaddress.Name = "lblIpaddress";
            this.lblIpaddress.Size = new System.Drawing.Size(88, 13);
            this.lblIpaddress.TabIndex = 11;
            this.lblIpaddress.Text = "Sonarr IpAddress";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.lblIpaddress);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAddShows);
            this.Controls.Add(this.btnAddEmails);
            this.Controls.Add(this.txtEmailPassword);
            this.Controls.Add(this.lblEmailPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.lblApiKey);
            this.Name = "Create";
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label lblEmailPassword;
        private System.Windows.Forms.Button btnAddEmails;
        private System.Windows.Forms.Button btnAddShows;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lblIpaddress;
    }
}