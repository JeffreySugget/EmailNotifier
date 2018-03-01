namespace DatabaseInterface
{
    partial class Shows
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
            this.btnRefreshShows = new System.Windows.Forms.Button();
            this.dgShows = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgShows)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshShows
            // 
            this.btnRefreshShows.Location = new System.Drawing.Point(12, 587);
            this.btnRefreshShows.Name = "btnRefreshShows";
            this.btnRefreshShows.Size = new System.Drawing.Size(354, 23);
            this.btnRefreshShows.TabIndex = 0;
            this.btnRefreshShows.Text = "Refresh Shows";
            this.btnRefreshShows.UseVisualStyleBackColor = true;
            this.btnRefreshShows.Click += new System.EventHandler(this.btnRefreshShows_Click);
            // 
            // dgShows
            // 
            this.dgShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShows.Location = new System.Drawing.Point(13, 42);
            this.dgShows.Name = "dgShows";
            this.dgShows.Size = new System.Drawing.Size(703, 527);
            this.dgShows.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 587);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(344, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Shows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 622);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgShows);
            this.Controls.Add(this.btnRefreshShows);
            this.Name = "Shows";
            this.Text = "Shows";
            ((System.ComponentModel.ISupportInitialize)(this.dgShows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshShows;
        private System.Windows.Forms.DataGridView dgShows;
        private System.Windows.Forms.Button btnSave;
    }
}