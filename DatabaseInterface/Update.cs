﻿using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using DatabaseInterface.Classes;

namespace DatabaseInterface
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            GetSonarrData();
        }

        private void GetSonarrData()
        {
            try
            {
                var sql = "SELECT * FROM SonarrInfo";

                using (var sqlConn = new SQLiteConnection($"Data Source={ConfigurationManager.AppSettings["SonarrDatabasePath"]};Version=3;"))
                {
                    sqlConn.Open();

                    using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
                    {
                        var dr = sqlCmd.ExecuteReader();

                        while (dr.Read())
                        {
                            txtApiKey.Text = dr["ApiKey"].ToString();
                            txtEmail.Text = dr["Email"].ToString();
                            txtIpAddress.Text = dr["IpAddress"].ToString();
                            txtEmailPassword.Text = dr["Password"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during initialization: {ex.Message}", MessageHeading.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtEmailPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnUpdateEmails_Click(object sender, EventArgs e)
        {
            var form = new EmailManager();
            form.Show();
        }

        private void btnUpdateShows_Click(object sender, EventArgs e)
        {
            var form = new Shows();
            form.Show();
        }
    }
}